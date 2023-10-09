using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DealerApp
{
    internal class DealerClass
    {
        private string connectionString;
        public DealerClass()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CarDealershipConnectionString"].ConnectionString;
        }
        public void DealerInsert(string dealerName)
        { 
            SqlConnection objSQLconnection = new SqlConnection(connectionString);
            {
                try
                {
                    objSQLconnection.Open();
                    using (SqlCommand InsertCommand = new SqlCommand("spInsertDealerCommand", objSQLconnection))
                    {
                        InsertCommand.CommandType = CommandType.StoredProcedure;
                        InsertCommand.Parameters.AddWithValue("@DealerName", dealerName);
                        InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Add Dealer Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);;
                }
                finally 
                { 
                    objSQLconnection.Close(); 
                }

            }
        }
    }
}
