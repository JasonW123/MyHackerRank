using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public static class TimeConversion
    {
        public static void Run()
        {
            var time = Console.ReadLine();
            var timeValues = time.Split(':');
            var hour = Convert.ToInt32(timeValues.First());
            var min = timeValues[1];
            var secord = timeValues.Last();
            if (secord.Contains("AM"))
            {
                if (hour == 12) Console.WriteLine("00:" + min + ":" + secord.Replace("AM", ""));
                else Console.WriteLine(time.Replace("AM", ""));
            }
            else if (secord.Contains("PM"))
            {
                if (hour == 12) Console.WriteLine("12:" + min + ":" + secord.Replace("PM", ""));
                else Console.WriteLine(hour + 12 + ":" + min + ":" + secord.Replace("PM", ""));
            }
        }
    }
}
