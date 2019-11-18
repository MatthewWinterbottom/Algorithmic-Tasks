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
            Complete the solution so that it splits the string into pairs of two characters.
            If the string contains an odd number of characters then it should replace the missing
            second character of the final pair with an underscore ('_').
            Examples:
            SplitString.Solution("abc"); // should return ["ab", "c_"]
            SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"]
            */

            var res = Solution("abc");
            var res2 = Solution("abcdef");

        }


        public static string[] Solution(string str)
        {
            // Init result list, list type allows us to add
            var resList = new List<string>();

            // If odd number of charcters, add underscore
            if (str.Length % 2 != 0) str += '_';

            // Convert string to list so can index
            var strList = str.ToList();

            // Add a string of two characters combined
            for (int i = 0; i < str.Length; i += 2)
                resList.Add($"{strList[i]}{strList[i+1]}");


            return resList.ToArray();
        }
    }
}



