using System.Linq;
using System.Collections.Generic;

namespace Exercises._02FizzBuzz
{
    public static class FizzBuzzLinq
    {
        public static IEnumerable<string> GenerateSerie(uint size)
        {
            return Enumerable.Range(1, (int)size).Select(number => FizzBuzz.CalculateFizzBuzz((uint)number));
        }
    }
}
