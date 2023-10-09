using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerApp
{
    public partial class frmDealer : Form
    {
        DealerClass dealerClass;
        public frmDealer()
        {
            InitializeComponent();
            dealerClass = new DealerClass();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carDealershipDataSet.tblDealer' table. You can move, or remove it, as needed.
            this.tblDealerTableAdapter.Fill(this.carDealershipDataSet.tblDealer);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgDealers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDealerID.Text = dtgDealers.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtDealerName.Text = dtgDealers.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }

        private void btnAddDealer_Click(object sender, EventArgs e)
        {
            dealerClass.DealerInsert(txtDealerName.Text);
            // TODO: This line of code loads data into the 'carDealershipDataSet.tblDealer' table. You can move, or remove it, as needed.
            this.tblDealerTableAdapter.Fill(this.carDealershipDataSet.tblDealer);
        }
    }
}
