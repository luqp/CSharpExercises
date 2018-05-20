using System;

namespace Exercises._07MortgageCalculator
{
    public static class MortgageCalculator
    {
        public static double CalculatesMortgageTime(double mortgage, double rate, int cantPay, byte interval)
        {
            double totalMortgage = mortgage;
            double interestrate = rate;
            int cantPayments = cantPay;
            byte intervalpayment = interval;
            
            switch (interval)
            {
                case 1:
                    cantPayments = cantPayments * 12;
                    break;
                case 2:
                    cantPayments = cantPayments * 48;
                    break;
                case 3:
                    cantPayments = cantPayments * 336;
                    break; 
            }

            interestrate = interestrate / 12;
            double auxiliary = Math.Pow(1 + interestrate, cantPayments);
            double payment = totalMortgage * (interestrate * auxiliary) / (auxiliary - 1);
            return payment;
        }
    }
}
