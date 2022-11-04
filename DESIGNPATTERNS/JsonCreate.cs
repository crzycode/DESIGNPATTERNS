using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGNPATTERNS
{
    internal class JsonCreate
    {
        public static string createjson()
        {
            if (!File.Exists(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.json"))
            {
                File.Create(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.json").Dispose();
                File.WriteAllText(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.json", "[\n]");
            }



            Writedata();





            return "hh";
        }
        private static void Writedata()
        {
            var readdata = File.ReadAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.json").ToList();

            /*dynamic product = new JObject();
            product.UserId = 123;
            product.Username = "Elbow Grease";
            product.SqlServer = new JObject(
             new JProperty("Tables", "rakesh"),
                  mangal = new JObject(
                 new JProperty("Tables", "rakesh")
                 )
             );
            product.ConectionString = new JObject(
                new JProperty("mangal", "rakesh")
                );*/

            /* dynamic record = new 
             {
                 name = "", address = "",
                     manal = new
                     {
                         rahul = new
                         {

                         }
                     }


             };*/
            dynamic product = new JObject();
            product.UserId = 33;
            product.Username = "Elbow Grease";
            product.man = new JObject();
            product.man.Add("gg", "gg");
            product.ras = new JArray();
            product.ras.Add(new JObject(new JProperty("g","h")) );
            product.mff = new JObject(new JProperty("g", "h"));






            product.SqlServer = new JArray(new JObject(
             new JProperty("DockerName", "gg")
             ));




            var json = JsonConvert.SerializeObject(product, Formatting.Indented);

            readdata.Insert(1, "," + json);
            File.WriteAllLines(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.json", readdata);
        }
        private static void updatedata()
        {
            var des = File.ReadAllText(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.json");

            dynamic rada = JsonConvert.DeserializeObject<List<dynamic>>(des);

            

            for (int i = 0; i < rada.Count; i++)
            {
                if (rada[i].UserId == 33)
                {
                    rada[i].Username = "rakesh";
                    rada[i].SqlServer = "round";
                    for (int j = 0; j < rada[i].Tags.Count; j++)
                    {
                        rada[i].Tags[j].mangal = "Rahul";
                            Console.WriteLine(rada[i].Tags[j]); 
                    }
                       /* var data = JsonConvert.SerializeObject(rada[i]);
                        var jObj = JObject.Parse(data);
                        jObj.Username = "mangal";*/
                        var js = JsonConvert.SerializeObject(rada, Formatting.Indented);
                      
                        File.WriteAllText(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.json", js);
                    
                }
            }
        }
        private static void addProperties()
        {
            var des = File.ReadAllText(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.json");

            dynamic rada = JsonConvert.DeserializeObject<List<dynamic>>(des);

            for (int i = 0; i < rada.Count; i++)
            {
                if (rada[i].UserId == 33)
                {

                    /*Console.WriteLine(rada[i]);*/

                    /*rada[i].Tags.Add(new JObject(new JProperty("hellow", "hello")));*/

                    
                    
                    /*JObject obj = JObject.Parse(rada[i].SqlServer);*/

                    var js = JsonConvert.SerializeObject(rada[i], Formatting.Indented);
                    

                    

                    var obj = JObject.Parse(js);
                    var h = JsonConvert.SerializeObject(obj["SqlServer"]);
                    dynamic fd = JsonConvert.DeserializeObject<List<dynamic>>(h);
                    var dd = JsonConvert.SerializeObject(fd);

                    var obj1 = JArray.Parse(dd);
                    obj1["ff"] = "hh";


                    Console.WriteLine(obj1);
                    
                    File.WriteAllText(@"D:\VisualStudioProject\DESIGNPATTERNS\DESIGNPATTERNS\mangal.json", js);
                }
            }
        }
    }
}
