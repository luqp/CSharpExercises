using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._06PrimeFactorization
{
    public static class PrimeFactorization
    {
        public static List<uint> ObtainNumersPrime(uint numberToFactorizate)
        {
            uint prime = 2;
            uint number = numberToFactorizate;
            List<uint> numbersPrime = new List<uint>();
            while (number != 1)
            {
                if (number % prime == 0)
                {
                    numbersPrime.Add(prime);
                    number = number / prime;
                }
                else
                {
                    prime++;
                }
            }
            return numbersPrime;
        }
    }
}
