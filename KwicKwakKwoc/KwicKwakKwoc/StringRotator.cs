using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwicKwakKwoc
{
    static class StringRotator
    {
        public static List<string> PermuteWords(string line)
        {
            List<string> lines = new List<String>();
            lines.Add(line);

            string partLeft = line;
            string partRight = String.Empty;

            string[] words = line.Trim().Split(' ');
            foreach (string word in words)
            {
                partRight = " " + word;
                partLeft = partLeft.Substring(word.Length - 1);
                string newLine = partLeft + partRight;
                lines.Add(newLine);
            }



            return lines;
        }
    }
}
