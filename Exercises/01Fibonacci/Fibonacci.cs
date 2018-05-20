using System.Collections.Generic;
using System.Linq;

namespace Exercises._01Fibonacci
{
    public static class Fibonacci
    {
        public static IEnumerable<uint> GenerateSerie(uint size)
        {
            //Caso especial Size = 0 
            if (size == 0)
            {
                return Enumerable.Empty<uint>().ToList();
            }
            //Caso especial Size = 1
            if (size == 1)
            {
                return new List<uint> { 0 };
            }
            List<uint> fibonacciSerie = new List<uint> { 0, 1 };

            //Suma los 2 ultimos elementos de una lista y agrega el resultado al final 
            for (int i = 0; i < size - 2; i++)
            {
                fibonacciSerie.Add(fibonacciSerie[i] + fibonacciSerie[i + 1]);
            }
            return fibonacciSerie;
        }
    }
}
