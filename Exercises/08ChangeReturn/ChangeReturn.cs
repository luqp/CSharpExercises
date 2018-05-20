using System.Collections.Generic;

namespace Exercises._08ChangeReturn
{
    public static class ChangeReturn
    {
        public static List<uint> ReturnChangeMoney(decimal money, decimal price)
        {
            List<decimal> changeType = new List<decimal> { 0.25m, 0.10m, 0.05m, 0.01m };
            decimal change = money - price;

            if (change < 0)
            {
                throw new System.OverflowException();
            }

            if (change == 0)
            {
                return new List<uint> { 0 };
            }

            List<uint> changeReturn = new List<uint>();
            foreach (decimal cents in changeType)
            {
                changeReturn.Add((uint)(change / cents));
                change = change % cents;
                if (change == 0)
                {
                    break;
                }
            }
            return changeReturn;
        }
    }
}
