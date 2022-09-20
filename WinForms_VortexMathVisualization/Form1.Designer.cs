namespace WinForms_VortexMathVisualization
{
    partial class VortexMathVisualizerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.multiplierLabel = new System.Windows.Forms.Label();
            this.multiplierTextBox = new System.Windows.Forms.TextBox();
            this.moduloTextBox = new System.Windows.Forms.TextBox();
            this.moduloLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.visualizeButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.canvas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // multiplierLabel
            // 
            this.multiplierLabel.AutoSize = true;
            this.multiplierLabel.Location = new System.Drawing.Point(12, 488);
            this.multiplierLabel.Name = "multiplierLabel";
            this.multiplierLabel.Size = new System.Drawing.Size(51, 13);
            this.multiplierLabel.TabIndex = 2;
            this.multiplierLabel.Text = "Multiplier:";
            // 
            // multiplierTextBox
            // 
            this.multiplierTextBox.Location = new System.Drawing.Point(12, 504);
            this.multiplierTextBox.Name = "multiplierTextBox";
            this.multiplierTextBox.Size = new System.Drawing.Size(100, 20);
            this.multiplierTextBox.TabIndex = 3;
            // 
            // moduloTextBox
            // 
            this.moduloTextBox.Location = new System.Drawing.Point(118, 504);
            this.moduloTextBox.Name = "moduloTextBox";
            this.moduloTextBox.Size = new System.Drawing.Size(100, 20);
            this.moduloTextBox.TabIndex = 5;
            // 
            // moduloLabel
            // 
            this.moduloLabel.AutoSize = true;
            this.moduloLabel.Location = new System.Drawing.Point(118, 488);
            this.moduloLabel.Name = "moduloLabel";
            this.moduloLabel.Size = new System.Drawing.Size(45, 13);
            this.moduloLabel.TabIndex = 4;
            this.moduloLabel.Text = "Modulo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // visualizeButton
            // 
            this.visualizeButton.Location = new System.Drawing.Point(371, 488);
            this.visualizeButton.Name = "visualizeButton";
            this.visualizeButton.Size = new System.Drawing.Size(101, 36);
            this.visualizeButton.TabIndex = 7;
            this.visualizeButton.Text = "Visualize";
            this.visualizeButton.UseVisualStyleBackColor = true;
            this.visualizeButton.Click += new System.EventHandler(this.visualizeButton_Click);
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(460, 460);
            this.canvas.TabIndex = 8;
            // 
            // VortexMathVisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 536);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.visualizeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moduloTextBox);
            this.Controls.Add(this.moduloLabel);
            this.Controls.Add(this.multiplierTextBox);
            this.Controls.Add(this.multiplierLabel);
            this.MaximizeBox = false;
            this.Name = "VortexMathVisualizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vortex Math Visualizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label multiplierLabel;
        private System.Windows.Forms.TextBox multiplierTextBox;
        private System.Windows.Forms.TextBox moduloTextBox;
        private System.Windows.Forms.Label moduloLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button visualizeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel canvas;
    }
}

