namespace BrandonHines_Lab3_StateDatabase
{
    partial class StateTableForm
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
            this.dgvStates = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largestCitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medianIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compJobsPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesDataSet = new BrandonHines_Lab3_StateDatabase.StatesDataSet();
            this.stateDataTableAdapter = new BrandonHines_Lab3_StateDatabase.StatesDataSetTableAdapters.StateDataTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStates
            // 
            this.dgvStates.AllowUserToOrderColumns = true;
            this.dgvStates.AutoGenerateColumns = false;
            this.dgvStates.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvStates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStates.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.flagDescriptionDataGridViewTextBoxColumn,
            this.flowerDataGridViewTextBoxColumn,
            this.birdDataGridViewTextBoxColumn,
            this.colorsDataGridViewTextBoxColumn,
            this.largestCitiesDataGridViewTextBoxColumn,
            this.capitalDataGridViewTextBoxColumn,
            this.medianIncomeDataGridViewTextBoxColumn,
            this.compJobsPercentDataGridViewTextBoxColumn});
            this.dgvStates.DataSource = this.stateDataBindingSource;
            this.dgvStates.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvStates.Location = new System.Drawing.Point(15, 25);
            this.dgvStates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStates.Name = "dgvStates";
            this.dgvStates.RowHeadersWidth = 51;
            this.dgvStates.RowTemplate.Height = 24;
            this.dgvStates.Size = new System.Drawing.Size(1628, 410);
            this.dgvStates.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgvStates, "State Table");
            this.dgvStates.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStates_ColumnHeaderMouseClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.Width = 125;
            // 
            // flagDescriptionDataGridViewTextBoxColumn
            // 
            this.flagDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FlagDescription";
            this.flagDescriptionDataGridViewTextBoxColumn.HeaderText = "FlagDescription";
            this.flagDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flagDescriptionDataGridViewTextBoxColumn.Name = "flagDescriptionDataGridViewTextBoxColumn";
            this.flagDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // flowerDataGridViewTextBoxColumn
            // 
            this.flowerDataGridViewTextBoxColumn.DataPropertyName = "Flower";
            this.flowerDataGridViewTextBoxColumn.HeaderText = "Flower";
            this.flowerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flowerDataGridViewTextBoxColumn.Name = "flowerDataGridViewTextBoxColumn";
            this.flowerDataGridViewTextBoxColumn.Width = 125;
            // 
            // birdDataGridViewTextBoxColumn
            // 
            this.birdDataGridViewTextBoxColumn.DataPropertyName = "Bird";
            this.birdDataGridViewTextBoxColumn.HeaderText = "Bird";
            this.birdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birdDataGridViewTextBoxColumn.Name = "birdDataGridViewTextBoxColumn";
            this.birdDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorsDataGridViewTextBoxColumn
            // 
            this.colorsDataGridViewTextBoxColumn.DataPropertyName = "Colors";
            this.colorsDataGridViewTextBoxColumn.HeaderText = "Colors";
            this.colorsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorsDataGridViewTextBoxColumn.Name = "colorsDataGridViewTextBoxColumn";
            this.colorsDataGridViewTextBoxColumn.Width = 125;
            // 
            // largestCitiesDataGridViewTextBoxColumn
            // 
            this.largestCitiesDataGridViewTextBoxColumn.DataPropertyName = "LargestCities";
            this.largestCitiesDataGridViewTextBoxColumn.HeaderText = "LargestCities";
            this.largestCitiesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.largestCitiesDataGridViewTextBoxColumn.Name = "largestCitiesDataGridViewTextBoxColumn";
            this.largestCitiesDataGridViewTextBoxColumn.Width = 125;
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            this.capitalDataGridViewTextBoxColumn.DataPropertyName = "Capital";
            this.capitalDataGridViewTextBoxColumn.HeaderText = "Capital";
            this.capitalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            this.capitalDataGridViewTextBoxColumn.Width = 125;
            // 
            // medianIncomeDataGridViewTextBoxColumn
            // 
            this.medianIncomeDataGridViewTextBoxColumn.DataPropertyName = "MedianIncome";
            this.medianIncomeDataGridViewTextBoxColumn.HeaderText = "MedianIncome";
            this.medianIncomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medianIncomeDataGridViewTextBoxColumn.Name = "medianIncomeDataGridViewTextBoxColumn";
            this.medianIncomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // compJobsPercentDataGridViewTextBoxColumn
            // 
            this.compJobsPercentDataGridViewTextBoxColumn.DataPropertyName = "CompJobsPercent";
            this.compJobsPercentDataGridViewTextBoxColumn.HeaderText = "CompJobsPercent";
            this.compJobsPercentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compJobsPercentDataGridViewTextBoxColumn.Name = "compJobsPercentDataGridViewTextBoxColumn";
            this.compJobsPercentDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataBindingSource
            // 
            this.stateDataBindingSource.DataMember = "StateData";
            this.stateDataBindingSource.DataSource = this.statesDataSet;
            // 
            // statesDataSet
            // 
            this.statesDataSet.DataSetName = "StatesDataSet";
            this.statesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateDataTableAdapter
            // 
            this.stateDataTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(554, 456);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 48);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exits");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(908, 456);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 48);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "&Back";
            this.toolTip1.SetToolTip(this.btnBack, "Go back");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StateTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1202, 559);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvStates);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StateTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Full State Table";
            this.Load += new System.EventHandler(this.StateTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStates;
        private StatesDataSet statesDataSet;
        private System.Windows.Forms.BindingSource stateDataBindingSource;
        private StatesDataSetTableAdapters.StateDataTableAdapter stateDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn largestCitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medianIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compJobsPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}