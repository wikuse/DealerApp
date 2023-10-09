using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Lifetime;


namespace DealerApp
{
    internal class CarClass
    {
        private string connectionString;
        public CarClass()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CarDealershipConnectionString"].ConnectionString;
        }
        public void CarInsert(string CarID, string model, int dealerID)
        {
            SqlConnection objSQLconnection = new SqlConnection(connectionString);
            {
                try
                {
                    objSQLconnection.Open();
                    using (SqlCommand InsertCommand = new SqlCommand("spInsertCar", objSQLconnection))
                    {
                        InsertCommand.CommandType = CommandType.StoredProcedure;
                        InsertCommand.Parameters.AddWithValue("@CarID", CarID);
                        InsertCommand.Parameters.AddWithValue("@Model", model);
                        InsertCommand.Parameters.AddWithValue("@DealerID", dealerID);
                        InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Add Car Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message); ;
                }
                finally
                {
                    objSQLconnection.Close();
                }

            }
        }
        
    }
}
