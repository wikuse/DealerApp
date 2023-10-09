namespace DealerApp
{
    partial class frmDealer
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
            this.btnAddDealer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.dtgDealers = new System.Windows.Forms.DataGridView();
            this.carDealershipDataSet = new DealerApp.CarDealershipDataSet();
            this.tblDealerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDealerTableAdapter = new DealerApp.CarDealershipDataSetTableAdapters.tblDealerTableAdapter();
            this.dealerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDealers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDealerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDealer
            // 
            this.btnAddDealer.Location = new System.Drawing.Point(15, 93);
            this.btnAddDealer.Name = "btnAddDealer";
            this.btnAddDealer.Size = new System.Drawing.Size(75, 23);
            this.btnAddDealer.TabIndex = 0;
            this.btnAddDealer.Text = "Add";
            this.btnAddDealer.UseVisualStyleBackColor = true;
            this.btnAddDealer.Click += new System.EventHandler(this.btnAddDealer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dealer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dealer Name:";
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(90, 21);
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.ReadOnly = true;
            this.txtDealerID.Size = new System.Drawing.Size(100, 20);
            this.txtDealerID.TabIndex = 0;
            // 
            // txtDealerName
            // 
            this.txtDealerName.Location = new System.Drawing.Point(90, 53);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(100, 20);
            this.txtDealerName.TabIndex = 1;
            // 
            // dtgDealers
            // 
            this.dtgDealers.AllowUserToAddRows = false;
            this.dtgDealers.AllowUserToDeleteRows = false;
            this.dtgDealers.AllowUserToResizeColumns = false;
            this.dtgDealers.AllowUserToResizeRows = false;
            this.dtgDealers.AutoGenerateColumns = false;
            this.dtgDealers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDealers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dealerIDDataGridViewTextBoxColumn,
            this.dealerNameDataGridViewTextBoxColumn});
            this.dtgDealers.DataSource = this.tblDealerBindingSource;
            this.dtgDealers.Location = new System.Drawing.Point(12, 148);
            this.dtgDealers.Name = "dtgDealers";
            this.dtgDealers.ReadOnly = true;
            this.dtgDealers.Size = new System.Drawing.Size(240, 150);
            this.dtgDealers.TabIndex = 4;
            this.dtgDealers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDealers_CellClick);
            // 
            // carDealershipDataSet
            // 
            this.carDealershipDataSet.DataSetName = "CarDealershipDataSet";
            this.carDealershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDealerBindingSource
            // 
            this.tblDealerBindingSource.DataMember = "tblDealer";
            this.tblDealerBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // tblDealerTableAdapter
            // 
            this.tblDealerTableAdapter.ClearBeforeFill = true;
            // 
            // dealerIDDataGridViewTextBoxColumn
            // 
            this.dealerIDDataGridViewTextBoxColumn.DataPropertyName = "DealerID";
            this.dealerIDDataGridViewTextBoxColumn.HeaderText = "DealerID";
            this.dealerIDDataGridViewTextBoxColumn.Name = "dealerIDDataGridViewTextBoxColumn";
            this.dealerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dealerNameDataGridViewTextBoxColumn
            // 
            this.dealerNameDataGridViewTextBoxColumn.DataPropertyName = "DealerName";
            this.dealerNameDataGridViewTextBoxColumn.HeaderText = "DealerName";
            this.dealerNameDataGridViewTextBoxColumn.Name = "dealerNameDataGridViewTextBoxColumn";
            this.dealerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(177, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 325);
            this.Controls.Add(this.dtgDealers);
            this.Controls.Add(this.txtDealerName);
            this.Controls.Add(this.txtDealerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddDealer);
            this.Name = "frmDealer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dealer Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDealers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDealerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDealer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDealerID;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.DataGridView dtgDealers;
        private CarDealershipDataSet carDealershipDataSet;
        private System.Windows.Forms.BindingSource tblDealerBindingSource;
        private CarDealershipDataSetTableAdapters.tblDealerTableAdapter tblDealerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}

