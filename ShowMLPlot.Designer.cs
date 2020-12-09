namespace ShowMATLABImage
{
    partial class ShowMLPlot
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
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.nudGridSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGraph
            // 
            this.pbGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGraph.Location = new System.Drawing.Point(12, 12);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(720, 426);
            this.pbGraph.TabIndex = 0;
            this.pbGraph.TabStop = false;
            // 
            // nudGridSize
            // 
            this.nudGridSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGridSize.Location = new System.Drawing.Point(738, 12);
            this.nudGridSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGridSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudGridSize.Name = "nudGridSize";
            this.nudGridSize.Size = new System.Drawing.Size(50, 20);
            this.nudGridSize.TabIndex = 1;
            this.nudGridSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGridSize.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ShowMLPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudGridSize);
            this.Controls.Add(this.pbGraph);
            this.Name = "ShowMLPlot";
            this.Text = "Show MATLAB Plot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.NumericUpDown nudGridSize;
    }
}

