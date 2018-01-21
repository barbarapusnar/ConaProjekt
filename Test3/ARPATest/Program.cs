using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ARPATest
{
    class Program
    {
        static void Main(string[] args)
        {
            Beri().Wait();
        }
        static async Task Beri()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(new Uri("http://dev.meteo.fvg.it/xml/stazioni/MNF.xml"));
            if (response.IsSuccessStatusCode)
            {

                var x = await response.Content.ReadAsStreamAsync();
                XmlSerializer ser = new XmlSerializer(typeof(data));
                Stream rawXml = x;
                var p = ser.Deserialize(rawXml) as data;
                Console.WriteLine(p.last_update);
            }
            Console.WriteLine("Konec");
            Console.ReadLine();
        }
    }
}
