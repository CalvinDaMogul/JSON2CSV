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
            Dictionary<string,Record> MO = new Dictionary<string,Record>();
            MO = example1Model.Deserialize<Dictionary<string,Record>>(JsonString);
       

            Console.WriteLine(MO.Count());

            foreach (KeyValuePair<string,Record> obj in MO) 
                {
                     if(obj.Key=="0") {
                        foreach (KeyValuePair<string,object> i in obj.Value) {
                            Console.Write(i.Key);
                          if(i.Key != "assetQuoteAligned") Console.Write(",");
                        }
                            Console.WriteLine();
                    }

                   foreach (KeyValuePair<string,object> i in obj.Value) {
                    Console.Write(i.Value +",");
                    }

                Console.WriteLine();

                /*Record inner = obj.Value;
                Console.Write(inner.symbolID);
                Console.Write("," +inner.askPrice);
                Console.Write("," +inner.askSize);
                Console.WriteLine("," +inner.bidPrice);
                */
                }
            
             
            Console.ReadKey();
        }
    }
}
