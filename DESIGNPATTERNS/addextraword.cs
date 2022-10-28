using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    internal class addextraword
    {
        public static void addextraword1()
        {
            var data = File.ReadAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt").ToList();

            for (int i = 0; i < data.Count; i++)
            {
                string[] d = data[i].Split(" ");
                for (int j = 0; j < d.Length; j++)
                {
                    if (d[j] == "ram")
                    {
                        d[j] += ", "+"kal"+" ";
                        string s1 = string.Join(" ", d);
                        data[i] = s1;

                        RegexOptions options = RegexOptions.None;
                        Regex regex = new Regex("[ ]{2,}", options);
                        data[i] = regex.Replace(data[i], " ");
                    }
                   
                }
            }
            File.WriteAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt", data);
        }

        public static void addextraword2()
        {
            var data = File.ReadAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt").ToList();

            for (int i = 0; i < data.Count; i++)
            {
                var d = data[i].Split(" ");
                for (int j = 0; j < d.Length; j++)
                {
                    if (d[j] == "public")
                    {
                        d[j] += " "+"private";
                        string s1 = string.Join(" ", d);
                        data[i] = s1;
                    }
                }
            }
            File.WriteAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt", data);
        }
    }
}
