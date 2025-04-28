namespace BrandonHines_Lab3_StateDatabase
{
    partial class StateDetailsForm
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
            this.lstStateDetails = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewAllStates = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lstStateDetails
            // 
            this.lstStateDetails.FormattingEnabled = true;
            this.lstStateDetails.ItemHeight = 19;
            this.lstStateDetails.Location = new System.Drawing.Point(178, 13);
            this.lstStateDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstStateDetails.Name = "lstStateDetails";
            this.lstStateDetails.Size = new System.Drawing.Size(626, 346);
            this.lstStateDetails.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lstStateDetails, "Chosen state\'s details");
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(715, 423);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 53);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exits");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(434, 423);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 53);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "&Back";
            this.toolTip1.SetToolTip(this.btnBack, "Go back");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewAllStates
            // 
            this.btnViewAllStates.Location = new System.Drawing.Point(133, 403);
            this.btnViewAllStates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewAllStates.Name = "btnViewAllStates";
            this.btnViewAllStates.Size = new System.Drawing.Size(170, 93);
            this.btnViewAllStates.TabIndex = 2;
            this.btnViewAllStates.Text = "&View All States";
            this.toolTip1.SetToolTip(this.btnViewAllStates, "Views entire state table");
            this.btnViewAllStates.UseVisualStyleBackColor = true;
            this.btnViewAllStates.Click += new System.EventHandler(this.btnViewAllStates_Click);
            // 
            // StateDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.btnViewAllStates);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstStateDetails);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StateDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Detailed Info";
            this.Load += new System.EventHandler(this.StateDetailsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStateDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewAllStates;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}