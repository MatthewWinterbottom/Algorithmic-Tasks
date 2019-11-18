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
             * 
             * Problem:
             * 
            The main idea is to count all the occuring characters(UTF-8) in string.
            If you have string like this aba then the result should be { 'a': 2, 'b': 1 }
            What if the string is empty ? Then the result should be empty object literal { }
            */


            // Test cases
            var res = Count("aba");
            var res2 = Count("aaaa");
            var res3 = Count("aabb");
        }


        public static Dictionary<char, int> Count(string str)
        {
            if (String.IsNullOrWhiteSpace(str)) return new Dictionary<char, int>();

            var countedChars = new List<char>();
            var results = new Dictionary<char, int>();

            foreach (var item in str.ToList())
            {
                if (!countedChars.Contains(item))
                {
                    results[item] = str.Count(x => x.Equals(item));
                    countedChars.Add(item);
                }
            }

            return results;
        }
    }
}



