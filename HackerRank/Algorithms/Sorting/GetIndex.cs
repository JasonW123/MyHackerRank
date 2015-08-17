using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Sorting
{
    public static class GetIndex
    {
        public static void Run()
        {
            var t = Convert.ToInt32(Console.ReadLine());
            var count = Convert.ToInt32(Console.ReadLine());
            var data = Console.ReadLine();
            var dataNums = data.Split(' ').Select(s => Convert.ToInt32(s)).ToList();

            for (var i = 0; i < count; i++)
            {
                var num = dataNums[i];
                if (num == t)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
