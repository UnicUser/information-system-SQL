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
    public partial class AddCustomers : Form
    {
        public AddCustomers()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
             
                connection.Open();

                if (!string.IsNullOrEmpty(SurnameTextBox.Text) || !string.IsNullOrEmpty(NameTextBox.Text)
                || !string.IsNullOrEmpty(MiddleNameTextBox.Text) || !string.IsNullOrEmpty(PhoneTextBox.Text))
                {

                    SqlCommand command = new SqlCommand("SELECT * FROM Customers;", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                            string vibeSurname = reader["Surname"].ToString();
                            string vibeName = reader["Name"].ToString();
                            string vibepMiddleName = reader["Middle_name"].ToString();

                            if (SurnameTextBox.Text == vibeSurname && NameTextBox.Text == vibeName && MiddleNameTextBox.Text == vibepMiddleName)
                            {

                                label9.Text = "Такой пользователь уже сущетсвует";
                                return;
                                
                            }                                                                                     
                    }

                    SqlCommand AddCommand = new SqlCommand("insert into Customers (Surname, Name, Middle_name, Phone)" +
                    "VALUES  (@Surname, @Name, @Middle_name, @Phone)", connection);
                    

                        if (!string.IsNullOrEmpty(SurnameTextBox.Text))
                        {
                            AddCommand.Parameters.AddWithValue("@Surname", SurnameTextBox.Text);
                        }

                        if (!string.IsNullOrEmpty(NameTextBox.Text))
                        {
                            AddCommand.Parameters.AddWithValue("@Name", NameTextBox.Text);
                        }

                        if (!string.IsNullOrEmpty(MiddleNameTextBox.Text))
                        {
                            AddCommand.Parameters.AddWithValue("@Middle_name", MiddleNameTextBox.Text);
                        }

                        if (!string.IsNullOrEmpty(PhoneTextBox.Text))
                        {
                            AddCommand.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
                        }

                        reader.Close();
                        AddCommand.ExecuteNonQuery();
                        connection.Close();
                   
                }
               
                if (string.IsNullOrEmpty(SurnameTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(MiddleNameTextBox.Text) || string.IsNullOrEmpty(PhoneTextBox.Text))
                {
                    label9.Text = "Заполните все поля";
                }

                this.Hide();

            }
        }
    }
}
