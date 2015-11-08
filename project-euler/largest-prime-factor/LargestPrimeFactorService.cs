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

            return -1;
        }
    }
}
