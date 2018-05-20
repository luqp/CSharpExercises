using System;

namespace Exercises._05NumberPi
{
    public static class NumberPi
    {
        public static double GeneratePi(int decimalsSize)
        {
            if (decimalsSize < 0 && decimalsSize > 15)
            {
                throw new ArgumentOutOfRangeException(nameof(decimalsSize), $"The {nameof(decimalsSize)} must be in range 1 to 15");
            }
            double pi = Math.Round(Math.PI, decimalsSize);
            return pi;
        }
    }
}
