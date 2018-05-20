using System.Collections.Generic;
using System.Globalization;

namespace Exercises._02FizzBuzz
{
    public static class FizzBuzz
    {
        private const string fizz = "Fizz";
        private const string buzz = "Buzz";

        internal static string CalculateFizzBuzz(uint number)
        {
            if (number % 15 == 0)
            {
                return fizz + buzz;
            }
            if (number % 5 == 0)
            {
                return buzz;
            }
            if (number % 3 == 0)
            {
                return fizz;
            }
            return number.ToString(CultureInfo.InvariantCulture);
        }

        public static IEnumerable<string> GenerateSerie(uint size)
        {
            List<string> fizzBuzzSerie = new List<string>();

            for (uint i = 1; i <= size; i++)
            {
                fizzBuzzSerie.Add(CalculateFizzBuzz(i));
            }

            return fizzBuzzSerie;
        }
    }
}
