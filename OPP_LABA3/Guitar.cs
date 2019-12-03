using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_LABA3
{
    class Guitar
    {
        public string Type = null;
        public string Brand = null;
        public string Body = null;
        public string Material = null;
        public string Country = null;
        public string Name = null;
        public Guitar()
        {

        }
        public Guitar(string[] data)
        {
            Type = data[0];
            Brand = data[1];
            Body = data[2];
            Material = data[3];
            Country = data[4];
            Name = data[5];
        }
        public Guitar(IStrategy algo)
        {
            Type = String.Empty;
            Brand = String.Empty;
            Body = String.Empty;
            Material = String.Empty;
            Country = String.Empty;
        }
        public bool Comparing(Guitar guitar)
        {
            if ((this.Type == guitar.Type) &&
               (this.Brand == guitar.Brand) &&
               (this.Body == guitar.Body) &&
               (this.Material == guitar.Material) &&
               (this.Country == guitar.Country))
                return true;
            else
                return false;
        }
        public IStrategy Algo { get; set; }
        public List<Guitar> Algorithm(Guitar guitar, string path)
        {
            return Algo.Algorithm(guitar, path);
        }
    }
}
