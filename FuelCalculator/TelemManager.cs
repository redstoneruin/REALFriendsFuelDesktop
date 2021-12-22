using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using iRacingSDK;

namespace FuelCalculator
{

    public class TelemManager
    {
        private Thread telemTrd;
        private TextBox telemDisplay;

        private iRacingConnection iracing;
        private iRacingEvents events;

        double lastLapFuel = 0;
        int currentLap = 0;

        double fuelUsage = 0, lapTime = 0;

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
                            this.currentLap = t.Lap;

                            // calculate fuel used this lap
                            if(this.lastLapFuel != 0)
                            {
                                this.fuelUsage = this.lastLapFuel - t.FuelLevel;
                                printLine(String.Format("Last lap fuel: {0}", this.fuelUsage));
                            }

                            this.lastLapFuel = t.FuelLevel;
                        }
                        //Debug.WriteLine(d.Telemetry.ToString());
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
            printLine("Telemetry disconnected");
        }
    }
}
