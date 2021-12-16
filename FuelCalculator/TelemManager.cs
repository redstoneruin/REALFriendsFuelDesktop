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

        private void telemLoop()
        {
            // var iRacing = new iRacingConnection();
            
            while (true)
            {
                // TODO: telemetry processing

                // printLine("test");
                
                Thread.Sleep(1000);
            }    
        }

        private void printLine(string message)
        {
            telemDisplay.Invoke((MethodInvoker) delegate
                {
                    telemDisplay.AppendText("test");
                    telemDisplay.AppendText(Environment.NewLine);
                });
        }
    }
}
