using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public class PrimeNumberGenerator
    {
        public static int GetPrimeNumber(int n)
        {
            List<int> list = new List<int>();
            list.Add(2);
            int nextPrime = 3;
            while(list.Count < n )
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for(int i=0; list[i]<=sqrt;i++)
                {
                    if(nextPrime % list[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    list.Add(nextPrime);

                }
                nextPrime+= 2;
            }
            return list[n - 1];
            
        }
    }
}
