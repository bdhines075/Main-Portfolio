namespace BrandonHines_CPT185_FinalProject
{
    partial class EditOrderForm
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
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.txtStoreId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCustomerId = new System.Windows.Forms.CheckBox();
            this.chkOrderStatus = new System.Windows.Forms.CheckBox();
            this.chkOrderDate = new System.Windows.Forms.CheckBox();
            this.chkRequiredDate = new System.Windows.Forms.CheckBox();
            this.chkShippedDate = new System.Windows.Forms.CheckBox();
            this.chkStoreId = new System.Windows.Forms.CheckBox();
            this.chkStaffId = new System.Windows.Forms.CheckBox();
            this.cboOrderStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Orders";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(142, 420);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(100, 27);
            this.txtStaffId.TabIndex = 33;
            // 
            // txtStoreId
            // 
            this.txtStoreId.Location = new System.Drawing.Point(142, 376);
            this.txtStoreId.Name = "txtStoreId";
            this.txtStoreId.Size = new System.Drawing.Size(100, 27);
            this.txtStoreId.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Staff ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Choose Required Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Choose Shipped Date";
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Location = new System.Drawing.Point(12, 266);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(272, 27);
            this.dtpRequiredDate.TabIndex = 28;
            this.dtpRequiredDate.Value = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Location = new System.Drawing.Point(12, 330);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(272, 27);
            this.dtpShippedDate.TabIndex = 27;
            this.dtpShippedDate.Value = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Store ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Order Status";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(142, 90);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 27);
            this.txtCustomerId.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(198, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 43);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(26, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 43);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Choose Order Date";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(12, 202);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(272, 27);
            this.dtpOrderDate.TabIndex = 19;
            this.dtpOrderDate.Value = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer ID";
            // 
            // chkCustomerId
            // 
            this.chkCustomerId.AutoSize = true;
            this.chkCustomerId.Location = new System.Drawing.Point(309, 95);
            this.chkCustomerId.Name = "chkCustomerId";
            this.chkCustomerId.Size = new System.Drawing.Size(18, 17);
            this.chkCustomerId.TabIndex = 34;
            this.chkCustomerId.UseVisualStyleBackColor = true;
            // 
            // chkOrderStatus
            // 
            this.chkOrderStatus.AutoSize = true;
            this.chkOrderStatus.Location = new System.Drawing.Point(309, 145);
            this.chkOrderStatus.Name = "chkOrderStatus";
            this.chkOrderStatus.Size = new System.Drawing.Size(18, 17);
            this.chkOrderStatus.TabIndex = 35;
            this.chkOrderStatus.UseVisualStyleBackColor = true;
            // 
            // chkOrderDate
            // 
            this.chkOrderDate.AutoSize = true;
            this.chkOrderDate.Location = new System.Drawing.Point(309, 210);
            this.chkOrderDate.Name = "chkOrderDate";
            this.chkOrderDate.Size = new System.Drawing.Size(18, 17);
            this.chkOrderDate.TabIndex = 36;
            this.chkOrderDate.UseVisualStyleBackColor = true;
            // 
            // chkRequiredDate
            // 
            this.chkRequiredDate.AutoSize = true;
            this.chkRequiredDate.Location = new System.Drawing.Point(309, 266);
            this.chkRequiredDate.Name = "chkRequiredDate";
            this.chkRequiredDate.Size = new System.Drawing.Size(18, 17);
            this.chkRequiredDate.TabIndex = 37;
            this.chkRequiredDate.UseVisualStyleBackColor = true;
            // 
            // chkShippedDate
            // 
            this.chkShippedDate.AutoSize = true;
            this.chkShippedDate.Location = new System.Drawing.Point(309, 330);
            this.chkShippedDate.Name = "chkShippedDate";
            this.chkShippedDate.Size = new System.Drawing.Size(18, 17);
            this.chkShippedDate.TabIndex = 38;
            this.chkShippedDate.UseVisualStyleBackColor = true;
            // 
            // chkStoreId
            // 
            this.chkStoreId.AutoSize = true;
            this.chkStoreId.Location = new System.Drawing.Point(309, 381);
            this.chkStoreId.Name = "chkStoreId";
            this.chkStoreId.Size = new System.Drawing.Size(18, 17);
            this.chkStoreId.TabIndex = 39;
            this.chkStoreId.UseVisualStyleBackColor = true;
            // 
            // chkStaffId
            // 
            this.chkStaffId.AutoSize = true;
            this.chkStaffId.Location = new System.Drawing.Point(309, 425);
            this.chkStaffId.Name = "chkStaffId";
            this.chkStaffId.Size = new System.Drawing.Size(18, 17);
            this.chkStaffId.TabIndex = 40;
            this.chkStaffId.UseVisualStyleBackColor = true;
            // 
            // cboOrderStatus
            // 
            this.cboOrderStatus.FormattingEnabled = true;
            this.cboOrderStatus.Location = new System.Drawing.Point(142, 135);
            this.cboOrderStatus.Name = "cboOrderStatus";
            this.cboOrderStatus.Size = new System.Drawing.Size(121, 27);
            this.cboOrderStatus.TabIndex = 41;
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 534);
            this.Controls.Add(this.cboOrderStatus);
            this.Controls.Add(this.chkStaffId);
            this.Controls.Add(this.chkStoreId);
            this.Controls.Add(this.chkShippedDate);
            this.Controls.Add(this.chkRequiredDate);
            this.Controls.Add(this.chkOrderDate);
            this.Controls.Add(this.chkOrderStatus);
            this.Controls.Add(this.chkCustomerId);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.txtStoreId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.dtpShippedDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtStoreId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCustomerId;
        private System.Windows.Forms.CheckBox chkOrderStatus;
        private System.Windows.Forms.CheckBox chkOrderDate;
        private System.Windows.Forms.CheckBox chkRequiredDate;
        private System.Windows.Forms.CheckBox chkShippedDate;
        private System.Windows.Forms.CheckBox chkStoreId;
        private System.Windows.Forms.CheckBox chkStaffId;
        private System.Windows.Forms.ComboBox cboOrderStatus;
    }
}