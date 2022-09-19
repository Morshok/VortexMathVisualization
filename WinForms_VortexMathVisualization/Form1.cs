using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WinForms_VortexMathVisualization
{
    public partial class VortexMathVisualizerForm : Form
    {
        public VortexMathVisualizerForm()
        {
            InitializeComponent();
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            int multiplier = int.Parse(multiplierTextBox.Text);
            int modulo = int.Parse(multiplierTextBox.Text);

            VisualizeVortexMath(multiplier, modulo);
        }

        private void VisualizeVortexMath(int multiplier, int modulo)
        { 

        }
    }
}
