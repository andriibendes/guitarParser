using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OPP_LABA3
{
    class Dom : IStrategy
    {
        XmlDocument doc = new XmlDocument();
        public Dom(string path)
        {
            doc.Load(path);
        }
        public List<Guitar> Algorithm(Guitar guitar, string path)
        {
            List<List<Guitar>> info = new List<List<Guitar>>();
            try
            {
                if (guitar.Type != null)
                    info.Add(SearchByParam("TYPE", guitar.Type, doc));
                if (guitar.Brand != null)
                    info.Add(SearchByParam("BRAND", guitar.Brand, doc));
                if (guitar.Body != null)
                    info.Add(SearchByParam("BODY", guitar.Body, doc));
                if (guitar.Material != null)
                    info.Add(SearchByParam("MATERIAL", guitar.Material, doc));
                if (guitar.Country != null)
                    info.Add(SearchByParam("COUNTRY", guitar.Country, doc));
            }
            catch
            {

            }
            if (guitar.Type == null && guitar.Brand == null && guitar.Body == null && guitar.Material == null && guitar.Country == null)
                return AllGuitars(doc);
            return Cross(info);
        }
        private Guitar Info(XmlNode node)
        {
            Guitar guitar = new Guitar();
            guitar.Type = node.Attributes.GetNamedItem("TYPE").Value;
            guitar.Brand = node.Attributes.GetNamedItem("BRAND").Value;
            guitar.Body = node.Attributes.GetNamedItem("BODY").Value;
            guitar.Material = node.Attributes.GetNamedItem("MATERIAL").Value;
            guitar.Country = node.Attributes.GetNamedItem("COUNTRY").Value;
            guitar.Name = node.Attributes.GetNamedItem("NAME").Value;
            return guitar;
        }
        private List<Guitar> AllGuitars(XmlDocument doc)
        {
            List<Guitar> data = new List<Guitar>();
            XmlNodeList nodeList = doc.SelectNodes("//Guitar");
            try
            {
                foreach(XmlNode xml in nodeList)
                {
                    data.Add(Info(xml));
                }
            }
            catch
            {

            }
            return data;
        }
        private List<Guitar> SearchByParam(string attribute, string param, XmlDocument doc)
        {
            List<Guitar> guitars = new List<Guitar>();
            if(param != String.Empty && param != null)
            {
                XmlNodeList nodeList = doc.SelectNodes("//Guitar" + "[@" + attribute + "='" + param + "']");
                foreach(XmlElement element in nodeList)
                {
                    guitars.Add(Info(element));
                }
            }
            return guitars;
        }
        private List<Guitar> Cross(List<List<Guitar>> list)
        {
            List<Guitar> result = new List<Guitar>();
            try
            {
                if(list != null)
                {
                    Guitar[] guitars = list[0].ToArray();
                    if(guitars != null)
                    {
                        foreach(Guitar guitar in guitars)
                        {
                            bool isin = true;
                            foreach (List<Guitar> guitars1 in list)
                            {
                                foreach(Guitar guitar1 in guitars1)
                                {
                                    isin = false;
                                    if(guitar.Comparing(guitar1))
                                    {
                                        isin = true;
                                        break;
                                    }
                                }
                                if (!isin)
                                    break;
                            }
                            if(isin)
                            {
                                result.Add(guitar);
                            }
                        }
                    }
                }
            }
            catch
            {

            }
            return result;
        }

    }
}
