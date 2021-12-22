using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using iRacingSDK;
using iRacingSDK.Support;

namespace FuelCalculator
{

    public class TelemManager
    {
        private const double gallonRatio = 0.2641729;

        private Thread telemTrd;
        private TextBox telemDisplay;

        private iRacingConnection iracing;
        private iRacingEvents events;

        private DateTime time;
        
        private int currentLap = 0;
        private double lastLapFuel = 0;

        public double fuelUsage { get; set; } = 0;
        public double maxFuel { get; set; } = 0;
        public string lapTimeString { get; set; }
        public bool gallons { get; set; } = true;
        public bool dataValid { get; set; } = false;

        public TelemManager()
        {
            telemTrd = new Thread(new ThreadStart(this.telemLoop));
                
            telemTrd.IsBackground = true;
        }

        public void startTelem(ref TextBox telemDisplay)
        {
            this.telemDisplay = telemDisplay;
            telemTrd.Start();
        }

        /**
         * The worker loop for iracing telemetry
         */
        private void telemLoop()
        {
            // begin listening for live iracing telem connection
            iracing = new iRacingConnection();
            events = new iRacingEvents();

            events.Connected += iracingConnected;
            events.Disconnected += iracingDisconnected;

            events.StartListening();

            printLine("Attempting to connect...");

            

            try
            {
                int i = 0;

                foreach (DataSample d in iRacing.GetDataFeed())
                {
                    if (i % 600 == 0 && d.IsConnected)
                    {
                        Telemetry t = d.Telemetry;
                        // do calculation every lap
                        if(this.currentLap != t.Lap)
                        {
                            this.maxFuel = d.SessionData.DriverInfo.DriverCarFuelMaxLtr;
                            this.currentLap = t.Lap;

                            // calculate fuel used this lap
                            if(this.lastLapFuel != 0 && this.lastLapFuel - t.FuelLevel > 0)
                            {
                                this.fuelUsage = this.lastLapFuel - t.FuelLevel;
                                TimeSpan lapTimeSpan = DateTime.Now - time;

                                this.lapTimeString = String.Format("{0}:{1}.{2}", lapTimeSpan.Minutes, lapTimeSpan.Seconds, lapTimeSpan.Milliseconds);

                                if(this.gallons)
                                {
                                    this.fuelUsage *= gallonRatio;
                                    this.maxFuel *= gallonRatio;
                                }
                                
                                printLine(String.Format("Max fuel: {0}, Last lap fuel: {1}, lap time: {2}", this.maxFuel, this.fuelUsage, this.lapTimeString));
                                this.dataValid = true;
                                
                            }

                            this.lastLapFuel = t.FuelLevel;

                            time = DateTime.Now;
                        }
                        //Debug.WriteLine(t.ToString());
                    }
                }
            }
            finally
            {
                events.StopListening();
            }
        }

        /**
         * Print a line to the display's message box
         * @param message The message to print
         */
        private void printLine(string message)
        {
            telemDisplay.Invoke((MethodInvoker) delegate
                {
                    telemDisplay.AppendText(message);
                    telemDisplay.AppendText(Environment.NewLine);
                });
        }


        private void iracingConnected()
        {
            printLine("Telemetry connected");
        }

        private void iracingDisconnected()
        {
            this.dataValid = false;
            printLine("Telemetry disconnected");
        }
    }
}
