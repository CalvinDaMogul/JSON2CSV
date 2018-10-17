using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace JSON2CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject o1 = JObject.Parse(File.ReadAllText(@"c:\users\caljf\downloads\coinAPIData-20180218-0133.json"));

            // read JSON directly from a file
            //using (StreamReader file = File.OpenText(@"c:\videogames.json"))
            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            //    JObject o2 = (JObject)JToken.ReadFrom(reader);
            //}
            int i = 0;
            foreach (JProperty obj in o1.Children())
            {

                string nameProperty = i.ToString();

                JProperty obj1 = (JProperty)obj[nameProperty];
               
                Console.WriteLine(obj1["symbolID"].Values());
                i++;
            }


            
            Console.ReadKey();
        }
    }
}
