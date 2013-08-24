using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwicKwakKwoc
{
    /// <summary>
    /// Filter the list of sentences by excluding those that start with any of the ignored words
    /// </summary>
    class IgnoreRemover
    {
        private List<string> ignoredWords;

        public static List<string> FilterList(List<string> sentences, List<string> ignoredWords)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < sentences.Count; i++)
            {
                string sentence = sentences[i];
                int index = sentence.IndexOf(" ");
                string firstWord = index > 0 ? sentence.Substring(0, index) : sentence;
                if (ignoredWords.FindIndex(x => x.Equals(firstWord, StringComparison.OrdinalIgnoreCase)) < 0) result.Add(sentence);
            }
            return result;
        }

    }
}
