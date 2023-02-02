using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal struct Hexagon : IShape
    {
        readonly public float width;
        readonly public float height;

        public Hexagon(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public float Width { get { return width; } }
        public float Height { get { return height; } }
        public float Surface { get { return width * width * 3 * MathF.Sqrt(3) / 2; ; } }
        public float Circumference { get { return width * 6; } }
    }
}