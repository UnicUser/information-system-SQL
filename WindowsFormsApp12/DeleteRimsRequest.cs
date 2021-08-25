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
    public partial class DeleteRimsRequest : Form
    {
        public DeleteRimsRequest()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrEmpty(RimsReqNumbercomboBox.Text))
                {

                    SqlCommand Delete = new SqlCommand("delete from Selling_rims where id_Selling_rims = @id_Selling_rims", connection);
                    connection.Open();

                    Delete.Parameters.AddWithValue("@id_Selling_rims", RimsReqNumbercomboBox.Text);

                    Delete.ExecuteNonQuery();

                    connection.Close();

                }
                this.Hide();
            }

            if (string.IsNullOrEmpty(RimsReqNumbercomboBox.Text))
            {
                label9.Text = "Заполните поле";
            }

        }

        private void DeleteRimsRequest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sellingRimsVew.Selling_rims". При необходимости она может быть перемещена или удалена.
            this.selling_rimsTableAdapter.Fill(this.sellingRimsVew.Selling_rims);
            this.seling_rims_ViewTableAdapter.Fill(this.sellingRimsVew.Seling_rims_View);

        }
    }
}
