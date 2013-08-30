using System;
using System.Collections.Generic;

namespace KwicKwakKwoc
{
    /// <summary>
    /// A class to filter the list of lines by excluding those that start with any of the ignored words
    /// </summary>
    class IgnoreRemover
    {
        public static List<string> FilterList(List<string> lines, List<string> ignoredWords)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                int index = line.IndexOf(" ");
                string firstWord = index > 0 ? line.Substring(0, index) : line;
                // we add line only if the first word is not in the list of ignored words
                if (ignoredWords.FindIndex(x => x.Equals(firstWord, StringComparison.OrdinalIgnoreCase)) < 0)
                {
                    result.Add(line);
                }
            }
            return result;
        }

    }
}
