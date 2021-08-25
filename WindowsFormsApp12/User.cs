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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void ServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableWindow.DataSource = serviceViewBindingSource;
            this.service_ViewTableAdapter.Fill(this.tire_Service_DB.Service_View);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Show();
            this.Hide();
        }

        private void PrintThisDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printthisDocument.Print();
        }

        private void printthisDocument_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(TableWindow.Size.Width + 620, TableWindow.Size.Height + 341);
            TableWindow.DrawToBitmap(bmp, TableWindow.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableWindow.DataSource = customersViewBindingSource;
            this.customers_ViewTableAdapter.Fill(this.tire_Service_DB.Customers_View);      
        }

        private void RequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableWindow.DataSource = requestsViewBindingSource;
            this.requests_ViewTableAdapter.Fill(this.tire_Service_DB.Requests_View);
        }

        private void CleanTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableWindow.DataSource = 0;
        }

        private void AddReqServToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRequest f7 = new AddRequest();
            f7.Show();
        }

        private void SellingRimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableWindow.DataSource = selingrimsViewBindingSource;
            this.seling_rims_ViewTableAdapter.Fill(this.tire_Service_DB.Seling_rims_View);
        }

        private void RimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableWindow.DataSource = rimsViewBindingSource;
            this.rims_ViewTableAdapter.Fill(this.tire_Service_DB.Rims_View);
        }

        private void AddReqServToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddRequest f9 = new AddRequest();
            f9.Show();
        }

        private void EditReqtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditReq1 f10 = new EditReq1();
            f10.Show();
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info f11 = new Info();
            f11.Show();
        }

        private void UserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerInfo f12 = new WorkerInfo();
            f12.Show();
        }

        private void AddRimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRims f13 = new AddRims();
            f13.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= TableWindow.Rows.Count - 1; i++)
                for (int j = 0; j <= TableWindow.ColumnCount - 1; j++)
                    if (TableWindow.Rows[i].Cells[j].Value != null && TableWindow.Rows[i].Cells[j].Value.ToString() != textBox1.Text)
                    {
                        TableWindow.Rows[i].Cells[j].Selected = false;
                    }

            for (int i = 0; i <= TableWindow.Rows.Count - 1; i++)
                for (int j = 0; j <= TableWindow.ColumnCount - 1; j++)
                    if (TableWindow.Rows[i].Cells[j].Value != null && TableWindow.Rows[i].Cells[j].Value.ToString() == textBox1.Text)
                        TableWindow.Rows[i].Cells[j].Selected = true;

        }

        private void RimsReqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRimsReq f14 = new AddRimsReq();
            f14.Show();
        }

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomers f15 = new AddCustomers();
            f15.Show();
        }

        private void EditCustomertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClients f16 = new EditClients();
            f16.Show();
        }

        private void EditRimstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRims f17 = new EditRims();
            f17.Show();
        }

        private void EditRimsReqtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRimsReq f18 = new EditRimsReq();
            f18.Show();
        }

        private void DeleteCustomertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteClients f19 = new DeleteClients();
            f19.Show();
        }

        private void DeleteReqtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRequest f20 = new DeleteRequest();
            f20.Show();
        }

        private void DeleteRimstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRims f21 = new DeleteRims();
            f21.Show();
        }

        private void DeleteRimsReqtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRimsRequest f22 = new DeleteRimsRequest();
            f22.Show();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableWindow.Refresh();
        }

        private void OrderByPriceUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Service_View order by Цена ASC;";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;


            }
        }

        private void OrderByPriceDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Service_View order by Цена DESC;";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;


            }
        }

        private void RimOrderByDIAUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by DIA ASC;";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;


            }
        }

        private void RimOrderByDIADownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by DIA DESC;";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;


            }
        }

        private void OrderByDiameterUPtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by [Диаметр диска] ASC;";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;


            }
        }

        private void OrderByDiameterDowntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by [Диаметр диска] DESC;";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByMaterialUPtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by [Материал диска] ASC;";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByMaterialDowntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by [Материал диска] DESC;";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByTypeUPtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by [Тип диска] ASC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByTypeDowntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by [Тип диска] DESC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByBoltsUPtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by LK_x_PCD ASC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByBoltsDowntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by LK_x_PCD DESC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByWidthUPtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by [Ширина диска] ASC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByWidthDowntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by [Ширина диска] DESC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByAmountUPtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by Количество ASC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByAmountDowntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by Количество DESC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByRimPriceUPtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by [Цена за шутку] ASC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByRimPriceDowntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by [Цена за шутку] DESC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void OrderByBrandUptoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by Производитель ASC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;
            }
        }

        private void OrderByBrandDowntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Rims_View order by Производитель DESC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void SellingRimsOrderByAmountUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Seling_rims_View order by Количество ASC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }

        }

        private void SellingRimsOrderByAmountDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Seling_rims_View order by Количество DESC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }
        }

        private void SellingRimsOrderByUPtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Seling_rims_View order by [Дата продажи] ASC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }

        }

        private void SellingRimsOrderByDowntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NEPHEW; Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string OrderByPrice = @"select * from Seling_rims_View order by [Дата продажи] DESC";
                SqlDataAdapter data = new SqlDataAdapter(OrderByPrice, connection);
                DataTable TableOrderByPrice = new DataTable();
                data.Fill(TableOrderByPrice);
                TableWindow.DataSource = TableOrderByPrice;

            }

        }
    }
}

 