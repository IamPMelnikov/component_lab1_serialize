using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    public class Pr
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Pr()
        {
        }
        public Pr(int x, int y, int z, string n)
        {
            X = x;
            Y = y;
            Z = z;
            Name = n;
        }
        public Pr(int x, int y, string n)
        {
            X = x;
            Y = y;
            Name = n;
        }
        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }
}

