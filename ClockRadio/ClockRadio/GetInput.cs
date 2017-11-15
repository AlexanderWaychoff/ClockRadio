using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class GetInput
    {
        public static string yesNo;
        public static void ConsiderRadioOnOff()
        {
            if (!(ClockRadio.isOn))
            {
                Console.WriteLine("Would you like to turn the radio on? Put your input as lower case.");
                yesNo = Console.ReadLine();
                if (yesNo == "yes")
                {
                    ClockRadio.TurnRadioOn();
                }
                else
                {
                    Console.WriteLine("Very good then.");
                    Console.ReadKey();
                }
            }
            if (ClockRadio.isOn)
            {
                Console.WriteLine("The current station is " + ClockRadio.station + " and the time is " + ClockRadio.time + ClockRadio.minutes);
                Console.WriteLine("Would you like to change the station or check your alarm?  Type 'yes', 'no', or 'alarm'.  Put your input as lower case.");
                yesNo = Console.ReadLine();
                if (yesNo == "yes")
                {
                    ClockRadio.ChangeStation();
                    ConsiderRadioOnOff();

                }
                else if (yesNo == "alarm")
                {
                    if (!(ClockRadio.isAlarmOn))
                    {
                        Console.WriteLine("Would you like to turn your alarm on?");
                        yesNo = Console.ReadLine();
                        if (yesNo == "yes")
                        {
                            ClockRadio.TurnAlarmOn();
                        }
                    }
                    if(ClockRadio.isAlarmOn)
                    {
                        Console.WriteLine("Your alarm is set for " + ClockRadio.alarmTime + " o'clock.  Would you like to adjust it?");
                        yesNo = Console.ReadLine();
                        if (yesNo == "yes")
                        {
                            ClockRadio.AdjustAlarm();
                        }
                    }
                    ConsiderRadioOnOff();
                }
                else
                {
                    Console.WriteLine("Very good then.");
                    Console.ReadKey();
                }
            }
        }
    }
}
