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
    public partial class EditClients : Form
    {
        public EditClients()
        {
            InitializeComponent();
        }

        private void EditClients_Load(object sender, EventArgs e)
        {

            this.customers_ViewTableAdapter.Fill(this.tire_Service_DB.Customers_View);

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrEmpty(SurnameTextBox.Text) && !string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(MiddleNameTextBox.Text) && !string.IsNullOrEmpty(PhoneTextBox.Text))
                {

                    SqlCommand UpCommand = new SqlCommand("UPDATE Customers SET Surname = @Surname," + "Name = @Name," + "Middle_name = @Middle_name," + "Phone = @Phone where Full_customer_name = @Full_customer_name", connection);
                    connection.Open();

                    UpCommand.Parameters.AddWithValue("@Full_customer_name", comboBox4.Text); 

                    if (!string.IsNullOrEmpty(SurnameTextBox.Text))
                    {
                        UpCommand.Parameters.AddWithValue("@Surname", SurnameTextBox.Text);

                    }

                    if (!string.IsNullOrEmpty(NameTextBox.Text))
                    {
                        UpCommand.Parameters.AddWithValue("@Name", NameTextBox.Text);
                    }

                    if (!string.IsNullOrEmpty(MiddleNameTextBox.Text))
                    {
                        UpCommand.Parameters.AddWithValue("@Middle_name", MiddleNameTextBox.Text);
                    }

                    if (!string.IsNullOrEmpty(PhoneTextBox.Text))
                    {
                        UpCommand.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
                    }

                    UpCommand.ExecuteNonQuery();
                }

                connection.Close();
                this.Hide();

                if (string.IsNullOrEmpty(SurnameTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(MiddleNameTextBox.Text)|| string.IsNullOrEmpty(PhoneTextBox.Text))
                {
                    label9.Text = "Заполните все поля";
                }
            
            }

        }

    }
}
