using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OPP_LABA3
{
    class Sax : IStrategy
    {
        XmlDocument doc = new XmlDocument();
        List<Guitar> info = new List<Guitar>();
        public Sax(string path)
        {
            doc.Load(path);
        }
        public List<Guitar> Algorithm(Guitar guitar, string path)
        {
            info.Clear();
            XmlReader reader = XmlReader.Create(path);
            List<Guitar> result = new List<Guitar>();
            Guitar gt = null;
            while(reader.Read())
            {
                if(reader.Name == "Guitar")
                {
                    gt = new Guitar();
                    if(reader.HasAttributes)
                    {
                        while(reader.MoveToNextAttribute())
                        {
                            if(reader.Name == "TYPE")
                            {
                                gt.Type = reader.Value;
                            }
                            if (reader.Name == "BRAND")
                            {
                                gt.Brand = reader.Value;
                            }
                            if (reader.Name == "BODY")
                            {
                                gt.Body = reader.Value;
                            }
                            if (reader.Name == "MATERIAL")
                            {
                                gt.Material = reader.Value;
                            }
                            if (reader.Name == "COUNTRY")
                            {
                                gt.Country = reader.Value;
                            }
                            if(reader.Name == "NAME")
                            {
                                gt.Name = reader.Value;
                            }
                        }
                        result.Add(gt);
                    }
                }
            }
            info = Filtr(result, guitar);
            return info;
        }
        private List<Guitar> Filtr(List<Guitar> all, Guitar param)
        {
            List<Guitar> result = new List<Guitar>();
            foreach(Guitar g in all)
            {
                try
                {
                    if(
                        (g.Type == param.Type || param.Type == null) &&
                        (g.Brand == param.Brand || param.Brand == null) &&
                        (g.Body == param.Body || param.Body == null) &&
                        (g.Material == param.Material || param.Material == null) &&
                        (g.Country == param.Country || param.Country == null)
                      )
                    {
                        result.Add(g);
                    }
                }
                catch
                {

                }
            }
            return result;
        }
    }
}
