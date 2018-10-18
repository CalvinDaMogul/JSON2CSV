using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web.Script;
using System.Web.Script.Serialization;

namespace JSON2CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string JsonString = File.ReadAllText(@"c:\users\caljf\downloads\JSON2CSV2.txt");
            var example1Model = new JavaScriptSerializer();
            example1Model.MaxJsonLength = Int32.MaxValue;
            example1Model.Deserialize<MainObject>(JsonString);
            // read JSON directly from a file
            //using (StreamReader file = File.OpenText(@"c:\videogames.json"))
            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            //    JObject o2 = (JObject)JToken.ReadFrom(reader);
            //}
            int i = 0;
            MainObject MO = (MainObject)example1Model;
            foreach (Outer obj in 
            {

              
               
                Console.WriteLine(obj.recordValue.symbolID);
                i++;
            }


            
            Console.ReadKey();
        }
    }
}
