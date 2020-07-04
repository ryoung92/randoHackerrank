using System;
using System.Collections.Generic;
using System.Text;

namespace TestStuff
{
    public static class MiniMaxSum
    {

        public static List<int> calculateMiniMax(List<int> input)
        {
            var answer = new List<int>();
 
            int minElement = 0, maxElement = 0, sum = 0;

 
            minElement = input[0];
            maxElement = minElement;
            sum = minElement;

  
            for (int i = 1; i < input.Count; i++)
            {
                sum += input[i];

                if (input[i] < minElement)
                {
                    minElement = input[i];
                }

                if (input[i] > maxElement)
                {
                    maxElement = input[i];
                }
            }

            answer.Add(sum - maxElement);
            answer.Add(sum - minElement);

            return answer;
        }


    }


}
