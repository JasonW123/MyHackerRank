using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HackerRank.Algorithms
{
    public static class ExtralongFactorials
    {
        public static void Run()
        {
            var t = Convert.ToInt32(Console.ReadLine());
            BigInteger big = 1;
            for (var i = 1; i < t + 1; i++)
            {
                big = big * i;
            }
            Console.WriteLine(big);
        }
    }
}
