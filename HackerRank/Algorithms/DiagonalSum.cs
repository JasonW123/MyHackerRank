using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public static class DiagonalSum
    {
        public static void Sum()
        {
            var t = Convert.ToInt32(Console.ReadLine());

            var array = new int[t, t];

            for (var i = 0; i < t; i++)
            {
                var data = Console.ReadLine();
                if (string.IsNullOrEmpty(data)) break;
                var dataNums = data.Split(' ');
                for (var j = 0; j < dataNums.Count(); j++)
                {
                    array[i, j] = Convert.ToInt32(dataNums[j]);
                }
            }


            var diaSumA = 0;
            var diaSumB = 0;
            for (var i = 0; i < t; i++)
            {
                diaSumA += array[i, i];
                diaSumB += array[t - i - 1, i];
            }

            Console.Write(Math.Abs(diaSumA - diaSumB));
        }
    }
}
