using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises._01Fibonacci;

namespace ExercisesTest._01Fibonacci
{
    public class FibonacciLinqTest
    {
        [Fact] // Test negativo simple
        public void FibonacciSizeZeroTest()
        {
            // Assert
            Assert.Empty(FibonacciLinq.GenerateSerie(0));
        }
        [Fact] // Positivo simple
        public void FibonaccioSizeSeven()
        {
            // Arrange
            IEnumerable<uint> serieExpected = new List<uint> { 0, 1, 1, 2, 3, 5, 8 };
            // Act
            IEnumerable<uint> serieGenerated = FibonacciLinq.GenerateSerie(7);
            // Assert
            Assert.Equal(serieExpected, serieGenerated);
        }
    }
}
