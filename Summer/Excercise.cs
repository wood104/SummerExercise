using System;
using System.Collections.Generic;
using System.Linq;

namespace Summer
{
    public class Exercise
    {
        public void Run()
        {
            /*Easy method to minimally write answer to console***********************************/

            var simpleList = new List<int>();

            for (var i = 1; i < 1000; i++)
            {
                simpleList.Add(i);
            }
            
            var summed = simpleList.Where(x => x % 3 == 0 || x % 5 == 0).Sum();

            Console.WriteLine("Minimum effort answer: " + summed);

            /************************************************************************************/

            var dividends = InitializeList(1000).ToList();

            var divisors = new List<int> { 3, 5 };

            var selectedNumbers = FindQuotients(dividends, divisors).ToList();

            var sum = SumListedIntegers(selectedNumbers);

            Console.WriteLine("Answer with methods for variables: " + sum);
            Console.Read();
        }

        /// <summary>
        /// Initializes list of all natural numbers less than limit.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public IEnumerable<int> InitializeList(int limit)
        {
            IList<int> numberList = new List<int>();

            if (limit < 1)
            {
                return numberList;
            }

            for (var i = 1; i < limit; i++)
            {
                numberList.Add(i);
            }

            return numberList;
        }

        /// <summary>
        /// Finds numbers in dividends list that are evenly divisible by numbers in the divisors list.
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public IEnumerable<int> FindQuotients(IReadOnlyCollection<int> dividend, IReadOnlyCollection<int> divisor)
        {
            var returnList = new List<int>();

            if (dividend == null || !dividend.Any())
            {
                return returnList;
            }

            if (divisor == null || !divisor.Any())
            {
                return returnList;
            }

            foreach (var numToDivide in dividend)
            {
                foreach (var numDivideBy in divisor.Where(x => x > 0))
                {
                    if (numToDivide % numDivideBy == 0 && !returnList.Contains(numToDivide))
                    {
                        returnList.Add(numToDivide);
                    }
                }
            }

            return returnList;
        }

        /// <summary>
        /// Returns sum of integers in given list.
        /// </summary>
        /// <param name="listedInts"></param>
        /// <returns></returns>
        public int SumListedIntegers(IReadOnlyCollection<int> listedInts)
        {
            if (listedInts == null || !listedInts.Any())
            {
                return 0;
            }

            return listedInts.Sum();
        }
    }
}
