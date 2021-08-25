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
    public partial class EditRims : Form
    {
        public EditRims()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=NEPHEW;Initial Catalog=Tire Service DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Rims_View_check;", connection);
                SqlDataReader reader1 = command.ExecuteReader();
                while (reader1.Read())
                {
                    string vibeBrand = reader1["Brand"].ToString();
                    string vibeMaterial = reader1["Rim_material"].ToString();
                    string vibeType = reader1["Type"].ToString();
                    string vibeWidth = reader1["Rim_width"].ToString();
                    string vibeDiameter = reader1["Rim_diameter"].ToString();
                    string vibeBolts = reader1["LK_x_PCD"].ToString();
                    string vibeDia = reader1["DIA"].ToString();

                    if (BrandcomboBox.Text == vibeBrand && MaterialcomboBox.Text == vibeMaterial && DiametercomboBox.Text == vibeDiameter
                    && DIAcomboBox.Text == vibeDia && TypecomboBox.Text == vibeType && WidthcomboBox.Text == vibeWidth && BoltscomboBox.Text == vibeBolts)
                    {

                        label9.Text = "Такая запись уже существует";
                        return;

                    }
                }

                reader1.Close();

                if (!string.IsNullOrEmpty(PricetextBox.Text) && !string.IsNullOrEmpty(AmounttextBox.Text))
                {
                    SqlCommand UPcommand = new SqlCommand("Update Rims set id_rims_brand = @id_rims_brand," + "id_rims_material = @id_rims_material," + " id_rims_type = @id_rims_type," + 
                    "id_rims_width = @id_rims_width," + "id_rims_diameter = @id_rims_diameter," + " id_rims_bolts = @id_rims_bolts," + "id_rims_DIA = @id_rims_DIA,"  + "Amount = @Amount," + "Price_per_one = @Price_per_one where RIms_name = @RIms_name ", connection);
                     UPcommand.Parameters.AddWithValue("@RIms_name", RImsNamecomboBox.Text);

                    if (!string.IsNullOrEmpty(BrandcomboBox.Text))
                    {
                        SqlCommand Id_rims_brand = new SqlCommand("select id_rims_brand from Rims_Brand where Brand = @Brand", connection);

                        Id_rims_brand.Parameters.AddWithValue("@Brand", BrandcomboBox.Text);
                        SqlDataReader reader = Id_rims_brand.ExecuteReader();

                        while (reader.Read())
                        {
                            string ID1_Rims_brand = reader["id_rims_brand"].ToString();
                            UPcommand.Parameters.AddWithValue("@id_rims_brand", ID1_Rims_brand);

                        }
                        reader.Close();
                        Id_rims_brand.ExecuteNonQuery();

                    }

                    if (!string.IsNullOrEmpty(MaterialcomboBox.Text))
                    {
                        SqlCommand Id_rims_material = new SqlCommand("select id_rims_material from Rims_material where Rim_material = @Rim_material", connection);

                        Id_rims_material.Parameters.AddWithValue("@Rim_material", MaterialcomboBox.Text);
                        SqlDataReader reader = Id_rims_material.ExecuteReader();

                        while (reader.Read())
                        {
                            string ID1_Rims_material = reader["id_rims_material"].ToString();
                            UPcommand.Parameters.AddWithValue("@id_rims_material", ID1_Rims_material);

                        }
                        reader.Close();
                        Id_rims_material.ExecuteNonQuery();

                    }

                    if (!string.IsNullOrEmpty(TypecomboBox.Text))
                    {
                        SqlCommand Id_rims_type = new SqlCommand("select id_rims_type from Rims_type where Type = @Type", connection);

                        Id_rims_type.Parameters.AddWithValue("@Type", TypecomboBox.Text);
                        SqlDataReader reader = Id_rims_type.ExecuteReader();

                        while (reader.Read())
                        {
                            string ID1_Rims_type = reader["id_rims_type"].ToString();
                            UPcommand.Parameters.AddWithValue("@id_rims_type", ID1_Rims_type);

                        }
                        reader.Close();
                        Id_rims_type.ExecuteNonQuery();

                    }

                    if (!string.IsNullOrEmpty(WidthcomboBox.Text))
                    {
                        SqlCommand Id_rims_width = new SqlCommand("select id_rims_width from Rims_width where Rim_width = @Rim_width", connection);

                        Id_rims_width.Parameters.AddWithValue("@Rim_width", WidthcomboBox.Text);
                        SqlDataReader reader = Id_rims_width.ExecuteReader();

                        while (reader.Read())
                        {
                            string ID1_Rims_width = reader["id_rims_width"].ToString();
                            UPcommand.Parameters.AddWithValue("@id_rims_width", ID1_Rims_width);

                        }
                        reader.Close();
                        Id_rims_width.ExecuteNonQuery();

                    }

                    if (!string.IsNullOrEmpty(BoltscomboBox.Text))
                    {
                        SqlCommand Id_rims_bolts = new SqlCommand("select id_rims_bolts from Rims_Bolts where LK_x_PCD = @LK_x_PCD", connection);

                        Id_rims_bolts.Parameters.AddWithValue("@LK_x_PCD", BoltscomboBox.Text);
                        SqlDataReader reader = Id_rims_bolts.ExecuteReader();

                        while (reader.Read())
                        {
                            string ID1_Rims_bolts = reader["id_rims_bolts"].ToString();
                            UPcommand.Parameters.AddWithValue("@id_rims_bolts", ID1_Rims_bolts);

                        }
                        reader.Close();
                        Id_rims_bolts.ExecuteNonQuery();

                    }

                    if (!string.IsNullOrEmpty(DiametercomboBox.Text))
                    {
                        SqlCommand Id_rims_diameter = new SqlCommand("select id_rims_diameter from Rims_diameter where Rim_diameter = @Rim_diameter", connection);

                        Id_rims_diameter.Parameters.AddWithValue("@Rim_diameter", DiametercomboBox.Text);
                        SqlDataReader reader = Id_rims_diameter.ExecuteReader();

                        while (reader.Read())
                        {
                            string ID1_Rims_diameter = reader["id_rims_diameter"].ToString();
                            UPcommand.Parameters.AddWithValue("@id_rims_diameter", ID1_Rims_diameter);

                        }
                        reader.Close();
                        Id_rims_diameter.ExecuteNonQuery();

                    }

                    if (!string.IsNullOrEmpty(DIAcomboBox.Text))
                    {
                        SqlCommand Id_rims_DIA = new SqlCommand("select id_Rims_DIA from Rims_DIA where DIA = @DIA", connection);

                        Id_rims_DIA.Parameters.AddWithValue("@DIA", DIAcomboBox.Text);
                        SqlDataReader reader = Id_rims_DIA.ExecuteReader();

                        while (reader.Read())
                        {
                            string ID1_Rims_diameter = reader["id_Rims_DIA"].ToString();
                            UPcommand.Parameters.AddWithValue("@id_Rims_DIA", ID1_Rims_diameter);

                        }
                        reader.Close();
                        Id_rims_DIA.ExecuteNonQuery();

                    }

                    if (!string.IsNullOrEmpty(AmounttextBox.Text))
                    {
                        UPcommand.Parameters.AddWithValue("@Amount", AmounttextBox.Text);

                    }

                    if (!string.IsNullOrEmpty(PricetextBox.Text))
                    {
                        UPcommand.Parameters.AddWithValue("@Price_per_one", PricetextBox.Text);
                    }

                    this.Hide();
                    UPcommand.ExecuteNonQuery();
                    connection.Close();

                }

                if (string.IsNullOrEmpty(PricetextBox.Text) || string.IsNullOrEmpty(AmounttextBox.Text))
                {
                    label9.Text = "Заполните все поля";
                }

            }

        }

        private void EditRims_Load(object sender, EventArgs e)
        {
            this.rimsTableAdapter.Fill(this.tire_Service_DB.Rims);
            this.rims_ViewTableAdapter.Fill(this.tire_Service_DB.Rims_View);
            this.rims_DIATableAdapter.Fill(this.tire_Service_DB.Rims_DIA);
            this.rims_diameterTableAdapter.Fill(this.tire_Service_DB.Rims_diameter);
            this.rims_materialTableAdapter.Fill(this.tire_Service_DB.Rims_material);
            this.rims_BrandTableAdapter.Fill(this.tire_Service_DB.Rims_Brand);
            this.rims_BoltsTableAdapter.Fill(this.tire_Service_DB.Rims_Bolts);
            this.rims_widthTableAdapter.Fill(this.tire_Service_DB.Rims_width);
            this.rims_typeTableAdapter.Fill(this.tire_Service_DB.Rims_type);

        }
    }
}
