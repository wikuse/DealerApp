namespace DealerApp
{
    partial class frmCarsPerDealer
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
            this.lbxDealerID = new System.Windows.Forms.ListBox();
            this.lbxCarID = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Dealer ID:";
            // 
            // lbxDealerID
            // 
            this.lbxDealerID.FormattingEnabled = true;
            this.lbxDealerID.Location = new System.Drawing.Point(27, 51);
            this.lbxDealerID.Name = "lbxDealerID";
            this.lbxDealerID.Size = new System.Drawing.Size(120, 186);
            this.lbxDealerID.TabIndex = 2;
            this.lbxDealerID.SelectedIndexChanged += new System.EventHandler(this.lbxDealerID_SelectedIndexChanged);
            // 
            // lbxCarID
            // 
            this.lbxCarID.FormattingEnabled = true;
            this.lbxCarID.Location = new System.Drawing.Point(184, 51);
            this.lbxCarID.Name = "lbxCarID";
            this.lbxCarID.Size = new System.Drawing.Size(120, 186);
            this.lbxCarID.TabIndex = 2;
            this.lbxCarID.SelectedIndexChanged += new System.EventHandler(this.lbxCarID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dealer Inventory:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(229, 273);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCarsPerDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 316);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbxCarID);
            this.Controls.Add(this.lbxDealerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCarsPerDealer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cars Per Dealer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxDealerID;
        private System.Windows.Forms.ListBox lbxCarID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
    }
}