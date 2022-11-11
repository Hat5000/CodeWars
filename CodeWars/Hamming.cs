using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Hamming
    {
        public static BigInteger hamming(int n)
        {
            var timer = new Stopwatch();
            timer.Start();
            var posibilities = new SortedSet<BigInteger>();
            BigInteger current;
            posibilities.Add(1);
            for(int i = 0; i < n -1; i++)
            {
                current = posibilities.First();
                posibilities.Add(current * 5);
                if(current % 5 != 0)
                {
                    posibilities.Add(current * 3);
                    if (current % 3 != 0)
                    {
                        posibilities.Add(current * 2);
                    }
                }              
                posibilities.Remove(current);
            }
            Console.WriteLine(timer.Elapsed);
            return posibilities.First();
        }
    }
}
