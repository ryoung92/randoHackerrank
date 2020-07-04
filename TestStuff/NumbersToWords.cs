using System;
using System.Collections.Generic;
using System.Text;

namespace TestStuff
{
    public class NumbersToWords
    {

        static String[] tensNames = {

			    "twenty",
			    "thirty",
			    "forty",
			    "fifty",
			    "sixty",
			    "seventy",
			    "eighty",
			    "ninety"
			  };

	
	  static String[] onesNames = {
			  
			 	"zero",
			    "one",
			    "two",
			    "three",
			    "four",
			    "five",
			    "six",
			    "seven",
			    "eight",
			    "nine",
			    "ten",
			    "eleven",
			    "twelve",
			    "thirteen",
			    "fourteen",
			    "fifteen",
			    "sixteen",
			    "seventeen",
			    "eighteen",
			    "nineteen"
			  };
	
	static String[] largeDigits = {
			
				"thousand",
				"million",
				"billion",
				"trillion"
			  };

	public static String toWords(int number)
        {
            String word1 = null;
            int largeDigitsCounter = 0;

            if (number <= 999)
            {
                return convertUpTo999(number);
            }

            //increments through each digit right to left untill it reaches the 0-999range
            while (number > 0)
            {
                if (number % 1000 != 0)
                {
                    String word2 = convertUpTo999(number % 1000);
                    if (largeDigitsCounter > 0)
                    {
                        word2 = word2 + " " + largeDigits[largeDigitsCounter - 1] + ",";
                    }
                    if (word1 == null)
                    {
                        word1 = word2;
                    }
                    else
                    {
                        word1 = word2 + " " + word1;
                    }
                }
                number /= 1000;
                largeDigitsCounter++;
            }
            if (word1.EndsWith(","))
            {
                word1 = word1.Remove(word1.Length - 1);
            }
            return word1;

        }

        static String convertUpTo999(int number)
        {
            String word1 = onesNames[number / 100] + "hundred";
            String word2 = convertUpTo99(number % 100);


            //concatenate words together or not
            if (number <= 99)
            {
                return word2;
            }
            else if (number % 100 == 0)
            {
                return word1;
            }
            else
            {
                return word1 + " and " + word2;
            }

        }

        static String convertUpTo99(int number)
        {

            if (number < 20)
            { //check for a word in the ones list
                return onesNames[number];
            }

            String word = tensNames[number / 10 - 2]; //check for a word in the tens list

            //concatenate words together or not
            if (number % 10 == 0)
            {
                return word;
            }

            return word + " " + onesNames[number % 10];

        }

    }
}
