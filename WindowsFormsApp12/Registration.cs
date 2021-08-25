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
    public partial class Registration : Form
    {
        public Registration()
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(textBox1.Text)
                    || string.IsNullOrEmpty(textBox2.Text))
                {
                    label9.Text = "Заполните все поля";
                }

                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {
                                      
                        SqlCommand UnsertCommand = new SqlCommand("insert into User_accounts ([login], password)" +
                        "VALUES  (@login, @password)", connection);
                        connection.Open();
                        UnsertCommand.Parameters.AddWithValue("@login", textBox1.Text);
                        UnsertCommand.Parameters.AddWithValue("@password", textBox2.Text);
                        UnsertCommand.ExecuteNonQuery();

                    LoginForm f1 = new LoginForm();
                    f1.Show();
                    this.Hide();

                }

            }
        }
         

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Show();
            this.Hide();
        }
    }
}

