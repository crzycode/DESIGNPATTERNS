using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    internal class removelinegap
    {
        public static void removelinegaper()
        {
            var data = File.ReadAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt").ToList();
            List<string> lines = new List<string>();

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Length != 0)
                {
                    lines.Add(data[i]);
                }

            }
            File.WriteAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\TextFile1.txt", lines);

        }
    }
}