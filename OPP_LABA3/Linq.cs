using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OPP_LABA3
{
    class Linq : IStrategy
    {
        List<Guitar> info = new List<Guitar>();
        XDocument doc = new XDocument();
        public Linq(string path)
        {
            doc = XDocument.Load(path);
        }
        public List<Guitar> Algorithm(Guitar guitar, string path)
        {
            List<XElement> match = (from val in doc.Descendants("Guitar")
                                    where
                                    ((guitar.Type == null || guitar.Type == val.Attribute("TYPE").Value) &&
                                     (guitar.Brand == null || guitar.Brand == val.Attribute("BRAND").Value) &&
                                     (guitar.Body == null || guitar.Body == val.Attribute("BODY").Value) &&
                                     (guitar.Material == null || guitar.Material == val.Attribute("MATERIAL").Value) &&
                                     (guitar.Country == null || guitar.Country == val.Attribute("COUNTRY").Value) &&
                                     (guitar.Name == null || guitar.Name == val.Attribute("NAME").Value))
                                    select val).ToList();
            foreach (XElement obj in match)
            {
                Guitar guitar1 = new Guitar();
                guitar1.Type = obj.Attribute("TYPE").Value;
                guitar1.Brand = obj.Attribute("BRAND").Value;
                guitar1.Body = obj.Attribute("BODY").Value;
                guitar1.Material = obj.Attribute("MATERIAL").Value;
                guitar1.Country = obj.Attribute("COUNTRY").Value;
                guitar1.Name = obj.Attribute("NAME").Value;
                info.Add(guitar1);
            }
            return info;
        }
    }
}
