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
    public partial class AddRequest : Form
    {
        public AddRequest()
        {
            InitializeComponent();

        }

        private void AddRequest_Load(object sender, EventArgs e)
        {
            this.serviceTableAdapter.Fill(this.tire_Service_DB.Service);
            this.user_accountsTableAdapter.Fill(this.tire_Service_DB.User_accounts);
            this.customersTableAdapter.Fill(this.tire_Service_DB.Customers);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {

                    SqlCommand AddCommand = new SqlCommand("insert into Requests (id_customer, id_service, id_user_accounts, date_of_service, time_of_service)" +
                    "VALUES  (@id_customer, @id_service, @id_user_accounts, @date_of_service, @time_of_service)", connection);
                    connection.Open();

                    if (!string.IsNullOrEmpty(comboBox1.Text))
                    {
                       
                        SqlCommand Customer_id = new SqlCommand("select id_customer from Customers where Full_customer_name = @Full_customer_name", connection);
                       
                        string CustomerID = comboBox1.Text;
                        Customer_id.Parameters.AddWithValue("@Full_customer_name", CustomerID);
                        SqlDataReader reader = Customer_id.ExecuteReader();

                        while (reader.Read())
                        {
                            string CustomerID1 = reader["id_customer"].ToString();
                            AddCommand.Parameters.AddWithValue("@id_customer", CustomerID1);
                        }
                        reader.Close();
                        Customer_id.ExecuteNonQuery();                      
                    }
                  
                    if (!string.IsNullOrEmpty(comboBox2.Text))
                    {
                        
                        SqlCommand Service_type_id = new SqlCommand("select id_service from [Service] where Service_name = @Service_name", connection);
                       
                        string Service_type_ID = comboBox2.Text;
                        Service_type_id.Parameters.AddWithValue("@Service_name", Service_type_ID);
                        SqlDataReader reader = Service_type_id.ExecuteReader();

                        while (reader.Read())
                        {
                            string Service_type_ID1 = reader["id_service"].ToString();
                            AddCommand.Parameters.AddWithValue("@id_service", Service_type_ID1);
                            
                        }
                        reader.Close();
                        Service_type_id.ExecuteNonQuery();

                    }

                    if (!string.IsNullOrEmpty(comboBox3.Text))
                    {
                        SqlCommand User_accounts_id = new SqlCommand("select id_user_accounts from User_accounts where Full_worker_name = @Full_worker_name", connection);
                       
                        string User_accounts_ID = comboBox3.Text;
                        User_accounts_id.Parameters.AddWithValue("@Full_worker_name", User_accounts_ID);
                        SqlDataReader reader = User_accounts_id.ExecuteReader();

                        while(reader.Read())
                        {
                            string User_accounts_ID1 = reader["id_user_accounts"].ToString();
                            AddCommand.Parameters.AddWithValue("@id_user_accounts", User_accounts_ID1);
                        }
                        reader.Close();
                        User_accounts_id.ExecuteNonQuery();
                        
                    }


                    if(!string.IsNullOrEmpty(textBox2.Text))
                    {
                        AddCommand.Parameters.AddWithValue("@date_of_service", textBox2.Text);

                    }

                    if(!string.IsNullOrEmpty(textBox1.Text))
                    {
                        AddCommand.Parameters.AddWithValue("@time_of_service", textBox1.Text);
                    }

                    
                    this.Hide();
                    AddCommand.ExecuteNonQuery();
                    connection.Close();
                }

                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    label9.Text = "Заполните все поля";
                }              
            }
        }
    }
}
