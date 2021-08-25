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
    public partial class EditRimsReq : Form
    {
        public EditRimsReq()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * from Seling_rims_View_check;", connection);
                SqlDataReader reader1 = command.ExecuteReader();
                while (reader1.Read())
                {

                    string vibeRims = reader1["RIms_name"].ToString();
                    string vibeWorkerName = reader1["Full_worker_name"].ToString();
                    string vibeCustomerName = reader1["Full_customer_name"].ToString();
                    string vibeDateSale = reader1["date_of_sale"].ToString();
                    string vibeTimeSale = reader1["time_of_sale"].ToString();

                    if (RimsComboBox.Text == vibeRims && UserComboBox.Text == vibeWorkerName && CustomerComboBox.Text == vibeCustomerName && DateTextBox.Text == vibeDateSale && TimeTextBox.Text == vibeTimeSale)
                    {

                        label9.Text = "Такая запись уже существует";
                        return;

                    }
                }

                reader1.Close();

                if (!string.IsNullOrEmpty(TimeTextBox.Text) && !string.IsNullOrEmpty(DateTextBox.Text))
                {

                    SqlCommand UPcommand = new SqlCommand("Update Selling_rims SET id_user_accounts = @id_user_accounts,"+ " id_customer =  @id_customer," + " id_rims = @id_rims, "+ " date_of_sale = @date_of_sale "+ ", time_of_sale = time_of_sale where id_Selling_rims = @id_Selling_rims", connection);

                    UPcommand.Parameters.AddWithValue("@id_Selling_rims", RimsSellNumbercomboBox.Text);

                    if (!string.IsNullOrEmpty(CustomerComboBox.Text))
                    {

                        SqlCommand Customer_id = new SqlCommand("select id_customer from Customers where Full_customer_name = @Full_customer_name", connection);

                        string CustomerID = CustomerComboBox.Text;
                        Customer_id.Parameters.AddWithValue("@Full_customer_name", CustomerID);
                        SqlDataReader reader = Customer_id.ExecuteReader();

                        while (reader.Read())
                        {
                            string CustomerID1 = reader["id_customer"].ToString();
                            UPcommand.Parameters.AddWithValue("@id_customer", CustomerID1);
                        }
                        reader.Close();
                        Customer_id.ExecuteNonQuery();
                    }


                    if (!string.IsNullOrEmpty(UserComboBox.Text))
                    {
                        SqlCommand User_accounts_id = new SqlCommand("select id_user_accounts from User_accounts where Full_worker_name = @Full_worker_name", connection);

                        User_accounts_id.Parameters.AddWithValue("@Full_worker_name", UserComboBox.Text);
                        SqlDataReader reader = User_accounts_id.ExecuteReader();

                        while (reader.Read())
                        {
                            string User_accounts_ID1 = reader["id_user_accounts"].ToString();
                            UPcommand.Parameters.AddWithValue("@id_user_accounts", User_accounts_ID1);
                        }
                        reader.Close();
                        User_accounts_id.ExecuteNonQuery();

                    }

                    if (!string.IsNullOrEmpty(RimsComboBox.Text))
                    {

                        SqlCommand Service_type_id = new SqlCommand("select id_rims from [Rims] where RIms_name = @RIms_name", connection);

                        string Service_type_ID = RimsComboBox.Text;
                        Service_type_id.Parameters.AddWithValue("@RIms_name", Service_type_ID);
                        SqlDataReader reader = Service_type_id.ExecuteReader();

                        while (reader.Read())
                        {
                            string Service_type_ID1 = reader["id_rims"].ToString();
                            UPcommand.Parameters.AddWithValue("@id_rims", Service_type_ID1);

                        }
                        reader.Close();
                        Service_type_id.ExecuteNonQuery();

                    }


                    if (!string.IsNullOrEmpty(DateTextBox.Text))
                    {
                        UPcommand.Parameters.AddWithValue("@date_of_sale", DateTextBox.Text);
                    }

                    if (!string.IsNullOrEmpty(TimeTextBox.Text))
                    {
                        UPcommand.Parameters.AddWithValue("@time_of_sale", TimeTextBox.Text);
                    }

                    this.Hide();
                    UPcommand.ExecuteNonQuery();
                    connection.Close();
                }

                if (string.IsNullOrEmpty(TimeTextBox.Text) || string.IsNullOrEmpty(DateTextBox.Text))
                {
                    label9.Text = "Заполните все поля";
                }
            }
        }

        private void EditRimsReq_Load(object sender, EventArgs e)
        {
            this.seling_rims_ViewTableAdapter.Fill(this.sellingRimsVew.Seling_rims_View);
            this.selling_rimsTableAdapter.Fill(this.tire_Service_DB.Selling_rims);
            this.customersTableAdapter.Fill(this.tire_Service_DB.Customers);
            this.user_accountsTableAdapter.Fill(this.tire_Service_DB.User_accounts);
            this.rimsTableAdapter.Fill(this.tire_Service_DB.Rims);

        }
    }   
}
