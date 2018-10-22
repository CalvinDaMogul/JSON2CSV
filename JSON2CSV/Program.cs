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
            Outer MO = new Outer();
            MO.Inner = example1Model.Deserialize<Dictionary<string,Record>>(JsonString);
       

            Console.WriteLine(MO.Inner.Count());

            foreach (KeyValuePair<string,Record> obj in MO.Inner) 
                {

                Record inner = obj.Value;
                Console.WriteLine("Symbol: " + inner["symbolID"]);
                }
            
             
            Console.ReadKey();
        }
    }
}
