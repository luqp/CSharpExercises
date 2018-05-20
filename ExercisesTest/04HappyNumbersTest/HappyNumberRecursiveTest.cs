using Exercises._04HappyNumber.Recursive;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExercisesTest._04HappyNumbersTest
{
    public class HappyNumberRecursiveTest
    {
        [Theory]
        [InlineData(7)]
        [InlineData(44)]
        [InlineData(79)]
        [InlineData(655)]
        void IsHappyNumberTest(uint number)
        {
            Assert.True(number.IsHappyNumber());    
        }

        [Theory]
        [InlineData(2)]
        [InlineData(43)]
        [InlineData(50)]
        [InlineData(657)]
        void IsNotHappyNumberTest(uint number)
        {
            Assert.False(number.IsHappyNumber());
        }

        [Theory]
        [InlineData(2)]
        [InlineData(43)]
        [InlineData(50)]
        [InlineData(657)]
        void IsNotNoTHappyNumberTest(uint number)
        {
            Assert.True(number.IsNotHappyNumber());
        }
    }
}
