using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class ClockRadio
    {
        public static bool isOn = false;
        public static double station = 90.00;
        internal static string time = "10:";
        public static int minutes = 0;

        public static double ChangeStation()
        {
            minutes += 1;
            return station += 0.75;
        }
        public static bool TurnRadioOn()
        {
            return isOn = true;
        }
    }
}
