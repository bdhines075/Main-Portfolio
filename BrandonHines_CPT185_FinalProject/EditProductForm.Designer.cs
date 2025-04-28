namespace BrandonHines_CPT185_FinalProject
{
    partial class EditProductForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtListPrice = new System.Windows.Forms.TextBox();
            this.txtModelYear = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtBrandId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblListPrice = new System.Windows.Forms.Label();
            this.lblModYr = new System.Windows.Forms.Label();
            this.lblCatID = new System.Windows.Forms.Label();
            this.lblBrandID = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.chkProductName = new System.Windows.Forms.CheckBox();
            this.chkBrandId = new System.Windows.Forms.CheckBox();
            this.chkCategoryId = new System.Windows.Forms.CheckBox();
            this.chkModelYear = new System.Windows.Forms.CheckBox();
            this.chkListPrice = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Product";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(166, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 36);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "&Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Location = new System.Drawing.Point(19, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 36);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtListPrice
            // 
            this.txtListPrice.Location = new System.Drawing.Point(142, 296);
            this.txtListPrice.Name = "txtListPrice";
            this.txtListPrice.Size = new System.Drawing.Size(100, 27);
            this.txtListPrice.TabIndex = 22;
            // 
            // txtModelYear
            // 
            this.txtModelYear.Location = new System.Drawing.Point(142, 244);
            this.txtModelYear.Name = "txtModelYear";
            this.txtModelYear.Size = new System.Drawing.Size(100, 27);
            this.txtModelYear.TabIndex = 21;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(142, 192);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(100, 27);
            this.txtCategoryId.TabIndex = 20;
            // 
            // txtBrandId
            // 
            this.txtBrandId.Location = new System.Drawing.Point(142, 132);
            this.txtBrandId.Name = "txtBrandId";
            this.txtBrandId.Size = new System.Drawing.Size(100, 27);
            this.txtBrandId.TabIndex = 19;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(142, 76);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 27);
            this.txtProductName.TabIndex = 18;
            // 
            // lblListPrice
            // 
            this.lblListPrice.AutoSize = true;
            this.lblListPrice.Location = new System.Drawing.Point(30, 299);
            this.lblListPrice.Name = "lblListPrice";
            this.lblListPrice.Size = new System.Drawing.Size(84, 19);
            this.lblListPrice.TabIndex = 17;
            this.lblListPrice.Text = "List Price";
            // 
            // lblModYr
            // 
            this.lblModYr.AutoSize = true;
            this.lblModYr.Location = new System.Drawing.Point(30, 247);
            this.lblModYr.Name = "lblModYr";
            this.lblModYr.Size = new System.Drawing.Size(93, 19);
            this.lblModYr.TabIndex = 16;
            this.lblModYr.Text = "Model Year";
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Location = new System.Drawing.Point(21, 192);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(99, 19);
            this.lblCatID.TabIndex = 15;
            this.lblCatID.Text = "Category ID";
            // 
            // lblBrandID
            // 
            this.lblBrandID.AutoSize = true;
            this.lblBrandID.Location = new System.Drawing.Point(21, 132);
            this.lblBrandID.Name = "lblBrandID";
            this.lblBrandID.Size = new System.Drawing.Size(77, 19);
            this.lblBrandID.TabIndex = 14;
            this.lblBrandID.Text = "Brand ID";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(21, 79);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(115, 19);
            this.lblProdName.TabIndex = 13;
            this.lblProdName.Text = "Product Name";
            // 
            // chkProductName
            // 
            this.chkProductName.AutoSize = true;
            this.chkProductName.Location = new System.Drawing.Point(258, 82);
            this.chkProductName.Name = "chkProductName";
            this.chkProductName.Size = new System.Drawing.Size(18, 17);
            this.chkProductName.TabIndex = 25;
            this.chkProductName.UseVisualStyleBackColor = true;
            // 
            // chkBrandId
            // 
            this.chkBrandId.AutoSize = true;
            this.chkBrandId.Location = new System.Drawing.Point(258, 142);
            this.chkBrandId.Name = "chkBrandId";
            this.chkBrandId.Size = new System.Drawing.Size(18, 17);
            this.chkBrandId.TabIndex = 26;
            this.chkBrandId.UseVisualStyleBackColor = true;
            // 
            // chkCategoryId
            // 
            this.chkCategoryId.AutoSize = true;
            this.chkCategoryId.Location = new System.Drawing.Point(258, 197);
            this.chkCategoryId.Name = "chkCategoryId";
            this.chkCategoryId.Size = new System.Drawing.Size(18, 17);
            this.chkCategoryId.TabIndex = 27;
            this.chkCategoryId.UseVisualStyleBackColor = true;
            // 
            // chkModelYear
            // 
            this.chkModelYear.AutoSize = true;
            this.chkModelYear.Location = new System.Drawing.Point(258, 247);
            this.chkModelYear.Name = "chkModelYear";
            this.chkModelYear.Size = new System.Drawing.Size(18, 17);
            this.chkModelYear.TabIndex = 28;
            this.chkModelYear.UseVisualStyleBackColor = true;
            // 
            // chkListPrice
            // 
            this.chkListPrice.AutoSize = true;
            this.chkListPrice.Location = new System.Drawing.Point(258, 296);
            this.chkListPrice.Name = "chkListPrice";
            this.chkListPrice.Size = new System.Drawing.Size(18, 17);
            this.chkListPrice.TabIndex = 29;
            this.chkListPrice.UseVisualStyleBackColor = true;
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(300, 427);
            this.Controls.Add(this.chkListPrice);
            this.Controls.Add(this.chkModelYear);
            this.Controls.Add(this.chkCategoryId);
            this.Controls.Add(this.chkBrandId);
            this.Controls.Add(this.chkProductName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtListPrice);
            this.Controls.Add(this.txtModelYear);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.txtBrandId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblListPrice);
            this.Controls.Add(this.lblModYr);
            this.Controls.Add(this.lblCatID);
            this.Controls.Add(this.lblBrandID);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtListPrice;
        private System.Windows.Forms.TextBox txtModelYear;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtBrandId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblListPrice;
        private System.Windows.Forms.Label lblModYr;
        private System.Windows.Forms.Label lblCatID;
        private System.Windows.Forms.Label lblBrandID;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.CheckBox chkProductName;
        private System.Windows.Forms.CheckBox chkBrandId;
        private System.Windows.Forms.CheckBox chkCategoryId;
        private System.Windows.Forms.CheckBox chkModelYear;
        private System.Windows.Forms.CheckBox chkListPrice;
    }
}