using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    internal class REMOVEMULTIPLESPACE
    {
        public static void remove()
        {
            string sentence = "This is     a sentence   with   multiple      spaces";
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            sentence = regex.Replace(sentence, " ");
            string[] sep = sentence.Split(" ");
            foreach (string s in sep)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
