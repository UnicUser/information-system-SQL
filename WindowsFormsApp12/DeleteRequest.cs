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
    public partial class DeleteRequest : Form
    {
        public DeleteRequest()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrEmpty(RequestNamecomboBox.Text))
                {

                    SqlCommand Delete = new SqlCommand("delete from Requests where id_requests = @id_requests", connection);
                    connection.Open();

                    Delete.Parameters.AddWithValue("@id_requests", RequestNamecomboBox.Text);

                    Delete.ExecuteNonQuery();

                    connection.Close();

                }
                this.Hide();
            }

            if (string.IsNullOrEmpty(RequestNamecomboBox.Text))
            {
                label9.Text = "Заполните поле";
            }

        }

        private void DeleteRequest_Load(object sender, EventArgs e)
        {
            this.requestsTableAdapter.Fill(this.sellingRimsVew.Requests);
            this.requests_ViewTableAdapter.Fill(this.sellingRimsVew.Requests_View);

        }
    }
}
