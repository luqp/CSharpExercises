using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises._06PrimeFactorization;
using Xunit.Abstractions;

namespace ExercisesTest._06PrimeFactorizationTest
{
    public class PrimeFactorizateTest
    {
        private readonly ITestOutputHelper output; //For Write on output

        public PrimeFactorizateTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        // Simple Test
        [Fact]
        void CorrectPrimeSerieTest()
        {
            List<uint> expectedPrimeSerie = new List<uint> { 2, 2, 2, 3 };
            List<uint> generatedPrimeSerie = PrimeFactorization.ObtainNumersPrime(24);
            Assert.Equal(expectedPrimeSerie, generatedPrimeSerie);
        }

        // Complex Test
        [Fact]
        void CorrectPrimeBigSerieTest()
        {
            List<uint> expectedPrimeSerie = new List<uint> { 2, 2, 2, 2, 3, 5, 5, 7 };
            List<uint> generatedPrimeSerie = PrimeFactorization.ObtainNumersPrime(8400);
            Assert.Equal(expectedPrimeSerie, generatedPrimeSerie);
        }

        // Complex Test
        [Fact]
        void CorrectPrimeFactorizationWithElvenTest()
        {
            List<uint> expectedPrimeSerie = new List<uint> { 2, 3, 5, 11};
            List<uint> generatedPrimeSerie = PrimeFactorization.ObtainNumersPrime(330);
            Assert.Equal(expectedPrimeSerie, generatedPrimeSerie);
        }

        [Fact]
        void CorrectPrimeDummy()
        {
            List<uint> generatedPrimeSerie = PrimeFactorization.ObtainNumersPrime(12345);
            output.WriteLine(String.Join(", ", generatedPrimeSerie.ToArray()));
            Assert.True(true);
        }
    }
}
