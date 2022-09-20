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
            int multiplier, modulo;

            if(int.TryParse(multiplierTextBox.Text, out multiplier) && int.TryParse(moduloTextBox.Text, out modulo))
            {
                // Execute code here
            }
            else
            {
                bool multiplierParsedCorrectly =  int.TryParse(multiplierTextBox.Text, out multiplier);
                bool moduloParsedCorrectly = int.TryParse(moduloTextBox.Text, out modulo);

                string message = string.Empty;
                if (!multiplierParsedCorrectly) message += "Please let multiplier be an integer... \n";
                if (!moduloParsedCorrectly) message += "Please let modulo be an integer... \n";

                string title = "Warning!";
                MessageBox.Show(message, title, MessageBoxButtons.OK);
            }
        }
    }
}
