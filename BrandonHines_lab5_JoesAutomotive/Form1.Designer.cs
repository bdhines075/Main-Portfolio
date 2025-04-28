namespace BrandonHines_lab5_JoesAutomotive
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
            this.gbxOilAndLube = new System.Windows.Forms.GroupBox();
            this.chkLubeJob = new System.Windows.Forms.CheckBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.gbxFlushes = new System.Windows.Forms.GroupBox();
            this.chkTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.chkRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.gbxMiscServices = new System.Windows.Forms.GroupBox();
            this.chkTireRotation = new System.Windows.Forms.CheckBox();
            this.chkReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.gbxPartsAndLabor = new System.Windows.Forms.GroupBox();
            this.lblLabor = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.gbxSummary = new System.Windows.Forms.GroupBox();
            this.txtTotalFees = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtPartsSummary = new System.Windows.Forms.TextBox();
            this.txtServiceAndLabor = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblPartsSumm = new System.Windows.Forms.Label();
            this.lblServiceAndLabor = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxOilAndLube.SuspendLayout();
            this.gbxFlushes.SuspendLayout();
            this.gbxMiscServices.SuspendLayout();
            this.gbxPartsAndLabor.SuspendLayout();
            this.gbxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOilAndLube
            // 
            this.gbxOilAndLube.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxOilAndLube.Controls.Add(this.chkLubeJob);
            this.gbxOilAndLube.Controls.Add(this.chkOilChange);
            this.gbxOilAndLube.Location = new System.Drawing.Point(26, 74);
            this.gbxOilAndLube.Name = "gbxOilAndLube";
            this.gbxOilAndLube.Size = new System.Drawing.Size(265, 115);
            this.gbxOilAndLube.TabIndex = 0;
            this.gbxOilAndLube.TabStop = false;
            this.gbxOilAndLube.Text = "Oil and Lube";
            this.toolTip1.SetToolTip(this.gbxOilAndLube, "please select which if any oil and lub services are needed");
            // 
            // chkLubeJob
            // 
            this.chkLubeJob.AutoSize = true;
            this.chkLubeJob.Location = new System.Drawing.Point(7, 64);
            this.chkLubeJob.Name = "chkLubeJob";
            this.chkLubeJob.Size = new System.Drawing.Size(188, 27);
            this.chkLubeJob.TabIndex = 1;
            this.chkLubeJob.Text = "Lube Job ($18.00)";
            this.chkLubeJob.UseVisualStyleBackColor = true;
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Location = new System.Drawing.Point(7, 30);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(205, 27);
            this.chkOilChange.TabIndex = 0;
            this.chkOilChange.Text = "Oil Change ($26.00)";
            this.chkOilChange.UseVisualStyleBackColor = true;
            // 
            // gbxFlushes
            // 
            this.gbxFlushes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxFlushes.Controls.Add(this.chkTransmissionFlush);
            this.gbxFlushes.Controls.Add(this.chkRadiatorFlush);
            this.gbxFlushes.Location = new System.Drawing.Point(365, 74);
            this.gbxFlushes.Name = "gbxFlushes";
            this.gbxFlushes.Size = new System.Drawing.Size(316, 115);
            this.gbxFlushes.TabIndex = 1;
            this.gbxFlushes.TabStop = false;
            this.gbxFlushes.Text = "Flushes";
            this.toolTip1.SetToolTip(this.gbxFlushes, "please select which if any flushes are needed");
            // 
            // chkTransmissionFlush
            // 
            this.chkTransmissionFlush.AutoSize = true;
            this.chkTransmissionFlush.Location = new System.Drawing.Point(18, 63);
            this.chkTransmissionFlush.Name = "chkTransmissionFlush";
            this.chkTransmissionFlush.Size = new System.Drawing.Size(268, 27);
            this.chkTransmissionFlush.TabIndex = 1;
            this.chkTransmissionFlush.Text = "Transmission Flush ($80.00)";
            this.chkTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // chkRadiatorFlush
            // 
            this.chkRadiatorFlush.AutoSize = true;
            this.chkRadiatorFlush.Location = new System.Drawing.Point(18, 30);
            this.chkRadiatorFlush.Name = "chkRadiatorFlush";
            this.chkRadiatorFlush.Size = new System.Drawing.Size(233, 27);
            this.chkRadiatorFlush.TabIndex = 0;
            this.chkRadiatorFlush.Text = "Radiator Flush ($30.00)";
            this.chkRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // gbxMiscServices
            // 
            this.gbxMiscServices.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxMiscServices.Controls.Add(this.chkTireRotation);
            this.gbxMiscServices.Controls.Add(this.chkReplaceMuffler);
            this.gbxMiscServices.Controls.Add(this.chkInspection);
            this.gbxMiscServices.Location = new System.Drawing.Point(26, 214);
            this.gbxMiscServices.Name = "gbxMiscServices";
            this.gbxMiscServices.Size = new System.Drawing.Size(265, 164);
            this.gbxMiscServices.TabIndex = 2;
            this.gbxMiscServices.TabStop = false;
            this.gbxMiscServices.Text = "Misc. Services";
            this.toolTip1.SetToolTip(this.gbxMiscServices, "please select which if any miscellaneous services are needed");
            // 
            // chkTireRotation
            // 
            this.chkTireRotation.AutoSize = true;
            this.chkTireRotation.Location = new System.Drawing.Point(7, 124);
            this.chkTireRotation.Name = "chkTireRotation";
            this.chkTireRotation.Size = new System.Drawing.Size(224, 27);
            this.chkTireRotation.TabIndex = 2;
            this.chkTireRotation.Text = "Tire Rotation ($20.00)";
            this.chkTireRotation.UseVisualStyleBackColor = true;
            // 
            // chkReplaceMuffler
            // 
            this.chkReplaceMuffler.AutoSize = true;
            this.chkReplaceMuffler.Location = new System.Drawing.Point(7, 75);
            this.chkReplaceMuffler.Name = "chkReplaceMuffler";
            this.chkReplaceMuffler.Size = new System.Drawing.Size(258, 27);
            this.chkReplaceMuffler.TabIndex = 1;
            this.chkReplaceMuffler.Text = "Replace Muffler ($100.00)";
            this.chkReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(7, 30);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(196, 27);
            this.chkInspection.TabIndex = 0;
            this.chkInspection.Text = "Inspection ($15.00)";
            this.chkInspection.UseVisualStyleBackColor = true;
            // 
            // gbxPartsAndLabor
            // 
            this.gbxPartsAndLabor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxPartsAndLabor.Controls.Add(this.lblLabor);
            this.gbxPartsAndLabor.Controls.Add(this.lblParts);
            this.gbxPartsAndLabor.Controls.Add(this.txtLabor);
            this.gbxPartsAndLabor.Controls.Add(this.txtParts);
            this.gbxPartsAndLabor.Location = new System.Drawing.Point(366, 214);
            this.gbxPartsAndLabor.Name = "gbxPartsAndLabor";
            this.gbxPartsAndLabor.Size = new System.Drawing.Size(316, 164);
            this.gbxPartsAndLabor.TabIndex = 3;
            this.gbxPartsAndLabor.TabStop = false;
            this.gbxPartsAndLabor.Text = "Parts and Labor";
            this.toolTip1.SetToolTip(this.gbxPartsAndLabor, "Please enter price for parts and Labor");
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(27, 110);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(90, 23);
            this.lblLabor.TabIndex = 3;
            this.lblLabor.Text = "Labor ($)";
            this.toolTip1.SetToolTip(this.lblLabor, "Please enter price for Labor");
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(51, 52);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(55, 23);
            this.lblParts.TabIndex = 2;
            this.lblParts.Text = "Parts";
            this.toolTip1.SetToolTip(this.lblParts, "Please enter price for parts");
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(150, 103);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(100, 30);
            this.txtLabor.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtLabor, "Please enter price for Labor");
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(151, 45);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(100, 30);
            this.txtParts.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtParts, "Please enter price for parts");
            // 
            // gbxSummary
            // 
            this.gbxSummary.BackColor = System.Drawing.SystemColors.Menu;
            this.gbxSummary.Controls.Add(this.txtTotalFees);
            this.gbxSummary.Controls.Add(this.txtTax);
            this.gbxSummary.Controls.Add(this.txtPartsSummary);
            this.gbxSummary.Controls.Add(this.txtServiceAndLabor);
            this.gbxSummary.Controls.Add(this.lblTotal);
            this.gbxSummary.Controls.Add(this.lblTax);
            this.gbxSummary.Controls.Add(this.lblPartsSumm);
            this.gbxSummary.Controls.Add(this.lblServiceAndLabor);
            this.gbxSummary.Location = new System.Drawing.Point(33, 394);
            this.gbxSummary.Name = "gbxSummary";
            this.gbxSummary.Size = new System.Drawing.Size(648, 142);
            this.gbxSummary.TabIndex = 4;
            this.gbxSummary.TabStop = false;
            this.gbxSummary.Text = "Summary";
            this.toolTip1.SetToolTip(this.gbxSummary, "summary total");
            // 
            // txtTotalFees
            // 
            this.txtTotalFees.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalFees.Location = new System.Drawing.Point(483, 79);
            this.txtTotalFees.Name = "txtTotalFees";
            this.txtTotalFees.ReadOnly = true;
            this.txtTotalFees.Size = new System.Drawing.Size(100, 30);
            this.txtTotalFees.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtTotalFees, "Grand Total");
            // 
            // txtTax
            // 
            this.txtTax.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTax.Location = new System.Drawing.Point(483, 25);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 30);
            this.txtTax.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtTax, "total amount for tax to be applied");
            // 
            // txtPartsSummary
            // 
            this.txtPartsSummary.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPartsSummary.Location = new System.Drawing.Point(188, 75);
            this.txtPartsSummary.Name = "txtPartsSummary";
            this.txtPartsSummary.ReadOnly = true;
            this.txtPartsSummary.Size = new System.Drawing.Size(100, 30);
            this.txtPartsSummary.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtPartsSummary, "total price for parts");
            // 
            // txtServiceAndLabor
            // 
            this.txtServiceAndLabor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtServiceAndLabor.Location = new System.Drawing.Point(188, 26);
            this.txtServiceAndLabor.Name = "txtServiceAndLabor";
            this.txtServiceAndLabor.ReadOnly = true;
            this.txtServiceAndLabor.Size = new System.Drawing.Size(100, 30);
            this.txtServiceAndLabor.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtServiceAndLabor, "total price for service and labor");
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(333, 79);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(106, 25);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Fees:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Location = new System.Drawing.Point(396, 28);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(43, 25);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax";
            // 
            // lblPartsSumm
            // 
            this.lblPartsSumm.AutoSize = true;
            this.lblPartsSumm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPartsSumm.Location = new System.Drawing.Point(126, 79);
            this.lblPartsSumm.Name = "lblPartsSumm";
            this.lblPartsSumm.Size = new System.Drawing.Size(57, 25);
            this.lblPartsSumm.TabIndex = 1;
            this.lblPartsSumm.Text = "Parts";
            // 
            // lblServiceAndLabor
            // 
            this.lblServiceAndLabor.AutoSize = true;
            this.lblServiceAndLabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServiceAndLabor.Location = new System.Drawing.Point(17, 30);
            this.lblServiceAndLabor.Name = "lblServiceAndLabor";
            this.lblServiceAndLabor.Size = new System.Drawing.Size(166, 25);
            this.lblServiceAndLabor.TabIndex = 0;
            this.lblServiceAndLabor.Text = "Service and Labor";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(33, 560);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 61);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.toolTip1.SetToolTip(this.btnCalculate, "Press to calculate input");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(298, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 61);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C&lear";
            this.toolTip1.SetToolTip(this.btnClear, "press to clear and reset form");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(568, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 61);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "press to close/exit form");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(143, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(508, 36);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Joes Automotive Billing Calculator";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(722, 643);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbxSummary);
            this.Controls.Add(this.gbxPartsAndLabor);
            this.Controls.Add(this.gbxMiscServices);
            this.Controls.Add(this.gbxFlushes);
            this.Controls.Add(this.gbxOilAndLube);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joes Auto ";
            this.gbxOilAndLube.ResumeLayout(false);
            this.gbxOilAndLube.PerformLayout();
            this.gbxFlushes.ResumeLayout(false);
            this.gbxFlushes.PerformLayout();
            this.gbxMiscServices.ResumeLayout(false);
            this.gbxMiscServices.PerformLayout();
            this.gbxPartsAndLabor.ResumeLayout(false);
            this.gbxPartsAndLabor.PerformLayout();
            this.gbxSummary.ResumeLayout(false);
            this.gbxSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOilAndLube;
        private System.Windows.Forms.CheckBox chkLubeJob;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.GroupBox gbxFlushes;
        private System.Windows.Forms.GroupBox gbxMiscServices;
        private System.Windows.Forms.GroupBox gbxPartsAndLabor;
        private System.Windows.Forms.CheckBox chkTransmissionFlush;
        private System.Windows.Forms.CheckBox chkRadiatorFlush;
        private System.Windows.Forms.CheckBox chkTireRotation;
        private System.Windows.Forms.CheckBox chkReplaceMuffler;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.GroupBox gbxSummary;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblPartsSumm;
        private System.Windows.Forms.Label lblServiceAndLabor;
        private System.Windows.Forms.TextBox txtTotalFees;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtPartsSummary;
        private System.Windows.Forms.TextBox txtServiceAndLabor;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTitle;
    }
}

