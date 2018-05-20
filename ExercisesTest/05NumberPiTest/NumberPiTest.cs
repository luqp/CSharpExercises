using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises._05NumberPi;

namespace ExercisesTest._05NumberPiTest
{
    public class NumberPiTest
    {
        [Fact]
        void PiSizeTest()
        {
            Assert.Equal(3.141592653589793, NumberPi.GeneratePi(15));
        }
        [Fact]
        void PiSizeExeptionTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NumberPi.GeneratePi(16));
        }
    }
}
