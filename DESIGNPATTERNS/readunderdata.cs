using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    internal class readunderdata
    {
        
/*query filter from code */
        public static void underdata()
        {
           
            var data = File.ReadAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt").ToList();
            List<string> gapes = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Length != 0)
                {
                    RegexOptions options = RegexOptions.None;
                    Regex regex = new Regex("[ ]{2,}", options);
                    data[i] = regex.Replace(data[i], " ");
                    gapes.Add(data[i]);
                }

            }

            List<string> words = new List<string>();
            for (int i = 0; i < gapes.Count; i++)
            {
               string[] d = gapes[i].Split(new char[] { ' ',',' });
                for (int j = 0; j < d.Length; j++)
                {
                    words.Add(d[j]);
                }
               
            }
            List<string> colum = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == "[")
                {
                    for (int j = i+1; j < words.Count; j++)
                    {
                       
                        if (words[j] == "]")
                        {
                            break;
                        }
                        if (words[j].Length != 0)
                        {
                            colum.Add(words[j]);
                        }
                       
                    }
                }
            }
            int columncount = colum.Count;
            List<string> purecolum = new List<string>();
            
            for (int i = 0; i < colum.Count; i++)
            {
                if (i != columncount-1)
                {
                    purecolum.Add(colum[i]+",");
                }
                else
                {
                    purecolum.Add(colum[i]+" ");
                }
            }
            List<string> columndata = new List<string>();
            string s1 = string.Join(" ", purecolum);
            columndata.Add($"mangalsingh( {s1})"
                                       + "\n{\n"
                                       + "\n"
                                       + "\n"
                                       + "}");


            if (!File.Exists(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.txt"))
            {
                File.Create(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.txt").Dispose();
                File.WriteAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.txt", columndata);
            }
            else
            {
                File.WriteAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.txt", columndata);
            }

          
        }
    }
}
