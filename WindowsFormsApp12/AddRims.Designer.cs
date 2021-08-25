namespace WindowsFormsApp12
{
    partial class AddRims
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRims));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.DIAcomboBox = new System.Windows.Forms.ComboBox();
            this.rimsDIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tire_Service_DBDataSet2 = new WindowsFormsApp12.Tire_Service_DBDataSet2();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DiametercomboBox = new System.Windows.Forms.ComboBox();
            this.rimsdiameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BoltscomboBox = new System.Windows.Forms.ComboBox();
            this.rimsBoltsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WidthcomboBox = new System.Windows.Forms.ComboBox();
            this.rimswidthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.MaterialcomboBox = new System.Windows.Forms.ComboBox();
            this.rimsmaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.rimstypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AmounttextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.BrandcomboBox = new System.Windows.Forms.ComboBox();
            this.rimsBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rims_BrandTableAdapter = new WindowsFormsApp12.Tire_Service_DBDataSet2TableAdapters.Rims_BrandTableAdapter();
            this.rims_typeTableAdapter = new WindowsFormsApp12.Tire_Service_DBDataSet2TableAdapters.Rims_typeTableAdapter();
            this.rims_materialTableAdapter = new WindowsFormsApp12.Tire_Service_DBDataSet2TableAdapters.Rims_materialTableAdapter();
            this.rims_widthTableAdapter = new WindowsFormsApp12.Tire_Service_DBDataSet2TableAdapters.Rims_widthTableAdapter();
            this.rims_diameterTableAdapter = new WindowsFormsApp12.Tire_Service_DBDataSet2TableAdapters.Rims_diameterTableAdapter();
            this.rims_BoltsTableAdapter = new WindowsFormsApp12.Tire_Service_DBDataSet2TableAdapters.Rims_BoltsTableAdapter();
            this.rims_DIATableAdapter = new WindowsFormsApp12.Tire_Service_DBDataSet2TableAdapters.Rims_DIATableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rimsDIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsdiameterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsBoltsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimswidthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsmaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimstypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsBrandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 511);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.DIAcomboBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.DiametercomboBox);
            this.panel2.Controls.Add(this.BoltscomboBox);
            this.panel2.Controls.Add(this.WidthcomboBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Title);
            this.panel2.Controls.Add(this.MaterialcomboBox);
            this.panel2.Controls.Add(this.TypecomboBox);
            this.panel2.Controls.Add(this.AmounttextBox);
            this.panel2.Controls.Add(this.PricetextBox);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.BrandcomboBox);
            this.panel2.Location = new System.Drawing.Point(12, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 475);
            this.panel2.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(36, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 24);
            this.label10.TabIndex = 41;
            this.label10.Text = "Параметры ступицы";
            // 
            // DIAcomboBox
            // 
            this.DIAcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DIAcomboBox.DataSource = this.rimsDIABindingSource;
            this.DIAcomboBox.DisplayMember = "DIA";
            this.DIAcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.DIAcomboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.DIAcomboBox.FormattingEnabled = true;
            this.DIAcomboBox.Location = new System.Drawing.Point(40, 269);
            this.DIAcomboBox.Name = "DIAcomboBox";
            this.DIAcomboBox.Size = new System.Drawing.Size(243, 32);
            this.DIAcomboBox.TabIndex = 40;
            // 
            // rimsDIABindingSource
            // 
            this.rimsDIABindingSource.DataMember = "Rims_DIA";
            this.rimsDIABindingSource.DataSource = this.tire_Service_DBDataSet2;
            // 
            // tire_Service_DBDataSet2
            // 
            this.tire_Service_DBDataSet2.DataSetName = "Tire_Service_DBDataSet2";
            this.tire_Service_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(36, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Диаметр диска";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(327, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "PCD (Крепёжн. параметры)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(327, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ширина диска";
            // 
            // DiametercomboBox
            // 
            this.DiametercomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DiametercomboBox.DataSource = this.rimsdiameterBindingSource;
            this.DiametercomboBox.DisplayMember = "Rim_diameter";
            this.DiametercomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.DiametercomboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.DiametercomboBox.FormattingEnabled = true;
            this.DiametercomboBox.Location = new System.Drawing.Point(40, 208);
            this.DiametercomboBox.Name = "DiametercomboBox";
            this.DiametercomboBox.Size = new System.Drawing.Size(243, 32);
            this.DiametercomboBox.TabIndex = 36;
            // 
            // rimsdiameterBindingSource
            // 
            this.rimsdiameterBindingSource.DataMember = "Rims_diameter";
            this.rimsdiameterBindingSource.DataSource = this.tire_Service_DBDataSet2;
            // 
            // BoltscomboBox
            // 
            this.BoltscomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BoltscomboBox.DataSource = this.rimsBoltsBindingSource;
            this.BoltscomboBox.DisplayMember = "LK_x_PCD";
            this.BoltscomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BoltscomboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.BoltscomboBox.FormattingEnabled = true;
            this.BoltscomboBox.Location = new System.Drawing.Point(331, 208);
            this.BoltscomboBox.Name = "BoltscomboBox";
            this.BoltscomboBox.Size = new System.Drawing.Size(243, 32);
            this.BoltscomboBox.TabIndex = 35;
            // 
            // rimsBoltsBindingSource
            // 
            this.rimsBoltsBindingSource.DataMember = "Rims_Bolts";
            this.rimsBoltsBindingSource.DataSource = this.tire_Service_DBDataSet2;
            // 
            // WidthcomboBox
            // 
            this.WidthcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WidthcomboBox.DataSource = this.rimswidthBindingSource;
            this.WidthcomboBox.DisplayMember = "Rim_width";
            this.WidthcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.WidthcomboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.WidthcomboBox.FormattingEnabled = true;
            this.WidthcomboBox.Location = new System.Drawing.Point(331, 147);
            this.WidthcomboBox.Name = "WidthcomboBox";
            this.WidthcomboBox.Size = new System.Drawing.Size(243, 32);
            this.WidthcomboBox.TabIndex = 34;
            // 
            // rimswidthBindingSource
            // 
            this.rimswidthBindingSource.DataMember = "Rims_width";
            this.rimswidthBindingSource.DataSource = this.tire_Service_DBDataSet2;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(219, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(327, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Цена (руб.)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(327, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Количество";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(327, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Тип";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(36, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Материал";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Марка";
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Font = new System.Drawing.Font("Agency FB", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.SlateGray;
            this.Title.Location = new System.Drawing.Point(221, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(189, 52);
            this.Title.TabIndex = 27;
            this.Title.Text = "TireService";
            // 
            // MaterialcomboBox
            // 
            this.MaterialcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MaterialcomboBox.DataSource = this.rimsmaterialBindingSource;
            this.MaterialcomboBox.DisplayMember = "Rim_material";
            this.MaterialcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.MaterialcomboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.MaterialcomboBox.FormattingEnabled = true;
            this.MaterialcomboBox.Location = new System.Drawing.Point(40, 147);
            this.MaterialcomboBox.Name = "MaterialcomboBox";
            this.MaterialcomboBox.Size = new System.Drawing.Size(243, 32);
            this.MaterialcomboBox.TabIndex = 26;
            // 
            // rimsmaterialBindingSource
            // 
            this.rimsmaterialBindingSource.DataMember = "Rims_material";
            this.rimsmaterialBindingSource.DataSource = this.tire_Service_DBDataSet2;
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TypecomboBox.DataSource = this.rimstypeBindingSource;
            this.TypecomboBox.DisplayMember = "Type";
            this.TypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.TypecomboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Location = new System.Drawing.Point(331, 88);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(243, 32);
            this.TypecomboBox.TabIndex = 25;
            // 
            // rimstypeBindingSource
            // 
            this.rimstypeBindingSource.DataMember = "Rims_type";
            this.rimstypeBindingSource.DataSource = this.tire_Service_DBDataSet2;
            // 
            // AmounttextBox
            // 
            this.AmounttextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AmounttextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmounttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.AmounttextBox.ForeColor = System.Drawing.Color.SlateGray;
            this.AmounttextBox.Location = new System.Drawing.Point(331, 269);
            this.AmounttextBox.Multiline = true;
            this.AmounttextBox.Name = "AmounttextBox";
            this.AmounttextBox.Size = new System.Drawing.Size(243, 32);
            this.AmounttextBox.TabIndex = 24;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PricetextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PricetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.PricetextBox.ForeColor = System.Drawing.Color.SlateGray;
            this.PricetextBox.Location = new System.Drawing.Point(331, 332);
            this.PricetextBox.Multiline = true;
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(243, 32);
            this.PricetextBox.TabIndex = 11;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Add.ForeColor = System.Drawing.Color.SlateGray;
            this.Add.Location = new System.Drawing.Point(218, 425);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(195, 35);
            this.Add.TabIndex = 23;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // BrandcomboBox
            // 
            this.BrandcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrandcomboBox.DataSource = this.rimsBrandBindingSource;
            this.BrandcomboBox.DisplayMember = "Brand";
            this.BrandcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BrandcomboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.BrandcomboBox.FormattingEnabled = true;
            this.BrandcomboBox.Location = new System.Drawing.Point(40, 88);
            this.BrandcomboBox.Name = "BrandcomboBox";
            this.BrandcomboBox.Size = new System.Drawing.Size(243, 32);
            this.BrandcomboBox.TabIndex = 12;
            // 
            // rimsBrandBindingSource
            // 
            this.rimsBrandBindingSource.DataMember = "Rims_Brand";
            this.rimsBrandBindingSource.DataSource = this.tire_Service_DBDataSet2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rims_BrandTableAdapter
            // 
            this.rims_BrandTableAdapter.ClearBeforeFill = true;
            // 
            // rims_typeTableAdapter
            // 
            this.rims_typeTableAdapter.ClearBeforeFill = true;
            // 
            // rims_materialTableAdapter
            // 
            this.rims_materialTableAdapter.ClearBeforeFill = true;
            // 
            // rims_widthTableAdapter
            // 
            this.rims_widthTableAdapter.ClearBeforeFill = true;
            // 
            // rims_diameterTableAdapter
            // 
            this.rims_diameterTableAdapter.ClearBeforeFill = true;
            // 
            // rims_BoltsTableAdapter
            // 
            this.rims_BoltsTableAdapter.ClearBeforeFill = true;
            // 
            // rims_DIATableAdapter
            // 
            this.rims_DIATableAdapter.ClearBeforeFill = true;
            // 
            // AddRims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 533);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRims";
            this.Text = "TireService - Добавить диски";
            this.Load += new System.EventHandler(this.AddRims_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rimsDIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsdiameterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsBoltsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimswidthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsmaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimstypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsBrandBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox MaterialcomboBox;
        private System.Windows.Forms.ComboBox TypecomboBox;
        private System.Windows.Forms.TextBox AmounttextBox;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox BrandcomboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox DIAcomboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DiametercomboBox;
        private System.Windows.Forms.ComboBox BoltscomboBox;
        private System.Windows.Forms.ComboBox WidthcomboBox;
        private Tire_Service_DBDataSet2 tire_Service_DBDataSet2;
        private System.Windows.Forms.BindingSource rimsBrandBindingSource;
        private Tire_Service_DBDataSet2TableAdapters.Rims_BrandTableAdapter rims_BrandTableAdapter;
        private System.Windows.Forms.BindingSource rimstypeBindingSource;
        private Tire_Service_DBDataSet2TableAdapters.Rims_typeTableAdapter rims_typeTableAdapter;
        private System.Windows.Forms.BindingSource rimsmaterialBindingSource;
        private Tire_Service_DBDataSet2TableAdapters.Rims_materialTableAdapter rims_materialTableAdapter;
        private System.Windows.Forms.BindingSource rimswidthBindingSource;
        private Tire_Service_DBDataSet2TableAdapters.Rims_widthTableAdapter rims_widthTableAdapter;
        private System.Windows.Forms.BindingSource rimsdiameterBindingSource;
        private Tire_Service_DBDataSet2TableAdapters.Rims_diameterTableAdapter rims_diameterTableAdapter;
        private System.Windows.Forms.BindingSource rimsBoltsBindingSource;
        private Tire_Service_DBDataSet2TableAdapters.Rims_BoltsTableAdapter rims_BoltsTableAdapter;
        private System.Windows.Forms.BindingSource rimsDIABindingSource;
        private Tire_Service_DBDataSet2TableAdapters.Rims_DIATableAdapter rims_DIATableAdapter;
    }
}