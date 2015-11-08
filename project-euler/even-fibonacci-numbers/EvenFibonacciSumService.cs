using System.Collections.Generic;
using System.Linq;

namespace even_fibonacci_numbers
{
    public class EvenFibonacciSumService
    {
        public int CalculateSum(int upperLimit)
        {
            var evenFibonacciNumbers = new List<FibonacciNumber>();

            var current = new FibonacciNumber(1, 1);

            while (current.Value < upperLimit)
            {
                if (current.Value % 2 == 0)
                {
                    evenFibonacciNumbers.Add(current);
                }

                current = current.Next();
            }

            return evenFibonacciNumbers.Sum(x => x.Value);
        }
    }
}
