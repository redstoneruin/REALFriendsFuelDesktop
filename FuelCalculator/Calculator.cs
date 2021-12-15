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

        public int numStops = 0;
        public double lapsPerTank = 0, totalFuel = 0, lastStopFuel = 0;


        public bool setLapTime(string lapTimeStr)
        {
            MatchCollection mc = Regex.Matches(lapTimeStr, @"((\d|\d\d):)?((\d|\d\d).(\d|\d\d|\d\d\d))");
            if(mc.Count == 0)
            {
                return false;
            }

            string mins = mc[0].Groups[2].Value;
            string secs = mc[0].Groups[4].Value;
            string ms = mc[0].Groups[5].Value;
            
            return true;
        }

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

            lapsPerTank = maxFuel / usage;
            totalFuel = usage * (raceLaps + extraLaps + 0.25 * paceLap);
            numStops = (int)Math.Ceiling((totalFuel - maxFuel) / maxFuel);
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
