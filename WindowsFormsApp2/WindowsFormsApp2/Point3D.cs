
using PointLib1;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    public class Point3D : Point
    {
        [JsonProperty("Name")]
        public string Name = "Point3D";
        public int Z { get; set; }

        public Point3D() : base()
        {
            Z = rnd.Next(10);
        }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override double Metric()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public override string ToString()
        {
            return string.Format($"({X} , {Y}, {Z})");
        }
    }
}
