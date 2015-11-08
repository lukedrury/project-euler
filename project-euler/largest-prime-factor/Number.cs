using System;

namespace largest_prime_factor
{
    public class Number
    {
        public int Value { get; }

        public Number(int value)
        {
            Value = value;
        }

        public bool IsPrime()
        {
            var asDecimal = (decimal) Value;
            if (asDecimal == 0 || asDecimal == 1) return false;

            var highestPossibleFactor = Math.Floor(asDecimal / 2);

            for (var currentPossibleFactor = 2; currentPossibleFactor <= highestPossibleFactor; currentPossibleFactor++)
            {
                var valueAfterDivision = asDecimal/currentPossibleFactor;

                var isWholeNumber = (valueAfterDivision - (int) valueAfterDivision) == 0;

                if (isWholeNumber) return false;
            }

            return true;
        }
    }
}