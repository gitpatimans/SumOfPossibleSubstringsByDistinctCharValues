using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfPossibleSubStringsByDistinctCharValue
{
    internal class SumOfPossibleSubStringsByDistinctCharValue
    {
        public static int FindSumOfPossibleSubStringsByDistinctCharValues(string strInput)
        {
            int resultSum = !string.IsNullOrEmpty(strInput) ? strInput.Length : 0; ;
            if (!string.IsNullOrEmpty(strInput))
            {
                // Get all possible substrings of a given string
                List<string> possibleSubStrings = GetAllSubStrings(strInput);
                if (possibleSubStrings?.Count > 0)
                {
                    // Count the distinct chars from possible substrings
                    GetSumOfPossibleSubStringsByDistinctCharValues(possibleSubStrings, out resultSum);
                }
            }
            return resultSum;
        }

        private static void GetSumOfPossibleSubStringsByDistinctCharValues(List<string> possibleSubStrings, out int resultSum)
        {
            resultSum = 0;
            foreach (string possibleSubString in possibleSubStrings)
            {
                resultSum = resultSum + possibleSubString.Distinct().Count();
            }
        }

        private static List<string> GetAllSubStrings(string strInput)
        {
            // test -> 't', 'te', 'tes', 'test', 'e', 'es', 'est', 's', 'st', 't'
            // good -> 'g', 'go', 'goo', 'good', 'o', 'oo', 'ood', 'o', 'od', 'd'
            List<string> possibleSubStrings = new List<string>();
            for (int i = 0; i < strInput.Length; i++)
            {
                string possibleSubString = Convert.ToString(strInput[i]);
                possibleSubStrings.Add(possibleSubString);
                for (int j = i + 1; j < strInput.Length; j++)
                {
                    possibleSubString = possibleSubString + Convert.ToString(strInput[j]);
                    possibleSubStrings.Add(possibleSubString);
                }
            }
            return possibleSubStrings;
        }
    }
}
