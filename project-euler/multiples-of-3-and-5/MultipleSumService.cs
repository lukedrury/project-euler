using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiples_of_3_and_5
{
    public class MultipleSumService
    {
        public int CalculateSum()
        {
            var uniqueMultiples = new HashSet<int>();

            for (int i = 0; i < 1000; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    uniqueMultiples.Add(i);
                }
            }

            var sum = uniqueMultiples.Sum();
            return sum;
        }
    }
}
