using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    internal class removelinespaceboth
    {
        public static void removelinespace()
        {
            var data = File.ReadAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt").ToList();
            List<string> lines = new List<string>();

            for (int i = 0; i < data.Count; i++)
            {
                    RegexOptions options = RegexOptions.None;
                    Regex regex = new Regex("[ ]{2,}", options);
                    data[i] = regex.Replace(data[i], " ");
                if (data[i].Length != 0)
                {
                    lines.Add(data[i]);
                }
            }
            File.WriteAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt", lines);
        }
    }
}
