using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NoSQL
{
    public class Pozycja
    {
        [XmlElement(ElementName = "nazwa_waluty")]
        public string NazwaWaluty { get; set; }
        [XmlElement(ElementName = "przelicznik")]
        public int Przelicznik { get; set; }
        [XmlElement(ElementName = "kod_waluty")]
        public string KodWaluty { get; set; }
        [XmlElement(ElementName = "kurs_sredni")]
        public string KursSredni { get; set; }
    }

    [Serializable]
    [XmlRoot(ElementName="tabela_kursow")]
    public class TabelaKursow
    {
        [XmlElement(ElementName="numer_tabeli")]
        public string NumerTabeli { get; set; }

        [XmlElement(ElementName = "data_publikacji")]
        public DateTime DataPublikacji { get; set; }

        [XmlElement(ElementName = "pozycja")]
        public Pozycja[] Pozycje { get; set; }    
    
    }
}
