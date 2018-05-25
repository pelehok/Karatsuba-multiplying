using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatsuba_multiplying
{
    class BigValue
    {
        const int DIVIDER = 10;

        public BigInteger Value { get; set; }
        public int Lenght { get; set; }

        public BigValue(BigInteger value)
        {
            Value = value;
            Lenght = GetLenght(value);
        }
        
        public int GetLenght(BigInteger value)
        {
            int res = 0;
            BigInteger temp = new BigInteger(value);
            while (temp > 0)
            {
                res++;
                temp = new BigInteger(temp / DIVIDER);
            }

            return res;
        }

        public List<BigValue> DoubleSplit()
        {
            int divider = 1;
            for(int i = 0; i < Lenght / 2; i++)
            {
                divider *= DIVIDER;
            }

            return new List<BigValue>()
            {
                new BigValue(new BigInteger(Value/divider)),
                new BigValue(new BigInteger(Value%divider))
            };
        }
    }
}
