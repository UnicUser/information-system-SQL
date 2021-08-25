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
    public partial class LoginForm : Form
    {
 
        public LoginForm()
        {
            InitializeComponent();
                    
        }

        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }


        private void SignIn_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(LoginBox.Text))
            {
                label3.Text = "";
            }

            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))

                if (!string.IsNullOrEmpty(LoginBox.Text)&& !string.IsNullOrEmpty(PasswordBox.Text)) 
                {

                    if (UserCheck.Checked)
                    {
                            SqlCommand command = new SqlCommand("SELECT * FROM User_accounts;", connection);
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                string vibelog = reader["login"].ToString();
                                string vibepassword = reader["password"].ToString();
                                if (LoginBox.Text == vibelog && PasswordBox.Text == vibepassword)
                                {
                                    User f2 = new User();
                                    f2.Show();
                                    this.Hide();
                                }

                                else
                                {
                                     label3.Text = "Неверный логин или пароль";
                                }

                            }
                                reader.Close();                           
                    }

                        if (AdminCheck.Checked)
                        {
                            SqlCommand command = new SqlCommand("SELECT * FROM Admin_accounts;", connection);
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                string vibelog = reader["login"].ToString();
                                string vibepassword = reader["password"].ToString();

                                if (LoginBox.Text == vibelog && PasswordBox.Text == vibepassword)
                                {
                                    Admin f3 = new Admin();
                                    f3.Show();
                                    this.Hide();

                                }

                                else
                                {

                                    label3.Text = "Неверный логин или пароль";

                                }

                            }

                             reader.Close();

                        }                                          
                }       

            if (string.IsNullOrEmpty(LoginBox.Text) && string.IsNullOrWhiteSpace(LoginBox.Text) )
            {
                label3.Text = "Заполните данное поле";

            }

            if (string.IsNullOrEmpty(PasswordBox.Text) && string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                label4.Text = "Заполните данное поле";
            }
            else
            {
                label4.Text = "";
            }

            if (UserCheck.Checked == false && AdminCheck.Checked == false)
            {
                label5.Text = "Выберите роль";

            }
            else
            {
                label5.Text = "";
            }
        }

        private void AdminCheck_Click(object sender, EventArgs e)
        {
            if (UserCheck.Checked && AdminCheck.Checked)
            {
                UserCheck.Checked = false;
                UserCheck.CheckState = 0;
            }
        }

        private void UserCheck_Click(object sender, EventArgs e)
        {
            if (UserCheck.Checked && AdminCheck.Checked)
            {
                AdminCheck.Checked = false;
                AdminCheck.CheckState = 0;
            }
        }
    }
}

