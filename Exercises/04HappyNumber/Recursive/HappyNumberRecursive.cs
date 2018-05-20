using Exercises._04HappyNumber.Standard;
using System.Collections.Generic;

namespace Exercises._04HappyNumber.Recursive
{
    public static class HappyNumberRecursive
    {
        public static bool IsNotHappyNumber(this uint number)
        {
            return !IsHappyNumber(number);
        }

        public static bool IsHappyNumber(this uint number)
        {
            uint sum = HappyNumber.SumDigitsPowTwo(number);
            return IsHappyNumber(sum, new List<uint> { sum });
        }

        private static bool IsHappyNumber(uint number, List<uint> sums)
        {
            uint sum = HappyNumber.SumDigitsPowTwo(number);

            if (sum == 1)
            {
                return true;
            }

            if (sums.Contains(sum))
            {
                return false;
            }

            sums.Add(sum);

            return IsHappyNumber(sum, sums);
        }
    }
}
