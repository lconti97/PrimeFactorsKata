using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactorsKata
{
    public class PrimeFactor
    {
        public List<Int32> Generate(Int32 num)
        {
            if (num == 1)
                return null;

            var factors = new List<Int32>();

            for (var i = 2; i < num; i++)
            { 
                if (num % i == 0)
                {
                    factors.Add(i);
                    factors.Add(i);
                }
            }

            if (!factors.Any())
                factors.Add(num);

            return factors;
        }
                
        
    }
}
