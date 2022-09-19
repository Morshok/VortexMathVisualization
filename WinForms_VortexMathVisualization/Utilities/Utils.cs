using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_VortexMathVisualization.Utilities
{
    internal class Utils
    {
        public static int DigitalRoot(int number)
        {
            int root = 0;

            while (number > 0 || root > 9)
            {
                if (number == 0)
                {
                    number = root;
                    root = 0;
                }

                root += number % 10;
                number /= 10;
            }

            return root;
        }
    }
}
