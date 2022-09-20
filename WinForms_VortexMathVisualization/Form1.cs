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
        private int center_x, center_y, radius, margin, yellowCircleDimensions;
        private Rectangle initialCircle;

        public VortexMathVisualizerForm()
        {
            InitializeComponent();
            center_x = center_y = Math.Max(canvas.Width / 2, canvas.Height / 2);
            margin = 10;
            yellowCircleDimensions = 10;
            radius = Math.Max(canvas.Width / 2, canvas.Height / 2) - margin;
            initialCircle = new Rectangle(margin, margin, canvas.Width - 2 * margin, canvas.Height - 2 * margin);
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            int multiplier, modulo;

            bool multiplierParsedCorrectly = int.TryParse(multiplierTextBox.Text, out multiplier);
            bool moduloParsedCorrectly = int.TryParse(moduloTextBox.Text, out modulo);

            if (multiplierParsedCorrectly && moduloParsedCorrectly)
            {
                canvas.Refresh();

                List<Utilities.Point> points = Utilities.Utils.GetPointsOnCircle(new Utilities.Point(center_x, center_y), radius, modulo);
                List<int[]> loops = Utilities.Utils.GetLoops(multiplier, modulo);

                using(Graphics graphics = canvas.CreateGraphics())
                {
                    graphics.DrawEllipse(new Pen(Brushes.Black), initialCircle);

                    foreach(Utilities.Point point in points)
                    {
                        float pointX = point.GetX();
                        float pointY = point.GetY();
                        Rectangle yellowCircle = new Rectangle((int)pointX - margin / 2, (int)pointY - margin / 2, yellowCircleDimensions, yellowCircleDimensions);

                        graphics.FillEllipse(Brushes.Yellow, yellowCircle);
                    }

                    foreach (int[] loop in loops)
                    {
                        for(int i = 0; i < loop.Length; i++)
                        {
                            Utilities.Point from = points[i];
                            Utilities.Point to = points[loop[i]];

                            graphics.DrawLine(new Pen(Brushes.Black), from.GetX(), from.GetY(), to.GetX(), to.GetY());
                        }
                    }
                }
            }
            else
            {
                string message = string.Empty;
                if (!multiplierParsedCorrectly) message += "Please let multiplier be an integer... \n";
                if (!moduloParsedCorrectly) message += "Please let modulo be an integer... \n";

                string title = "Warning!";
                MessageBox.Show(message, title, MessageBoxButtons.OK);
            }
        }
    }
}