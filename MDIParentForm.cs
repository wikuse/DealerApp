using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerApp
{
    public partial class MDIParentForm : Form
    {
        public MDIParentForm()
        {
            InitializeComponent();
        }

        private void dealershipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDealer objFrmDealer = new frmDealer();
            objFrmDealer.MdiParent = this;
            objFrmDealer.Show();
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarRegistration objFrmCarRegistration = new frmCarRegistration();
            objFrmCarRegistration.MdiParent = this;
            objFrmCarRegistration.Show();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carsPerDealerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarsPerDealer objCarsPerDealer = new frmCarsPerDealer();
            objCarsPerDealer.MdiParent = this;
            objCarsPerDealer.Show();
        }
    }
}
