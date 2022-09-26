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
using System.Drawing.Imaging;
using System.IO;

namespace WinForms_VortexMathVisualization
{
    enum ColorMode
    {
        None,
        LoopGroup,
        LineLength
    }

    public partial class VortexMathVisualizerForm : Form
    {
        private int center_x, center_y, radius, margin, yellowCircleDimensions, multiplier, modulo;
        private float penLineWidth;
        private ColorMode colorMode;
        private Color[] LineLengthColors;

        private Bitmap bitmap;
        private Graphics graphics;

        private Rectangle initialCircle;

        public VortexMathVisualizerForm()
        {
            InitializeComponent();

            this.bitmap = new Bitmap(canvas.Width, canvas.Height);
            this.graphics = Graphics.FromImage(this.bitmap);
            this.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.canvas.BackgroundImage = this.bitmap;
            this.canvas.BackgroundImageLayout = ImageLayout.None;

            this.colormodeComboBox.SelectedIndex = 0;
            this.linewidthComboBox.SelectedIndex = 0;

            if (float.TryParse(linewidthComboBox.SelectedItem.ToString(), out _))
                this.penLineWidth = float.Parse(linewidthComboBox.SelectedItem.ToString());

            this.colorMode = (ColorMode)colormodeComboBox.SelectedIndex;

            LineLengthColors = new Color[] 
            { 
                Color.FromArgb(64, 50, 147, 226), 
                Color.FromArgb(64, 58, 212, 107), 
                Color.FromArgb(64, 250, 203, 42), 
                Color.FromArgb(64, 255, 129, 50), 
                Color.FromArgb(64, 132, 58, 83)
            };

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

        private void colormodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.colorMode = (ColorMode)colormodeComboBox.SelectedIndex;
            VisualizeVortexMath(multiplier, modulo);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Bitmap Image (.bmp)|*.bmp|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using(Bitmap bitmap = new Bitmap(canvas.Width, canvas.Height))
                    {
                        canvas.DrawToBitmap(bitmap, new Rectangle(0, 0, canvas.Width, canvas.Height));

                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1:
                                bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                                break;
                            case 2:
                                bitmap.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                                break;
                            case 3:
                                bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                                break;
                            default:
                                // Inform user that the file format selected is unsupported
                                break;
                        }
                    }
                }
            }
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

            graphics.DrawEllipse(new Pen(Brushes.Black), initialCircle);

            foreach (Utilities.Point point in points)
            {
                float pointX = point.GetX();
                float pointY = point.GetY();
                Rectangle yellowCircle = new Rectangle((int)pointX - yellowCircleDimensions / 2, (int)pointY - yellowCircleDimensions / 2, yellowCircleDimensions, yellowCircleDimensions);

                graphics.FillEllipse(Brushes.Yellow, yellowCircle);
            }

            Pen linePen = null;
            if (colorMode.Equals(ColorMode.None)) linePen = new Pen(Color.FromArgb(64, 0, 0, 0), this.penLineWidth);

            foreach (int[] loop in loops)
            {
                if (loop.Length <= 1) continue;

                if (colorMode.Equals(ColorMode.LoopGroup))
                {
                    Random random = new Random((int)DateTime.Now.Ticks);
                    int r = random.Next(256);
                    int g = random.Next(256);
                    int b = random.Next(256);
                    linePen = new Pen(Color.FromArgb(64, r, g, b), this.penLineWidth);
                }

                for (int i = 0; i < loop.Length; i++)
                {
                    Utilities.Point from = points[loop[i]];

                    int toIndex;
                    if (i < loop.Length - 1) toIndex = loop[i + 1];
                    else toIndex = loop[0];

                    Utilities.Point to = points[toIndex];

                    if (colorMode.Equals(ColorMode.LineLength))
                    {
                        float lineLength = Utilities.Utils.Distance(from, to);
                        float percentage = (lineLength / (2 * this.radius));
                        int colorIndex = (int)Math.Round((1 - percentage) * (LineLengthColors.Length - 1));
                        Color lineColor = LineLengthColors[colorIndex];

                        linePen = new Pen(lineColor, this.penLineWidth);
                    }

                    graphics.DrawLine(linePen, from.GetX(), from.GetY(), to.GetX(), to.GetY());
                }
            }

            this.canvas.Invalidate();
        }
    }
}