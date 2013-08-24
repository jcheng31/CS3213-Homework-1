using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwicKwakKwoc
{
    static class Controller
    {
        public static List<String> GenerateKwicIndex(List<String> titles, List<String> ignore)
        {
            List<String> permutations = GeneratePermutations(titles);
            List<String> filtered = RemoveIgnoredWords(permutations, ignore);
            filtered.Sort((s1, s2) => String.Compare(s1, s2, StringComparison.Ordinal));

            return filtered;
        }

        private static List<String> RemoveIgnoredWords(List<String> permutations, List<String> ignore)
        {
            return IgnoreRemover.FilterList(permutations, ignore);
        }

        private static List<String> GeneratePermutations(List<String> titles)
        {
            List<String> permuted = new List<string>();
            foreach (String title in titles)
            {
                List<String> titlePermutations = StringRotator.PermuteWords(title);
                foreach (String permutation in titlePermutations)
                {
                    permuted.Add(permutation);
                }
            }
            return permuted;
        }
    }
}
