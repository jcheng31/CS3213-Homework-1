using System;
using System.Collections.Generic;

namespace KwicKwakKwoc
{
    static class Sorter
    {
        public static List<String> SortList(List<string> filtered)
        {
            filtered.Sort((s1, s2) => String.Compare(s1, s2, StringComparison.OrdinalIgnoreCase));
            return filtered;
        }
    }
}