using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    internal class addnextline
    {
        public static void addnextlines()
        {
            var data = File.ReadAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt").ToList();
            List<string> lines = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                
                lines.Add(data[i]);
                if (data[i] == " manoj")
                {
                    lines.Add("gfgf");
                }
            }
            File.WriteAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt", lines);
        }
    }
}
