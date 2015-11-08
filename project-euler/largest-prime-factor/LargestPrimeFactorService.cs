using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_prime_factor
{
    public class LargestPrimeFactorService
    {
        public int CalculateLargestPrimeFactor(int target)
        {
            if (target < 2) throw new InvalidOperationException($"Prime factors cannot be calculated for number less than 2. {target} was provided.");

            var primeFactors = new List<Number>();
            primeFactors.AddRange(SplitIntoPrimeFactors(new Number(target)));

            var largestPrimeFactor = primeFactors.Aggregate((x,y) => x.Value > y.Value ? x : y);
            return largestPrimeFactor.Value;
        }

        private static IEnumerable<Number> SplitIntoPrimeFactors(Number target)
        {
            if (target.Value < 2)
            {
                throw new InvalidOperationException("Cannot split a value of less than 2 into its factors");
            }

            var primeFactors = new List<Number>();
            if (target.IsPrime())
            {
                primeFactors.Add(target);
                return primeFactors;
            }

            decimal factor = 2;
            while (true)
            {
                decimal divison = target.Value / factor;
                if (divison == (int) divison)
                {
                    var leftPossibleFactor = new Number((int) factor);
                    if (leftPossibleFactor.IsPrime())
                    {
                        primeFactors.Add(leftPossibleFactor);
                    }
                    else
                    {
                        var leftPrimeFactors = SplitIntoPrimeFactors(leftPossibleFactor);
                        primeFactors.AddRange(leftPrimeFactors);
                    }

                    var rightPossibleFactor = new Number((int) divison);
                    if (rightPossibleFactor.IsPrime())
                    {
                        primeFactors.Add(rightPossibleFactor);
                    }
                    else
                    {
                        var rightPrimeFactors = SplitIntoPrimeFactors(rightPossibleFactor);
                        primeFactors.AddRange(rightPrimeFactors);
                    }

                    return primeFactors;
                }

                factor++;
            }
        }
    }
}
