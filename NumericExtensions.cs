using System;

namespace ExtensionMethods
{
    public static class NumericExtensions
    {
        //Usage: myNumber.Between(3,7)
        public static bool Between<T>(this T actual, T lower, T upper) where T : IComparable<T>
        {
            return actual.CompareTo(lower) >= 0 && actual.CompareTo(upper) < 0;
        }

    }
}