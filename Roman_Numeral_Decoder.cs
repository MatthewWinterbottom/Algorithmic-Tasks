using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer.
             * You don't need to validate the form of the Roman numeral. Modern Roman numerals are written by expressing each
             * decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s.
             * So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII).
             * The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.

            Example:
            RomanDecode.Solution("XXI") -- should return 21
            */

            var res = Solution("XXI");
            var res2 = Solution("I");
            var res3 = Solution("IV");
            var res4 = Solution("MCMLIV");
        }


        public static int Solution(string roman)
        {
            // Create list from string so can index Chars
            var romanList = roman.ToList();

            // Track the total value the roman numerals store
            int total = 0;

            // Dictionary used to get values
            var decodeDict = new Dictionary<char, int>()
            {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };

            // Foreach char, get the value and add it to the total
            for (int i = 0; i < roman.Length; i++)
            {
                // If the roman numeral value at the next pos is greater than current pos, minus, e.g. IV = 4
                if (i < roman.Length - 1 && decodeDict[romanList[i]] < decodeDict[romanList[i + 1]])
                {
                    total += decodeDict[romanList[i + 1]] - decodeDict[romanList[i]];
                    i++;
                }
                else
                {
                    total += decodeDict[romanList[i]];
                }

            }

            return total;
        }
    }
}



