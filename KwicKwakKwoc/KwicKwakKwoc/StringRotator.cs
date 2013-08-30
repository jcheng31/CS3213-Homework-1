using System;
using System.Collections.Generic;

namespace KwicKwakKwoc
{
    /// <summary>
    /// A class to generate all the different permutations of the words in the line achieved by circular shifting.
    /// 
    /// Every circular shift will cut the first word in leftPart and add it to the end of rightPart.
    /// The concatenation of leftPart and rightPart will form one of the permutations.
    /// </summary>
    static class StringRotator
    {
        public static List<string> PermuteWords(string line)
        {
            List<string> result = new List<string>();

            string leftPart = line.Trim();
            string rightPart = String.Empty;
            result.Add(leftPart + rightPart);

            // check if leftPart has more than one word, if it does, we need to circular shift
            int index = leftPart.IndexOf(" ");
            while (index > 0)
            {
                string firstWord = leftPart.Substring(0, index);

                // we wanted rightPart to have spaces between words but no leading spaces
                rightPart += rightPart.Length > 0 ? " " + firstWord : firstWord;
                // cut the first word from leftPart
                leftPart = leftPart.Substring(index + 1);
                result.Add(leftPart + " " + rightPart);

                index = leftPart.IndexOf(" ");
            }

            return result;
        }
    }
}
