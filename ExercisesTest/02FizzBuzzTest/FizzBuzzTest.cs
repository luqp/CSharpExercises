using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises._02FizzBuzz;

namespace ExercisesTest._02FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void FizzBuzzUntilFiftheenTest()
        {
            IEnumerable<string> serieExpected = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7" , "8" , "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            IEnumerable<string> serieGenered = FizzBuzz.GenerateSerie(15);
            Assert.Equal(serieExpected, serieGenered);
        }
        [Fact]
        public void FizzBuzzEmptyTest()
        {
            Assert.Empty(FizzBuzz.GenerateSerie(0));
        }
    }
}
