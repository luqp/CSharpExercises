using System;
using System.Globalization;

namespace Exercises._09BinaryDecimalConverter
{
    public static class BinaryDecimalConverter
    {
        public static uint ConvertBinaryToDecimal(this uint binaryToConvert)
        {
            uint numBinary = binaryToConvert;
            uint digit = 0;
            uint sumDigit = 0;

            for (uint i = 0; numBinary != 0; i++)
            {
                digit = numBinary % 10;
                numBinary = numBinary / 10;
                if (digit != 0)
                {
                    sumDigit += (uint)Math.Pow(2, i);
                }
            }
            return sumDigit;
        }
        public static uint ConvertDecimalToBinary(this uint decimalToConvert)
        {
            uint axuiliarSum = 0;
            string binaryNumber = "";
            for (uint i = decimalToConvert / 2; i != uint.MaxValue; i--)
            {
                uint auxiliar = (uint)Math.Pow(2, i);
                if (auxiliar + axuiliarSum <= decimalToConvert)
                {
                    binaryNumber += "1";
                    axuiliarSum += auxiliar;
                }
                else
                {
                    binaryNumber += "0";
                }
            }
            return uint.Parse(binaryNumber, CultureInfo.InvariantCulture);
        }
    }
}
