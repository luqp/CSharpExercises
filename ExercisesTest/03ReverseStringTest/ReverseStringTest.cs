using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises._03ReveseString;

namespace ExercisesTest._03ReverseStringTest
{
    public class ReverseStringTest
    {
        [Fact]
        public void ReserveCorrectTest()
        {
            string stringExpected = "odaclov atse otsE";
            string stringGenered = "Esto esta volcado".Reverse();
            Assert.Equal(stringExpected, stringGenered);
        }
        [Fact]
        public void ReverseEmptyTest()
        {
            Assert.Empty("".Reverse());
        }
    }
}
