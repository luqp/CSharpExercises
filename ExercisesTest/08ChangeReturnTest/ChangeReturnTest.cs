using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises._08ChangeReturn;
using Xunit.Abstractions;

namespace ExercisesTest._08ChangeReturnTest
{
    public class ChangeReturnTest
    {
        private readonly ITestOutputHelper juan;
        public ChangeReturnTest(ITestOutputHelper output)
        {
            this.juan = output;
        }
        [Fact]
        void ChangeResultTest()
        {
            List<uint> change = ChangeReturn.ReturnChangeMoney(10m, 9.23m);
            juan.WriteLine(String.Join(" , ", change.ToArray()));
            Assert.True(true);
        }
        [Fact]
        void ChangeNegativeTest()
        {
            Assert.Throws<System.OverflowException>(() => ChangeReturn.ReturnChangeMoney(-20m, 19m));
        }

    }
}
