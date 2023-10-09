using System;
using System.Collections;
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
    public partial class frmCarsPerDealer : Form
    {
        public frmCarsPerDealer()
        {
            InitializeComponent();
            PopulateDealerListBox();
        }
        private void PopulateDealerListBox()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipConnectionString"].ConnectionString;
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
                            lbxDealerID.Items.Add(reader["DealerID"].ToString());
                        }
                    }
                }
                connection.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbxCarID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lbxDealerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxCarID.Items.Clear();
            string selectedDealerID = lbxDealerID.SelectedItem.ToString();

            string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipConnectionString"].ConnectionString;
            string query = "SELECT CarID FROM tblCar WHERE DealerID = @DealerID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DealerID", selectedDealerID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lbxCarID.Items.Add(reader["CarID"].ToString());
                        }
                    }
                }
                connection.Close();
            }
        }
    }
    
}
