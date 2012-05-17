using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using MongoDB;
using MongoDB.Linq;

namespace NoSQL
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient wc = new WebClient();
            string dane = wc.DownloadString("http://nbp.pl/kursy/xml/LastA.xml");  //sciagniety xml
            XmlSerializer serial = new XmlSerializer(typeof(TabelaKursow));

            byte[] bajts = Encoding.UTF8.GetBytes(dane);
            TabelaKursow tk = serial.Deserialize(new MemoryStream(bajts)) as TabelaKursow;

            Mongo mg = new Mongo();
            mg.Connect();
            var db = mg.GetDatabase("waluty");
            var collection = db.GetCollection<TabelaKursow>();

            

            Console.WriteLine("Ilosc dokumentow: {0}", collection.Count());
            collection.Insert(tk);

        }
    }
}
