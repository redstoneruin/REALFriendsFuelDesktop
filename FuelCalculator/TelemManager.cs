using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using iRacingSDK;

namespace FuelCalculator
{

    public class TelemManager
    {
        private Thread telemTrd;

        public TelemManager()
        {
            telemTrd = new Thread(new ThreadStart(this.telemLoop));

            telemTrd.IsBackground = true;
            telemTrd.Start();
        }

        private void telemLoop()
        {
            // var iRacing = new iRacingConnection();
            
            while (true)
            {
                // TODO: telemetry processing

                Thread.Sleep(1000);
            }    
        }
    }
}
