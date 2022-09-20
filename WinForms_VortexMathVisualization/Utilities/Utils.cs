using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_VortexMathVisualization.Utilities
{
    internal class Utils
    {
        public static Point[] GetPointsOnCircle(int centerPoint,int radius, int modulo)
        {
            Point[] points = new Point[radius];

            float circleArcRadius = (float)((2 * Math.PI) / modulo);
            for(int i = 0; i < modulo; i++)
            {
                float x = (float)(radius * Math.Cos(i * circleArcRadius - Math.PI / 2));
                float y = (float)(radius * Math.Sin(i * circleArcRadius - Math.PI / 2));
                points[i] = new Point(centerPoint + x, centerPoint+ y);
            }

            return points;
        }

        public static int[] GetLoops(int multiplier, int modulo)
        {
            

            return new int[modulo];
        }
    }
}
