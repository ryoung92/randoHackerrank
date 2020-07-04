using System;
using System.Collections.Generic;
using System.Text;

namespace TestStuff
{
    public static class PrimeFactors
    {
        public static List<int> primeFactorsCalculate(int n)
        {
            var answer = new List<int>();
            
            while (n % 2 == 0)
            {
                answer.Add(2);
                n /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                
                while (n % i == 0)
                {
                    answer.Add(i);
                    n /= i;
                }
            }

            if (n > 2)
                answer.Add(n);

            return answer;
        }
    }
}
