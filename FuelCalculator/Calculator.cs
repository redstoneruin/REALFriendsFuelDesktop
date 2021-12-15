using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace FuelCalculator
{
    public class Calculator
    {
        public int raceTime = 0, raceLaps = 0, paceLap = 0;
        public double lapTime = 0, maxFuel = 0, usage = 0, extraLaps = 0;
        public bool lapRace = false;

        public int numStops = 0, lapsPerTank = 0;
        public double totalFuel = 0, lastStopFuel = 0;


        /**
         * Parses and stores a lap time string to time in seconds
         * @param lapTimeStr Lap time in format MM:SS.ms
         * @return Whether the lap time was valid
         */
        public bool setLapTime(string lapTimeStr)
        {
            MatchCollection mc = Regex.Matches(lapTimeStr, @"((\d|\d\d):)?((\d|\d\d).(\d|\d\d|\d\d\d))");
            if(mc.Count == 0)
            {
                return false;
            }

            double mins, secs, tenths;

            string minsStr = mc[0].Groups[2].Value;
            string secsStr = mc[0].Groups[4].Value;
            string tenthsStr = mc[0].Groups[5].Value;

            // ensure all exist
            if (!double.TryParse(minsStr, out mins)) mins = 0;
            if (!double.TryParse(secsStr, out secs)) secs = 0;

            if (!double.TryParse(tenthsStr, out tenths)) tenths = 0;
            else tenths /= 10 * tenthsStr.Length;

            lapTime = mins*60 + secs + tenths;

            return true;
        }


        /**
         * If all values are available, calculate fuel requirements
         * @return Whether the inputs are valid and the calculation is complete
         */
        public bool doFuelCalc()
        {
            if (!inputsValid()) return false;

            if(lapRace)
            {
                raceTime = (int)Math.Ceiling((raceLaps * lapTime) / 60);
            } 
            else
            {
                raceLaps = (int)Math.Ceiling((raceTime * 60) / lapTime);
            }

            lapsPerTank = (int)Math.Floor(maxFuel / usage);
            totalFuel = usage * (raceLaps + extraLaps + 0.25 * paceLap);
            
            numStops = (int)Math.Ceiling((totalFuel-maxFuel) / maxFuel);
            lastStopFuel = numStops != 0 ? totalFuel - numStops * maxFuel : 0;

            return true;
        }

        private bool inputsValid()
        {
            return !((raceTime == 0 && !lapRace)
                || (raceLaps == 0 && lapRace)
                || lapTime == 0
                || usage == 0
                || maxFuel == 0);
        }
    }
}
