using System;

namespace PrimeFactorsKata
{
    public class PrimeFactor
    {
        public Int32[] Generate(Int32 num)
        {
            if (num == 1)
                return null;
            else
                return new[] { num };
        } 
    }
}
