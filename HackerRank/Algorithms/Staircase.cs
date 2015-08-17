using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public static class Staircase
    {
        public static void Run()
        {
            var t = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i < t + 1; i++)
            {
                var sb = new StringBuilder();
                for (var j = 0; j < t - i; j++) sb.Append(' ');
                for (var j = 0; j < i; j++) sb.Append('#');
                Console.WriteLine(sb);
            }
        }
    }
}
