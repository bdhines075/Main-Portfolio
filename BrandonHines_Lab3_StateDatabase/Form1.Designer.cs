namespace BrandonHines_Lab3_StateDatabase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboxStates = new System.Windows.Forms.ComboBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewAllStates = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboxStates
            // 
            this.comboxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxStates.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboxStates.FormattingEnabled = true;
            this.comboxStates.Location = new System.Drawing.Point(199, 90);
            this.comboxStates.Margin = new System.Windows.Forms.Padding(4);
            this.comboxStates.MaxDropDownItems = 10;
            this.comboxStates.Name = "comboxStates";
            this.comboxStates.Size = new System.Drawing.Size(150, 27);
            this.comboxStates.Sorted = true;
            this.comboxStates.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboxStates, "Select a state to view its details");
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInstruction.Location = new System.Drawing.Point(170, 9);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(553, 59);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Please Choose a state from the list then press \"Select\" to view its details, \r\nor" +
    " view the entire table via the\r\n \"View All States\" button.";
            this.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(48, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 54);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exits");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewAllStates
            // 
            this.btnViewAllStates.Location = new System.Drawing.Point(48, 204);
            this.btnViewAllStates.Name = "btnViewAllStates";
            this.btnViewAllStates.Size = new System.Drawing.Size(112, 52);
            this.btnViewAllStates.TabIndex = 2;
            this.btnViewAllStates.Text = "&View All States";
            this.toolTip1.SetToolTip(this.btnViewAllStates, "View entire state table");
            this.btnViewAllStates.UseVisualStyleBackColor = true;
            this.btnViewAllStates.Click += new System.EventHandler(this.btnViewAllStates_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSelect.FlatAppearance.BorderSize = 2;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(48, 72);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(112, 107);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "&Select";
            this.toolTip1.SetToolTip(this.btnSelect, "Selects chosen state from dropdown then displays details");
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 313);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(870, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnViewAllStates);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.comboxStates);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Info Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxStates;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewAllStates;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

