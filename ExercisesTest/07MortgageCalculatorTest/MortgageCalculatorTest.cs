using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using Exercises._07MortgageCalculator;
using System.Globalization;

namespace ExercisesTest._07MortgageCalculatorTest
{
    public class MortgageCalculatorTest
    {
        private readonly ITestOutputHelper output;
        public MortgageCalculatorTest(ITestOutputHelper output)
        {
            this.output = output;      
        }

        [Fact]
        
        void CalculateMortgageTest()
        {
            double paymentExpected = 506.69;
            double paymentGenered = MortgageCalculator.CalculatesMortgageTime(100000, 0.045, 30, 1);
            Assert.Equal(paymentExpected, Math.Round(paymentGenered,2));
        }

        [Fact]
        void ReturnDummy()
        {
            double pay = MortgageCalculator.CalculatesMortgageTime(10000, 0.045, 5, 3);
            output.WriteLine(pay.ToString(CultureInfo.InvariantCulture));
            Assert.True(true);
        }

    }
}
