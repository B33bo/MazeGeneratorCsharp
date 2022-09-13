namespace MazeGeneratorUI
{
    partial class Advanced
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
            this.lineColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pathColor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Seeded = new System.Windows.Forms.CheckBox();
            this.seedNumber = new System.Windows.Forms.NumericUpDown();
            this.ReseedButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lineColor
            // 
            this.lineColor.BackColor = System.Drawing.Color.Black;
            this.lineColor.Location = new System.Drawing.Point(12, 12);
            this.lineColor.Name = "lineColor";
            this.lineColor.Size = new System.Drawing.Size(50, 50);
            this.lineColor.TabIndex = 0;
            this.lineColor.TabStop = false;
            this.lineColor.Click += new System.EventHandler(this.ChangeLineColor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Line Color";
            // 
            // pathColor
            // 
            this.pathColor.BackColor = System.Drawing.Color.White;
            this.pathColor.Location = new System.Drawing.Point(12, 68);
            this.pathColor.Name = "pathColor";
            this.pathColor.Size = new System.Drawing.Size(50, 50);
            this.pathColor.TabIndex = 0;
            this.pathColor.TabStop = false;
            this.pathColor.Click += new System.EventHandler(this.ChangePathColor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(68, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path Color";
            // 
            // Seeded
            // 
            this.Seeded.AutoSize = true;
            this.Seeded.FlatAppearance.BorderSize = 5;
            this.Seeded.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Seeded.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Seeded.Location = new System.Drawing.Point(12, 124);
            this.Seeded.Name = "Seeded";
            this.Seeded.Size = new System.Drawing.Size(136, 23);
            this.Seeded.TabIndex = 2;
            this.Seeded.Text = "Use Custom Seed";
            this.Seeded.UseVisualStyleBackColor = true;
            this.Seeded.CheckedChanged += new System.EventHandler(this.UseCustomSeedChanged);
            // 
            // seedNumber
            // 
            this.seedNumber.Location = new System.Drawing.Point(12, 153);
            this.seedNumber.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seedNumber.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.seedNumber.Name = "seedNumber";
            this.seedNumber.Size = new System.Drawing.Size(120, 23);
            this.seedNumber.TabIndex = 3;
            this.seedNumber.ValueChanged += new System.EventHandler(this.SeedChange);
            // 
            // ReseedButton
            // 
            this.ReseedButton.Location = new System.Drawing.Point(152, 153);
            this.ReseedButton.Name = "ReseedButton";
            this.ReseedButton.Size = new System.Drawing.Size(75, 23);
            this.ReseedButton.TabIndex = 4;
            this.ReseedButton.Text = "Reseed";
            this.ReseedButton.UseVisualStyleBackColor = true;
            this.ReseedButton.Click += new System.EventHandler(this.Reseed);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(12, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CloseAdvanced);
            // 
            // Advanced
            // 
            this.AccessibleDescription = "Window for advanced options";
            this.AccessibleName = "Advanced";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(238, 219);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ReseedButton);
            this.Controls.Add(this.seedNumber);
            this.Controls.Add(this.Seeded);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Advanced";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Advanced";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Advanced_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lineColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pathColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Seeded;
        private System.Windows.Forms.NumericUpDown seedNumber;
        private System.Windows.Forms.Button ReseedButton;
        private System.Windows.Forms.Button button2;
    }
}