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
            this.visualizeButton = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colormodeComboBox = new System.Windows.Forms.ComboBox();
            this.linewidthComboBox = new System.Windows.Forms.ComboBox();
            this.colormodeLabel = new System.Windows.Forms.Label();
            this.linewidthLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiplierLabel
            // 
            this.multiplierLabel.AutoSize = true;
            this.multiplierLabel.Location = new System.Drawing.Point(12, 12);
            this.multiplierLabel.Name = "multiplierLabel";
            this.multiplierLabel.Size = new System.Drawing.Size(51, 13);
            this.multiplierLabel.TabIndex = 2;
            this.multiplierLabel.Text = "Multiplier:";
            // 
            // multiplierTextBox
            // 
            this.multiplierTextBox.Location = new System.Drawing.Point(12, 28);
            this.multiplierTextBox.Name = "multiplierTextBox";
            this.multiplierTextBox.Size = new System.Drawing.Size(100, 20);
            this.multiplierTextBox.TabIndex = 3;
            // 
            // moduloTextBox
            // 
            this.moduloTextBox.Location = new System.Drawing.Point(118, 28);
            this.moduloTextBox.Name = "moduloTextBox";
            this.moduloTextBox.Size = new System.Drawing.Size(100, 20);
            this.moduloTextBox.TabIndex = 5;
            // 
            // moduloLabel
            // 
            this.moduloLabel.AutoSize = true;
            this.moduloLabel.Location = new System.Drawing.Point(118, 12);
            this.moduloLabel.Name = "moduloLabel";
            this.moduloLabel.Size = new System.Drawing.Size(45, 13);
            this.moduloLabel.TabIndex = 4;
            this.moduloLabel.Text = "Modulo:";
            // 
            // visualizeButton
            // 
            this.visualizeButton.Location = new System.Drawing.Point(621, 12);
            this.visualizeButton.Name = "visualizeButton";
            this.visualizeButton.Size = new System.Drawing.Size(101, 36);
            this.visualizeButton.TabIndex = 7;
            this.visualizeButton.Text = "Visualize";
            this.visualizeButton.UseVisualStyleBackColor = true;
            this.visualizeButton.Click += new System.EventHandler(this.visualizeButton_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(12, 95);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(710, 710);
            this.canvas.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.linewidthLabel);
            this.panel1.Controls.Add(this.colormodeLabel);
            this.panel1.Controls.Add(this.linewidthComboBox);
            this.panel1.Controls.Add(this.colormodeComboBox);
            this.panel1.Controls.Add(this.multiplierTextBox);
            this.panel1.Controls.Add(this.visualizeButton);
            this.panel1.Controls.Add(this.multiplierLabel);
            this.panel1.Controls.Add(this.moduloTextBox);
            this.panel1.Controls.Add(this.moduloLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 58);
            this.panel1.TabIndex = 9;
            // 
            // colormodeComboBox
            // 
            this.colormodeComboBox.FormattingEnabled = true;
            this.colormodeComboBox.Items.AddRange(new object[] {
            "None",
            "Loop Group"});
            this.colormodeComboBox.Location = new System.Drawing.Point(225, 28);
            this.colormodeComboBox.Name = "colormodeComboBox";
            this.colormodeComboBox.Size = new System.Drawing.Size(121, 21);
            this.colormodeComboBox.TabIndex = 8;
            // 
            // linewidthComboBox
            // 
            this.linewidthComboBox.FormattingEnabled = true;
            this.linewidthComboBox.Items.AddRange(new object[] {
            "0.125px",
            "0.25px",
            "0.5px",
            "1px",
            "2px",
            "4px"});
            this.linewidthComboBox.Location = new System.Drawing.Point(352, 28);
            this.linewidthComboBox.Name = "linewidthComboBox";
            this.linewidthComboBox.Size = new System.Drawing.Size(121, 21);
            this.linewidthComboBox.TabIndex = 9;
            // 
            // colormodeLabel
            // 
            this.colormodeLabel.AutoSize = true;
            this.colormodeLabel.Location = new System.Drawing.Point(225, 11);
            this.colormodeLabel.Name = "colormodeLabel";
            this.colormodeLabel.Size = new System.Drawing.Size(64, 13);
            this.colormodeLabel.TabIndex = 10;
            this.colormodeLabel.Text = "Color Mode:";
            // 
            // linewidthLabel
            // 
            this.linewidthLabel.AutoSize = true;
            this.linewidthLabel.Location = new System.Drawing.Point(352, 12);
            this.linewidthLabel.Name = "linewidthLabel";
            this.linewidthLabel.Size = new System.Drawing.Size(61, 13);
            this.linewidthLabel.TabIndex = 11;
            this.linewidthLabel.Text = "Line Width:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // VortexMathVisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(734, 817);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "VortexMathVisualizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vortex Math Visualizer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label multiplierLabel;
        private System.Windows.Forms.TextBox multiplierTextBox;
        private System.Windows.Forms.TextBox moduloTextBox;
        private System.Windows.Forms.Label moduloLabel;
        private System.Windows.Forms.Button visualizeButton;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label linewidthLabel;
        private System.Windows.Forms.Label colormodeLabel;
        private System.Windows.Forms.ComboBox linewidthComboBox;
        private System.Windows.Forms.ComboBox colormodeComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

