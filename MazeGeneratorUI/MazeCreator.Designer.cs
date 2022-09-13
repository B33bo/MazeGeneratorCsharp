namespace MazeGeneratorUI
{
    partial class MazeCreator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeCreator));
            this.button1 = new System.Windows.Forms.Button();
            this.WidthValue = new System.Windows.Forms.NumericUpDown();
            this.HeightValue = new System.Windows.Forms.NumericUpDown();
            this.dimensionX = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(125, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateButtonClick);
            // 
            // WidthValue
            // 
            this.WidthValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WidthValue.BackColor = System.Drawing.SystemColors.Window;
            this.WidthValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WidthValue.Location = new System.Drawing.Point(138, 350);
            this.WidthValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.WidthValue.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.WidthValue.Name = "WidthValue";
            this.WidthValue.Size = new System.Drawing.Size(71, 23);
            this.WidthValue.TabIndex = 1;
            this.WidthValue.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // HeightValue
            // 
            this.HeightValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightValue.BackColor = System.Drawing.SystemColors.Window;
            this.HeightValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HeightValue.Location = new System.Drawing.Point(241, 350);
            this.HeightValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HeightValue.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(71, 23);
            this.HeightValue.TabIndex = 2;
            this.HeightValue.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // dimensionX
            // 
            this.dimensionX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dimensionX.AutoSize = true;
            this.dimensionX.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dimensionX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dimensionX.Location = new System.Drawing.Point(215, 350);
            this.dimensionX.Name = "dimensionX";
            this.dimensionX.Size = new System.Drawing.Size(20, 25);
            this.dimensionX.TabIndex = 3;
            this.dimensionX.Text = "x";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(125, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Save To File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveImage);
            // 
            // preview
            // 
            this.preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preview.Image = global::MazeGeneratorUI.Properties.Resources.temp;
            this.preview.Location = new System.Drawing.Point(75, 12);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(300, 300);
            this.preview.TabIndex = 4;
            this.preview.TabStop = false;
            this.preview.Paint += new System.Windows.Forms.PaintEventHandler(this.MazePaint);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(125, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "Advanced";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AdvancedOpen);
            // 
            // MazeCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.dimensionX);
            this.Controls.Add(this.HeightValue);
            this.Controls.Add(this.WidthValue);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MazeCreator";
            this.Text = "Maze Generator";
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown WidthValue;
        private System.Windows.Forms.NumericUpDown HeightValue;
        private System.Windows.Forms.Label dimensionX;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Button button3;
    }
}
