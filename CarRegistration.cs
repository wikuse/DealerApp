using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerApp
{
    public partial class frmCarRegistration : Form
    {
        CarClass car;
        public frmCarRegistration()
        {
            InitializeComponent();
            populateCMBDealers();
            car = new CarClass();
        }
        public void populateCMBDealers()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipConnectionString"].ConnectionString;
            SqlConnection objSQLConenction = new SqlConnection(connectionString);
            string query = "SELECT DealerID FROM tblDealer";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbDealerID.Items.Add(reader["DealerID"].ToString());
                        }
                    }
                }
            }
        }

        private void frmCarRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carDealershipDataSet1.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.carDealershipDataSet1.tblCar);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            car.CarInsert(txtCarID.Text, txtModel.Text, Convert.ToInt16(cmbDealerID.Text));
            this.tblCarTableAdapter.Fill(this.carDealershipDataSet1.tblCar);
        }
    }
}
