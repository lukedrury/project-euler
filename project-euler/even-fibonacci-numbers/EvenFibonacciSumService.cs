using System.Collections.Generic;
using System.Linq;

namespace even_fibonacci_numbers
{
    public class EvenFibonacciSumService
    {
        public int CalculateSum(int upperLimit)
        {
            var sum = 0;

            var current = new FibonacciNumber(1, 1);

            while (current.Value < upperLimit)
            {
                if (current.Value % 2 == 0)
                {
                    sum += current.Value;
                }

                current = current.Next();
            }

            return sum;
        }
    }
}
