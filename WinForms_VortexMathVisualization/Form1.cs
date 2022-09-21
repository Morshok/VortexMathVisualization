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
        private int center_x, center_y, radius, margin, yellowCircleDimensions, multiplier, modulo;
        private float penLineWidth;
        private Rectangle initialCircle;

        public VortexMathVisualizerForm()
        {
            InitializeComponent();

            this.colormodeComboBox.SelectedIndex = 0;
            this.linewidthComboBox.SelectedIndex = 0;

            if (float.TryParse(linewidthComboBox.SelectedItem.ToString(), out _))
                this.penLineWidth = float.Parse(linewidthComboBox.SelectedItem.ToString());

            center_x = center_y = Math.Max(canvas.Width / 2, canvas.Height / 2);
            margin = 10;
            yellowCircleDimensions = 5;
            radius = Math.Max(canvas.Width / 2, canvas.Height / 2) - margin;
            initialCircle = new Rectangle(margin, margin, canvas.Width - 2 * margin, canvas.Height - 2 * margin);
        }

        private void linewidthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(float.TryParse(linewidthComboBox.SelectedItem.ToString(), out _))
                this.penLineWidth = float.Parse(linewidthComboBox.SelectedItem.ToString());

            VisualizeVortexMath(multiplier, modulo);
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            bool multiplierParsedCorrectly = int.TryParse(multiplierTextBox.Text, out this.multiplier);
            bool moduloParsedCorrectly = int.TryParse(moduloTextBox.Text, out this.modulo);

            if (multiplierParsedCorrectly && moduloParsedCorrectly)
            {
                VisualizeVortexMath(multiplier, modulo);
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

        private void VisualizeVortexMath(int multiplier, int modulo)
        {
            canvas.Refresh();

            List<Utilities.Point> points = Utilities.Utils.GetPointsOnCircle(new Utilities.Point(center_x, center_y), radius, modulo);
            List<int[]> loops = Utilities.Utils.GetLoops(multiplier, modulo);

            using (Graphics graphics = canvas.CreateGraphics())
            {
                graphics.DrawEllipse(new Pen(Brushes.Black), initialCircle);

                foreach (Utilities.Point point in points)
                {
                    float pointX = point.GetX();
                    float pointY = point.GetY();
                    Rectangle yellowCircle = new Rectangle((int)pointX - yellowCircleDimensions / 2, (int)pointY - yellowCircleDimensions / 2, yellowCircleDimensions, yellowCircleDimensions);

                    graphics.FillEllipse(Brushes.Yellow, yellowCircle);
                }

                Pen linePen = new Pen(Color.FromArgb(64, 0, 0, 0));
                linePen.Width = (float)this.penLineWidth;

                foreach (int[] loop in loops)
                {
                    if (loop.Length <= 1) continue;

                    for (int i = 0; i < loop.Length; i++)
                    {
                        Utilities.Point from = points[loop[i]];

                        int toIndex;
                        if (i < loop.Length - 1) toIndex = loop[i + 1];
                        else toIndex = loop[0];

                        Utilities.Point to = points[toIndex];

                        graphics.DrawLine(linePen, from.GetX(), from.GetY(), to.GetX(), to.GetY());
                    }
                }
            }
        }
    }
}