using System;
using System.Collections.Generic;

namespace KwicKwakKwoc
{
    /// <summary>
    /// A class to generate all the different permutations of the words in the line achieved by circular shifting
    /// </summary>
    static class StringRotator
    {
        public static List<string> PermuteWords(string line)
        {
            List<string> result = new List<string>();
            string leftPart = line.Trim();
            string rightPart = String.Empty;

            result.Add(leftPart);
            int index = leftPart.IndexOf(" ");
            while (index > 0)
            {
                string firstWord = leftPart.Substring(0, index);
                rightPart += rightPart.Length > 0 ? " " + firstWord : firstWord;
                leftPart = leftPart.Substring(index + 1);

                result.Add(leftPart + " " + rightPart);
                index = leftPart.IndexOf(" ");
            }

            return result;
        }
    }
}
