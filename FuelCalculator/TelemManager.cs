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
            iRacingConnection iracing = new iRacingConnection();
            iRacingEvents events = new iRacingEvents();
            events.StartListening();

            try
            {
                int i = 0;

                foreach (DataSample d in iRacing.GetDataFeed())
                {
                    if (i % 600 == 0)
                    {
                        //printLine(string.Format("Data Stream IsConnected = {0}", d.IsConnected));
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
    }
}
