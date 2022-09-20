﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_VortexMathVisualization.Utilities
{
    internal class Utils
    {
        public static List<Point> GetPointsOnCircle(int centerPoint,int radius, int modulo)
        {
            List<Point> points = new List<Point>();

            float circleArcRadius = (float)((2 * Math.PI) / modulo);
            for(int i = 0; i < modulo; i++)
            {
                float x = (float)(radius * Math.Cos(i * circleArcRadius - Math.PI / 2));
                float y = (float)(radius * Math.Sin(i * circleArcRadius - Math.PI / 2));
                points.Add(new Point(centerPoint + x, centerPoint+ y));
            }

            return points;
        }

        public static List<int[]> GetLoops(int multiplier, int modulo)
        {
            List<int[]> loops = new List<int[]>();
            Stack<int> visited = new Stack<int>();

            for(int i = 0; i < modulo; i++)
            {
                if (visited.Contains(i)) continue;

                visited.Push(i);

                List<int> loop_i = new List<int>();
                int u = i;

                while(true)
                {
                    u = (u * multiplier) % modulo;
                    loop_i.Add(u);
                    if(visited.Contains(u)) break;
                    visited.Push(u);
                }

                loops.Add(loop_i.ToArray());
            }

            return loops;
        }
    }
}
