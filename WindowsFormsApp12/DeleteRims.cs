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
    public partial class DeleteRims : Form
    {
        public DeleteRims()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrEmpty(RimsNamecomboBox.Text))
                {

                    SqlCommand Delete = new SqlCommand("delete from Rims where RIms_name = @RIms_name", connection);
                    connection.Open();

                    Delete.Parameters.AddWithValue("@RIms_name", RimsNamecomboBox.Text);

                    Delete.ExecuteNonQuery();

                    connection.Close();

                }
                this.Hide();
            }

            if (string.IsNullOrEmpty(RimsNamecomboBox.Text))
            {
                label9.Text = "Заполните поле";
            }

        }

        private void DeleteRims_Load(object sender, EventArgs e)
        {
            this.rimsTableAdapter.Fill(this.sellingRimsVew.Rims);
            this.rims_ViewTableAdapter.Fill(this.sellingRimsVew.Rims_View);
        }
    }
}
