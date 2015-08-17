using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public static class PlusMinus
    {
        public static void Run()
        {
            var t = Convert.ToInt32(Console.ReadLine());
            var data = Console.ReadLine();
            var dataNums = data.Split(' ');

            double positiveCount = 0;
            double negativeCount = 0;
            double zeroCount = 0;

            for (var i = 0; i < t; i++)
            {
                var num = Convert.ToInt32(dataNums[i]);
                if (num < 0) negativeCount++;
                else if (num == 0) zeroCount++;
                else if (num > 0) positiveCount++;
            }

            Console.WriteLine(positiveCount / t);
            Console.WriteLine(negativeCount / t);
            Console.WriteLine(zeroCount / t);
        }
    }
}
