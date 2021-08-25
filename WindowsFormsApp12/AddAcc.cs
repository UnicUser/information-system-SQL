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
    public partial class AddAcc : Form
    {
        public AddAcc()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(LoginBox.Text)
                    || string.IsNullOrEmpty(PassowrdBox.Text) || string.IsNullOrEmpty(SurnametextBox.Text) || string.IsNullOrEmpty(NametextBox.Text) || string.IsNullOrEmpty(MiddleNametextBox.Text) || string.IsNullOrEmpty(JobtextBox.Text))
                {
                    label9.Text = "Заполните все поля";
                }

                if (!string.IsNullOrEmpty(LoginBox.Text) && !string.IsNullOrEmpty(PassowrdBox.Text) && !string.IsNullOrEmpty(RoleBox1.Text))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM User_accounts;", connection);
                    SqlDataReader reader1 = command.ExecuteReader();
                    while (reader1.Read())
                    {
                        string vibelogin = reader1["login"].ToString();
                        string vibepassword = reader1["password"].ToString();
                        string vibeSurname = reader1["Surname_of_Worker"].ToString();
                        string vibeName = reader1["Name_of_Worker"].ToString();
                        string vibeMiddleName = reader1["Middle_name_of_Worker"].ToString();

                        if (LoginBox.Text == vibelogin && PassowrdBox.Text == vibepassword)
                        {

                            label9.Text = "Такой пользователь уже сущетсвует";
                            return;

                        }

                        if (SurnametextBox.Text == vibeSurname && NametextBox.Text == vibeName && MiddleNametextBox.Text == vibeMiddleName)
                        {

                            label9.Text = "Такой пользователь уже сущетсвует";
                            return;

                        }


                    }

                    reader1.Close();

                    if (RoleBox1.Text == "Пользователь")
                    {
               

                        SqlCommand UnsertCommand = new SqlCommand("insert into User_accounts ([login], password, Surname_of_Worker, Name_of_Worker, Middle_name_of_Worker, job_position)" +
                        "VALUES  (@login, @password, @Surname_of_Worker, @Name_of_Worker, @Middle_name_of_Worker, @job_position)", connection);

                        SqlCommand User_id = new SqlCommand("select id_user_accounts from User_accounts where Surname_of_Worker = @Surname_of_Worker", connection);
                        
                        User_id.Parameters.AddWithValue("@Surname_of_Worker", SurnametextBox.Text);
                        SqlDataReader reader = User_id.ExecuteReader();

                        while (reader.Read())
                        {
                            string User_ID1 = reader["id_user_account"].ToString();
                            
                        }

                        reader.Close();
                        User_id.ExecuteNonQuery();
                        UnsertCommand.Parameters.AddWithValue("@login", LoginBox.Text);
                        UnsertCommand.Parameters.AddWithValue("@password", PassowrdBox.Text);
                        UnsertCommand.Parameters.AddWithValue("@Surname_of_Worker", SurnametextBox.Text);   
                        UnsertCommand.Parameters.AddWithValue("@Name_of_Worker", NametextBox.Text);
                        UnsertCommand.Parameters.AddWithValue("@Middle_name_of_Worker", MiddleNametextBox.Text);
                        UnsertCommand.Parameters.AddWithValue("@job_position", JobtextBox.Text);
                        UnsertCommand.ExecuteNonQuery();
                    }
                    this.Hide();

                    if (RoleBox1.Text == "Администратор")
                    {
                                    
                        SqlCommand UnsertCommand = new SqlCommand("insert into Admin_accounts ([login], password, Surname, Name, Middle_name, job_position)" +
                        "VALUES  (@login, @password, @Surname, @Name, @Middle_name, @job_position)", connection);
                        
                        UnsertCommand.Parameters.AddWithValue("@login", LoginBox.Text);
                        UnsertCommand.Parameters.AddWithValue("@password", PassowrdBox.Text);
                        UnsertCommand.Parameters.AddWithValue("@Surname", SurnametextBox.Text);
                        UnsertCommand.Parameters.AddWithValue("@Name", NametextBox.Text);
                        UnsertCommand.Parameters.AddWithValue("@Middle_name", MiddleNametextBox.Text);
                        UnsertCommand.Parameters.AddWithValue("@job_position", JobtextBox.Text);
                        UnsertCommand.ExecuteNonQuery();
                    }
                    this.Hide();

                }

                if (string.IsNullOrEmpty(RoleBox1.Text))
                {
                    label9.Text = "Выберите уровень доступа";
                }

               

            }
        }

        private void PasswordShowBox_Click(object sender, EventArgs e)
        {
            if (PasswordShowBox.Checked)
            {
                PassowrdBox.PasswordChar = '\0';
            }

            if(!PasswordShowBox.Checked)
            {
                PassowrdBox.PasswordChar = '*';
            }
        }
    }
}
