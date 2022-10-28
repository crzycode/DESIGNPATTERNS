using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    internal class wordreplacer
    {
        public static void wordreplace()
        {
            var data = File.ReadAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt").ToList();

            for (int i = 0; i < data.Count; i++)
            {
                var d = data[i].Split(" ");
                for (int j = 0; j < d.Length; j++)
                {
                    if (d[j] == "public")
                    {
                        d[j] += "private";
                        string s1 = string.Join(" ",d);
                        data[i] = s1;
                    }
                }
            }
            File.WriteAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt", data);
        }
    }
}
