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
    public partial class DeleteAcc : Form
    {
        public DeleteAcc()
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

        private void ShowAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableWindow2.DataSource = adminaccountsViewBindingSource;
            this.admin_accounts_ViewTableAdapter.Fill(this.tire_Service_DB.Admin_accounts_View);
        }

        private void ShowUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableWindow2.DataSource = workeraccountsViewBindingSource;
            this.worker_accounts_ViewTableAdapter.Fill(this.tire_Service_DB.Worker_accounts_View);
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (AdminCheck.Checked)
                    {
                        SqlCommand Delete = new SqlCommand("delete from Admin_accounts where id_admin_accounts = @id ", connection);
                        connection.Open();

                        Delete.Parameters.AddWithValue("@id", textBox1.Text);

                        Delete.ExecuteNonQuery();

                        connection.Close();
                    }

                    if (UserCheck.Checked)
                    {
                        SqlCommand Delete1 = new SqlCommand("delete from User_accounts where id_user_accounts = @id ", connection);
                        connection.Open();

                        Delete1.Parameters.AddWithValue("@id", textBox1.Text);

                        Delete1.ExecuteNonQuery();

                        connection.Close();
                    }
                }

                label9.Text = "Удаление выполнено, для просмотра обновите таблицу";
            }

            if(!UserCheck.Checked && !AdminCheck.Checked )
            {
                label9.Text = "Выберите тип пользователя";
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label9.Text = "Заполните поле";
            }
        }
    }
}
