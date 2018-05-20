using Exercises._09BinaryDecimalConverter;
using Xunit;

namespace ExercisesTest._09BinaryDecimalConverterTest
{
    public class BinaryDecimalConverterTest
    {
        [Fact]
        void BinaryToDecimalTest()
        {
            uint decimalExpected = 0b110011;

            uint number = 110011;
            uint decimalGenered = number.ConvertBinaryToDecimal();

            Assert.Equal(decimalExpected, decimalGenered);
        }
        [Fact]
        void DecimalToBinaryTest()
        {
            uint binaryExpected = 0;
            uint binaryGenered = ((uint)0).ConvertDecimalToBinary();

            Assert.Equal(binaryExpected, binaryGenered);
        }

    }
}
