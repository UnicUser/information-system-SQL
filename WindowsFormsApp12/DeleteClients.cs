using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp12
{
    public partial class DeleteClients : Form
    {
        public DeleteClients()
        {
            InitializeComponent();
        }

        private void DeleteClients_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.tire_Service_DB.Customers);
            this.customers_ViewTableAdapter.Fill(this.tire_Service_DB.Customers_View);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrEmpty(CustomerNamecomboBox.Text))
                {
                    
                        SqlCommand Delete = new SqlCommand("delete from Customers where Full_customer_name = @Full_customer_name", connection);
                        connection.Open();

                        Delete.Parameters.AddWithValue("@Full_customer_name", CustomerNamecomboBox.Text);

                        Delete.ExecuteNonQuery();

                        connection.Close();
                    
                }
                this.Hide();
            }

            if (string.IsNullOrEmpty(CustomerNamecomboBox.Text))
            {
                label9.Text = "Заполните поле";
            }
        }

    }
}
