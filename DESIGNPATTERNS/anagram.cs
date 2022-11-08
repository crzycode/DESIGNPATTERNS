using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    internal class anagram
    {
        public static bool angrams(string a, string b)
        {
            var str1 = a.ToLower().ToArray();
            var str2 = b.ToLower().ToArray();
            Array.Sort(str1);
            Array.Sort(str2);
            return new string(str1) == new string(str2);

        }
    }
}
