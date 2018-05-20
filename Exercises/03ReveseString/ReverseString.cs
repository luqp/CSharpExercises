using System.Linq;

namespace Exercises._03ReveseString
{
    public static class ReverseString
    {
        public static string Reverse(this string stringToReverse)
        {
            return new string(Enumerable.Reverse(stringToReverse).ToArray());
        }
    }
}
