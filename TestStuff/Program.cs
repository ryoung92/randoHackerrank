using System;
using System.Collections.Generic;

namespace TestStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(NumbersToWords.toWords(1000000));

            var list = new List<int> {
                5,
                1,
                2,
                3,
                4,
                5
            };

            Console.WriteLine(String.Join("\r\n", MiniMaxSum.calculateMiniMax(list)));

        }

        public static List<int> NumberToEnglish(List<int> pintInput)
        {
            return MiniMaxSum.calculateMiniMax(pintInput);
        }


    }
}
