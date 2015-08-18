using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public static class LibraryFine
    {
        public static void Run()
        {
            var pay = Console.ReadLine().ToString().Split(' ');
            var payYear = Convert.ToInt32(pay[2]);
            var payMonth = Convert.ToInt32(pay[1]);
            var payDay = Convert.ToInt32(pay[0]);
            var require = Console.ReadLine().ToString().Split(' ');
            var requireYear = Convert.ToInt32(require[2]);
            var requireMonth = Convert.ToInt32(require[1]);
            var requireDay = Convert.ToInt32(require[0]);

            if (payYear < requireYear)
            {
                Console.WriteLine("0");
                return;
            }

            if (payYear > requireYear)
            {
                Console.WriteLine("10000");
                return;
            }

            if (payMonth < requireMonth)
            {
                Console.WriteLine("0");
                return;
            }

            if (payMonth > requireMonth)
            {
                Console.WriteLine((payMonth - requireMonth) * 500);
                return;
            }

            if (payDay <= requireDay)
            {
                Console.WriteLine("0");
                return;
            }

            if (payDay > requireDay)
            {
                Console.WriteLine((payDay - requireDay) * 15);
            }
        }
    }
}
