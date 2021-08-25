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
    public partial class EditReq1 : Form
    {
        public EditReq1()
        {
            InitializeComponent();
        }

        private void EditReq1_Load(object sender, EventArgs e)
        {
            this.requests_ViewTableAdapter.Fill(this.tire_Service_DB_Number.Requests_View);
            this.service_ViewTableAdapter.Fill(this.tire_Service_DB.Service_View);
            this.worker_accounts_ViewTableAdapter.Fill(this.tire_Service_DB.Worker_accounts_View);
            this.customers_ViewTableAdapter.Fill(this.tire_Service_DB.Customers_View);

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                if (!string.IsNullOrEmpty(TimetextBox.Text) && !string.IsNullOrEmpty(DatetextBox.Text))
                {

                    SqlCommand UpCommand = new SqlCommand("UPDATE Requests SET id_customer = @id_customer," + " id_service = @id_service," + "id_user_accounts = @id_user_accounts," + "date_of_service = @date_of_service," + "time_of_service = @time_of_service WHERE id_requests = @id_requests ", connection);
                    connection.Open();

                    UpCommand.Parameters.AddWithValue("@id_requests", comboBox4.Text);

                    if (!string.IsNullOrEmpty(comboBox1.Text))
                    {

                        SqlCommand Customer_id = new SqlCommand("select id_customer from Customers where Surname = @Surname", connection);

                        string CustomerID = comboBox1.Text;
                        Customer_id.Parameters.AddWithValue("@Surname", CustomerID);
                        SqlDataReader reader = Customer_id.ExecuteReader();

                        while (reader.Read())
                        {
                            string CustomerID1 = reader["id_customer"].ToString();
                            UpCommand.Parameters.AddWithValue("@id_customer", CustomerID1);
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
                                UpCommand.Parameters.AddWithValue("@id_service", Service_type_ID1);

                            }
                            reader.Close();
                            Service_type_id.ExecuteNonQuery();
                    }

                        if (!string.IsNullOrEmpty(comboBox3.Text))
                        {
                            SqlCommand User_accounts_id = new SqlCommand("select id_user_accounts from User_accounts where Surname_of_Worker = @Surname_of_Worker", connection);

                            string User_accounts_ID = comboBox3.Text;
                            User_accounts_id.Parameters.AddWithValue("@Surname_of_Worker", User_accounts_ID);
                            SqlDataReader reader = User_accounts_id.ExecuteReader();

                            while (reader.Read())
                            {
                                string User_accounts_ID1 = reader["id_user_accounts"].ToString();
                                UpCommand.Parameters.AddWithValue("@id_user_accounts", User_accounts_ID1);
                            }
                            reader.Close();
                            User_accounts_id.ExecuteNonQuery();
                        }

                        if (!string.IsNullOrEmpty(DatetextBox.Text))
                        {
                            UpCommand.Parameters.AddWithValue("@date_of_service", DatetextBox.Text);

                        }

                        if (!string.IsNullOrEmpty(TimetextBox.Text))
                        {
                            UpCommand.Parameters.AddWithValue("@time_of_service", TimetextBox.Text);
                        }

                    UpCommand.ExecuteNonQuery();
                }

                connection.Close();
                this.Hide();

                if (string.IsNullOrEmpty(TimetextBox.Text) || string.IsNullOrEmpty(DatetextBox.Text))
                {
                    label9.Text = "Заполните все поля";
                }
            }
        }
    }
}
