using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace HackerRank.Algorithms.DynamicProgramming
{
    public static class FibonacciModified
    {
        public static void Run()
        {
            var temp = Console.ReadLine();
            if (temp == null) return;
            var tempData = temp.Split(' ').Select(s => Convert.ToInt32(s)).ToList();
            BigInteger first = tempData[0];
            BigInteger second = tempData[1];
            var count = tempData[2];
            for (var i = 2; i < count; i++)
            {
                var tempSec = second;
                second = second*second + first;
                first = tempSec;
            }

            var ans = new List<BigInteger>();
            var p10 = BigInteger.Pow(10, 100);
            while (second != 0)
            {
                ans.Add(second % p10);
                second /= p10;
            }
            Console.Write(ans[ans.Count - 1]);
            var fmt = new string('0', 100);
            for (var i = ans.Count - 2; i >= 0; i--)
            {
                var str = ans[i].ToString();
                Console.Write("{0}{1}", fmt.Substring(0, 100 - str.Length), str);
            }
            Console.WriteLine();
        }
    }
}