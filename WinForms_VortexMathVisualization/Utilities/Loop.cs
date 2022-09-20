using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_VortexMathVisualization.Utilities
{
    internal class Loop
    {
        private int[] loops { get; set; }
        private int length { get; set; }
        public Loop() 
        {
            this.loops = new int[3];
        }
        public Loop(int[] loops) 
        {
            this.loops = loops;
            this.length = loops.Length;
        }

        public void Add(int number)
        {

        }

    }
}