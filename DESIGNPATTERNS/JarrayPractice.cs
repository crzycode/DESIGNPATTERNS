using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    internal class JarrayPractice
    {
        public static void Jarrays()
        {
            if (!File.Exists(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\rahul.json"))
            {
                File.Create(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\rahul.json").Dispose();
            }

            var dat = File.ReadAllText(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\rahul.json");
            /*        JObject obj = new JObject();

                    items.Add(new JProperty("ddd","hhg"));*/
            
 /*           dynamic record = new
            {
                result = new { name = "", address = "" },
               
            };
            
            string json = JsonConvert.SerializeObject(record, Formatting.Indented);
            dat.Insert(0,json);
            File.WriteAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\rahul.json", dat);*/

            JObject data = JsonConvert.DeserializeObject<JObject>(dat);
            for (int i = 0; i < data.Count; i++)
            {
                
            }
         
            data["result"]["valueName4"] = "value4";
        }
    }
}
