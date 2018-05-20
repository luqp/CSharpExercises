using System;
using System.Collections.Generic;

namespace Exercises._04HappyNumber.Standard
{
    public static class HappyNumber
    {
        public static bool IsNotHappyNumber(this uint number)
        {
            return !IsHappyNumber(number);
        }
        public static bool IsHappyNumber(this uint number)
        {
            List<uint> sums = new List<uint>();
            uint sum = SumDigitsPowTwo(number);

            do
            {
                if (sum == 1)
                {
                    return true;
                }

                sums.Add(sum);
                sum = SumDigitsPowTwo(sum);

            } while (!sums.Contains(sum));

            return false;
        }

        internal static uint SumDigitsPowTwo(uint number)
        {
            uint resultSum = 0;
            uint digitNumber = number;
            while (digitNumber != 0)
            {
                resultSum += (uint)Math.Pow(digitNumber % 10, 2);
                digitNumber = digitNumber / 10;
            }
            return resultSum;
        }
    }
}
