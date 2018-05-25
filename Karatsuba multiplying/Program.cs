using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatsuba_multiplying
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger value = new BigInteger(08469859540);

            int res = 0;
            BigInteger temp = new BigInteger(value);
            while (temp > 0)
            {
                res++;
                temp = new BigInteger(temp / 10);
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
