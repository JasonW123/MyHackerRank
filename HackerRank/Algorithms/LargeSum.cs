using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public static class LargeSum
    {
        public static void LargeSum()
        {
            var t = Convert.ToInt32(Console.ReadLine());
            var data = Console.ReadLine();
            var dataNum = data.Split(' ');

            var array = new List<long>();
            for (var i = 0; i < t; i++)
            {
                var num = Convert.ToInt64(dataNum[i]);
                array.Add(num);
            }
            Console.WriteLine(array.Sum());
        }
    }
}
