using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_VortexMathVisualization.Utilities
{
    internal class Point
    {
        private float x { get; set; }
        private float y { get; set; }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float GetX() { return x; }
        public float GetY() { return y; }

        public void SetX(float x) { this.x = x; }
        public void SetY(float y) { this.y = y; } 
    }
}
