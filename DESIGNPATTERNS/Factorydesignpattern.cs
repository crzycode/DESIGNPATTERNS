using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    public class Factorydesingpattern
    { 
        public static void executefactory()
        {
            Console.WriteLine("type of your object type");
        string type = Console.ReadLine();
        details data = createbject.getobject(type);
        Console.WriteLine(data.getname());
        }
      
    }
    class createbject
    {
        public static details getobject(string typeofobj)
        {
            details obj = null;
            if (typeofobj.ToLower() == "student")
            {
                obj = new student();
            }
            else
            {
                obj = new teacher();
            }
            return obj;
        }
    }
    interface details
    {
        string getname();
        string getfathername();
    }
    public class student : details
    {
        public string getname()
        {
            return "student name";

        }
        public string getfathername()
        {
            return "student fathers name";
        }
    }
    public class teacher : details
    {
        public string getname()
        {
            return "teacher name";

        }
        public string getfathername()
        {
            return "teacher fathers name";
        }
    }
}
