using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockRadio myClockRadio = new ClockRadio();//use this and refer to myClockRadio to avoid using static
            GetInput.ConsiderRadioOnOff();
        }
    }
}
