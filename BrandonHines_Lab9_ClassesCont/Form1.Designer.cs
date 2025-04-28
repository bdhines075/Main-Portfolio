namespace BrandonHines_Lab9_ClassesCont
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnUniversitySuites = new System.Windows.Forms.RadioButton();
            this.rbtnFarthingHall = new System.Windows.Forms.RadioButton();
            this.rbtnAllenHall = new System.Windows.Forms.RadioButton();
            this.rbtnPikeHall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnUnlimitedMeals = new System.Windows.Forms.RadioButton();
            this.rbtn14Meals = new System.Windows.Forms.RadioButton();
            this.rbtn7Meals = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.helpToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dorm and Meal Plan Calculator";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.rbtnUniversitySuites);
            this.groupBox1.Controls.Add(this.rbtnFarthingHall);
            this.groupBox1.Controls.Add(this.rbtnAllenHall);
            this.groupBox1.Controls.Add(this.rbtnPikeHall);
            this.groupBox1.Location = new System.Drawing.Point(24, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dormitory";
            // 
            // rbtnUniversitySuites
            // 
            this.rbtnUniversitySuites.AutoSize = true;
            this.rbtnUniversitySuites.Location = new System.Drawing.Point(7, 114);
            this.rbtnUniversitySuites.Name = "rbtnUniversitySuites";
            this.rbtnUniversitySuites.Size = new System.Drawing.Size(157, 23);
            this.rbtnUniversitySuites.TabIndex = 3;
            this.rbtnUniversitySuites.TabStop = true;
            this.rbtnUniversitySuites.Text = "University Suites";
            this.rbtnUniversitySuites.UseVisualStyleBackColor = true;
            // 
            // rbtnFarthingHall
            // 
            this.rbtnFarthingHall.AutoSize = true;
            this.rbtnFarthingHall.Location = new System.Drawing.Point(7, 85);
            this.rbtnFarthingHall.Name = "rbtnFarthingHall";
            this.rbtnFarthingHall.Size = new System.Drawing.Size(133, 23);
            this.rbtnFarthingHall.TabIndex = 2;
            this.rbtnFarthingHall.TabStop = true;
            this.rbtnFarthingHall.Text = "Farthing Hall";
            this.rbtnFarthingHall.UseVisualStyleBackColor = true;
            // 
            // rbtnAllenHall
            // 
            this.rbtnAllenHall.AutoSize = true;
            this.rbtnAllenHall.Location = new System.Drawing.Point(7, 56);
            this.rbtnAllenHall.Name = "rbtnAllenHall";
            this.rbtnAllenHall.Size = new System.Drawing.Size(107, 23);
            this.rbtnAllenHall.TabIndex = 1;
            this.rbtnAllenHall.TabStop = true;
            this.rbtnAllenHall.Text = "Allen Hall";
            this.rbtnAllenHall.UseVisualStyleBackColor = true;
            // 
            // rbtnPikeHall
            // 
            this.rbtnPikeHall.AutoSize = true;
            this.rbtnPikeHall.Location = new System.Drawing.Point(7, 27);
            this.rbtnPikeHall.Name = "rbtnPikeHall";
            this.rbtnPikeHall.Size = new System.Drawing.Size(101, 23);
            this.rbtnPikeHall.TabIndex = 0;
            this.rbtnPikeHall.TabStop = true;
            this.rbtnPikeHall.Text = "Pike Hall";
            this.rbtnPikeHall.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.rbtnUnlimitedMeals);
            this.groupBox2.Controls.Add(this.rbtn14Meals);
            this.groupBox2.Controls.Add(this.rbtn7Meals);
            this.groupBox2.Location = new System.Drawing.Point(369, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meal Plan";
            // 
            // rbtnUnlimitedMeals
            // 
            this.rbtnUnlimitedMeals.AutoSize = true;
            this.rbtnUnlimitedMeals.Location = new System.Drawing.Point(7, 105);
            this.rbtnUnlimitedMeals.Name = "rbtnUnlimitedMeals";
            this.rbtnUnlimitedMeals.Size = new System.Drawing.Size(155, 23);
            this.rbtnUnlimitedMeals.TabIndex = 2;
            this.rbtnUnlimitedMeals.TabStop = true;
            this.rbtnUnlimitedMeals.Text = "Unlimited Meals";
            this.rbtnUnlimitedMeals.UseVisualStyleBackColor = true;
            // 
            // rbtn14Meals
            // 
            this.rbtn14Meals.AutoSize = true;
            this.rbtn14Meals.Location = new System.Drawing.Point(7, 66);
            this.rbtn14Meals.Name = "rbtn14Meals";
            this.rbtn14Meals.Size = new System.Drawing.Size(142, 23);
            this.rbtn14Meals.TabIndex = 1;
            this.rbtn14Meals.TabStop = true;
            this.rbtn14Meals.Text = "14 Meals/Week";
            this.rbtn14Meals.UseVisualStyleBackColor = true;
            // 
            // rbtn7Meals
            // 
            this.rbtn7Meals.AutoSize = true;
            this.rbtn7Meals.Location = new System.Drawing.Point(7, 27);
            this.rbtn7Meals.Name = "rbtn7Meals";
            this.rbtn7Meals.Size = new System.Drawing.Size(133, 23);
            this.rbtn7Meals.TabIndex = 0;
            this.rbtn7Meals.TabStop = true;
            this.rbtn7Meals.Text = "7 Meals/Week";
            this.rbtn7Meals.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(259, 303);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 46);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "&Next Form";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(46, 303);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 46);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(481, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 46);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.helpToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(619, 28);
            this.helpToolStripMenuItem.TabIndex = 6;
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(619, 433);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helpToolStripMenuItem);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.helpToolStripMenuItem;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dorm/Meal Plan Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.helpToolStripMenuItem.ResumeLayout(false);
            this.helpToolStripMenuItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnUniversitySuites;
        private System.Windows.Forms.RadioButton rbtnFarthingHall;
        private System.Windows.Forms.RadioButton rbtnAllenHall;
        private System.Windows.Forms.RadioButton rbtnPikeHall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnUnlimitedMeals;
        private System.Windows.Forms.RadioButton rbtn14Meals;
        private System.Windows.Forms.RadioButton rbtn7Meals;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

