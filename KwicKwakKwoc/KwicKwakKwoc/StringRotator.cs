using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwicKwakKwoc
{
    static class StringRotator
    {
        public static List<string> PermuteWords(string sentence)
        {
            List<string> result = new List<string>();
            string leftPart = sentence.Trim();
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
