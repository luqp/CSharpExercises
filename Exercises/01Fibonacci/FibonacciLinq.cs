using System.Collections.Generic;
using System.Linq;

namespace Exercises._01Fibonacci
{
    public static class FibonacciLinq
    {
        public static IEnumerable<uint> GenerateSerie(uint size)
        {
                List<uint> fibonacci = new List<uint>();
                Enumerable.Range(0, (int)size)
                    .ToList()
                    .ForEach(index => fibonacci.Add((index <= 1 ? (uint)index : fibonacci[index - 2] + fibonacci[index - 1])));

                return fibonacci;
        }
    }
}
