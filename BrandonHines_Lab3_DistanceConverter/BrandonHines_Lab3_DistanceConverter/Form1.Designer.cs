namespace BrandonHines_Lab3_DistanceConverter
{
    partial class Form1
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
            this.txtDist = new System.Windows.Forms.TextBox();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.lstTo = new System.Windows.Forms.ListBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblConvDistLab = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConvDist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDist
            // 
            this.txtDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDist.Location = new System.Drawing.Point(291, 29);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(100, 26);
            this.txtDist.TabIndex = 0;
            // 
            // lstFrom
            // 
            this.lstFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.ItemHeight = 20;
            this.lstFrom.Items.AddRange(new object[] {
            "Feet",
            "Inches",
            "Yards"});
            this.lstFrom.Location = new System.Drawing.Point(12, 140);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.Size = new System.Drawing.Size(72, 62);
            this.lstFrom.TabIndex = 1;
            // 
            // lstTo
            // 
            this.lstTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTo.FormattingEnabled = true;
            this.lstTo.ItemHeight = 20;
            this.lstTo.Items.AddRange(new object[] {
            "Feet",
            "Inches",
            "Yards"});
            this.lstTo.Location = new System.Drawing.Point(225, 140);
            this.lstTo.Name = "lstTo";
            this.lstTo.Size = new System.Drawing.Size(70, 62);
            this.lstTo.TabIndex = 2;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInstruction.Location = new System.Drawing.Point(20, 29);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(255, 22);
            this.lblInstruction.TabIndex = 3;
            this.lblInstruction.Text = "Please enter a distance to convert:";
            // 
            // lblConvDistLab
            // 
            this.lblConvDistLab.AutoSize = true;
            this.lblConvDistLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConvDistLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvDistLab.Location = new System.Drawing.Point(12, 255);
            this.lblConvDistLab.Name = "lblConvDistLab";
            this.lblConvDistLab.Size = new System.Drawing.Size(174, 22);
            this.lblConvDistLab.TabIndex = 4;
            this.lblConvDistLab.Text = "Converted Distance:";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConvert.Font = new System.Drawing.Font("Arial Nova", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(378, 99);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(157, 133);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Font = new System.Drawing.Font("Arial Nova", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(182, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(277, 76);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 99);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(60, 20);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "FROM:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(221, 99);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(34, 20);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "TO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::BrandonHines_Lab3_DistanceConverter.Properties.Resources.icons8_right_arrow_64;
            this.pictureBox1.Location = new System.Drawing.Point(114, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 84);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblConvDist
            // 
            this.lblConvDist.AutoSize = true;
            this.lblConvDist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConvDist.Location = new System.Drawing.Point(225, 255);
            this.lblConvDist.Name = "lblConvDist";
            this.lblConvDist.Size = new System.Drawing.Size(2, 22);
            this.lblConvDist.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 428);
            this.Controls.Add(this.lblConvDist);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblConvDistLab);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lstTo);
            this.Controls.Add(this.lstFrom);
            this.Controls.Add(this.txtDist);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.ListBox lstTo;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblConvDistLab;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConvDist;
    }
}

