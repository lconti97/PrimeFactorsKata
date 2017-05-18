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

            for (var i = num / 2; i >= Math.Sqrt(num); i--)
                if (num % i == 0)
                    factors.AddRange(GetFactorPair(num, i));

            if (!factors.Any())
                factors.Add(num);

            return factors;
        }

        private Int32[] GetFactorPair(Int32 num, Int32 factor)
        {
            return new[] { num / factor, factor };
        }

    }
}
