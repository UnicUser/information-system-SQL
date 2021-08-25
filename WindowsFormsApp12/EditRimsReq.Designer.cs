namespace WindowsFormsApp12
{
    partial class EditRimsReq
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRimsReq));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.RimsComboBox = new System.Windows.Forms.ComboBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tire_Service_DB = new WindowsFormsApp12.Tire_Service_DB();
            this.rimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rimsTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.RimsTableAdapter();
            this.useraccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_accountsTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.User_accountsTableAdapter();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.CustomersTableAdapter();
            this.TableWindow2 = new System.Windows.Forms.DataGridView();
            this.RimsSellNumbercomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sellingrimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selling_rimsTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Selling_rimsTableAdapter();
            this.sellingRimsVew = new WindowsFormsApp12.SellingRimsVew();
            this.selingrimsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seling_rims_ViewTableAdapter = new WindowsFormsApp12.SellingRimsVewTableAdapters.Seling_rims_ViewTableAdapter();
            this.номерПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полноеИмяРаботникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полноеИмяКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.марикрвокаДискаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаЗаШтукуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingrimsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingRimsVew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selingrimsViewBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(630, 660);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.RimsSellNumbercomboBox);
            this.panel2.Controls.Add(this.TableWindow2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Title);
            this.panel2.Controls.Add(this.UserComboBox);
            this.panel2.Controls.Add(this.RimsComboBox);
            this.panel2.Controls.Add(this.DateTextBox);
            this.panel2.Controls.Add(this.TimeTextBox);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.CustomerComboBox);
            this.panel2.Location = new System.Drawing.Point(12, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 628);
            this.panel2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(220, 559);
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
            this.label5.Location = new System.Drawing.Point(399, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Время";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(396, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Дата";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(280, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Диски";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Работник";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(37, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Клиент";
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
            // UserComboBox
            // 
            this.UserComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserComboBox.DataSource = this.useraccountsBindingSource;
            this.UserComboBox.DisplayMember = "Full_worker_name";
            this.UserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.UserComboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(41, 161);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(277, 32);
            this.UserComboBox.TabIndex = 26;
            // 
            // RimsComboBox
            // 
            this.RimsComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RimsComboBox.DataSource = this.rimsBindingSource;
            this.RimsComboBox.DisplayMember = "RIms_name";
            this.RimsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RimsComboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.RimsComboBox.FormattingEnabled = true;
            this.RimsComboBox.Location = new System.Drawing.Point(41, 102);
            this.RimsComboBox.Name = "RimsComboBox";
            this.RimsComboBox.Size = new System.Drawing.Size(541, 32);
            this.RimsComboBox.TabIndex = 25;
            this.RimsComboBox.ValueMember = "RIms_name";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.DateTextBox.ForeColor = System.Drawing.Color.SlateGray;
            this.DateTextBox.Location = new System.Drawing.Point(403, 161);
            this.DateTextBox.Multiline = true;
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(179, 32);
            this.DateTextBox.TabIndex = 24;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.TimeTextBox.ForeColor = System.Drawing.Color.SlateGray;
            this.TimeTextBox.Location = new System.Drawing.Point(403, 223);
            this.TimeTextBox.Multiline = true;
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(179, 32);
            this.TimeTextBox.TabIndex = 11;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Add.ForeColor = System.Drawing.Color.SlateGray;
            this.Add.Location = new System.Drawing.Point(218, 579);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(195, 35);
            this.Add.TabIndex = 23;
            this.Add.Text = "Редактировать";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustomerComboBox.DataSource = this.customersBindingSource;
            this.CustomerComboBox.DisplayMember = "Full_customer_name";
            this.CustomerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.CustomerComboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(41, 223);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(277, 32);
            this.CustomerComboBox.TabIndex = 12;
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
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tire_Service_DB
            // 
            this.tire_Service_DB.DataSetName = "Tire_Service_DB";
            this.tire_Service_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rimsBindingSource
            // 
            this.rimsBindingSource.DataMember = "Rims";
            this.rimsBindingSource.DataSource = this.tire_Service_DB;
            // 
            // rimsTableAdapter
            // 
            this.rimsTableAdapter.ClearBeforeFill = true;
            // 
            // useraccountsBindingSource
            // 
            this.useraccountsBindingSource.DataMember = "User_accounts";
            this.useraccountsBindingSource.DataSource = this.tire_Service_DB;
            // 
            // user_accountsTableAdapter
            // 
            this.user_accountsTableAdapter.ClearBeforeFill = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.tire_Service_DB;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // TableWindow2
            // 
            this.TableWindow2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableWindow2.AutoGenerateColumns = false;
            this.TableWindow2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableWindow2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableWindow2.BackgroundColor = System.Drawing.Color.SlateGray;
            this.TableWindow2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableWindow2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableWindow2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableWindow2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерПродажиDataGridViewTextBoxColumn,
            this.полноеИмяРаботникаDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.полноеИмяКлиентаDataGridViewTextBoxColumn,
            this.телефонныйНомерDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.марикрвокаДискаDataGridViewTextBoxColumn,
            this.датаПродажиDataGridViewTextBoxColumn,
            this.времяПродажиDataGridViewTextBoxColumn,
            this.ценаЗаШтукуDataGridViewTextBoxColumn});
            this.TableWindow2.DataSource = this.selingrimsViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableWindow2.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableWindow2.EnableHeadersVisualStyles = false;
            this.TableWindow2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.TableWindow2.Location = new System.Drawing.Point(22, 400);
            this.TableWindow2.Name = "TableWindow2";
            this.TableWindow2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableWindow2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableWindow2.Size = new System.Drawing.Size(560, 156);
            this.TableWindow2.TabIndex = 45;
            // 
            // RimsSellNumbercomboBox
            // 
            this.RimsSellNumbercomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RimsSellNumbercomboBox.DataSource = this.selingrimsViewBindingSource;
            this.RimsSellNumbercomboBox.DisplayMember = "Номер продажи";
            this.RimsSellNumbercomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RimsSellNumbercomboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.RimsSellNumbercomboBox.FormattingEnabled = true;
            this.RimsSellNumbercomboBox.Location = new System.Drawing.Point(177, 333);
            this.RimsSellNumbercomboBox.Name = "RimsSellNumbercomboBox";
            this.RimsSellNumbercomboBox.Size = new System.Drawing.Size(277, 32);
            this.RimsSellNumbercomboBox.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(100, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(431, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Номер записи продажи к редактирвоанию";
            // 
            // sellingrimsBindingSource
            // 
            this.sellingrimsBindingSource.DataMember = "Selling_rims";
            this.sellingrimsBindingSource.DataSource = this.tire_Service_DB;
            // 
            // selling_rimsTableAdapter
            // 
            this.selling_rimsTableAdapter.ClearBeforeFill = true;
            // 
            // sellingRimsVew
            // 
            this.sellingRimsVew.DataSetName = "SellingRimsVew";
            this.sellingRimsVew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selingrimsViewBindingSource
            // 
            this.selingrimsViewBindingSource.DataMember = "Seling_rims_View";
            this.selingrimsViewBindingSource.DataSource = this.sellingRimsVew;
            // 
            // seling_rims_ViewTableAdapter
            // 
            this.seling_rims_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // номерПродажиDataGridViewTextBoxColumn
            // 
            this.номерПродажиDataGridViewTextBoxColumn.DataPropertyName = "Номер продажи";
            this.номерПродажиDataGridViewTextBoxColumn.HeaderText = "Номер продажи";
            this.номерПродажиDataGridViewTextBoxColumn.Name = "номерПродажиDataGridViewTextBoxColumn";
            this.номерПродажиDataGridViewTextBoxColumn.Width = 152;
            // 
            // полноеИмяРаботникаDataGridViewTextBoxColumn
            // 
            this.полноеИмяРаботникаDataGridViewTextBoxColumn.DataPropertyName = "Полное имя работника";
            this.полноеИмяРаботникаDataGridViewTextBoxColumn.HeaderText = "Полное имя работника";
            this.полноеИмяРаботникаDataGridViewTextBoxColumn.Name = "полноеИмяРаботникаDataGridViewTextBoxColumn";
            this.полноеИмяРаботникаDataGridViewTextBoxColumn.Width = 202;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.Width = 116;
            // 
            // полноеИмяКлиентаDataGridViewTextBoxColumn
            // 
            this.полноеИмяКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Полное имя клиента";
            this.полноеИмяКлиентаDataGridViewTextBoxColumn.HeaderText = "Полное имя клиента";
            this.полноеИмяКлиентаDataGridViewTextBoxColumn.Name = "полноеИмяКлиентаDataGridViewTextBoxColumn";
            this.полноеИмяКлиентаDataGridViewTextBoxColumn.Width = 184;
            // 
            // телефонныйНомерDataGridViewTextBoxColumn
            // 
            this.телефонныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Телефонный номер";
            this.телефонныйНомерDataGridViewTextBoxColumn.HeaderText = "Телефонный номер";
            this.телефонныйНомерDataGridViewTextBoxColumn.Name = "телефонныйНомерDataGridViewTextBoxColumn";
            this.телефонныйНомерDataGridViewTextBoxColumn.Width = 177;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.Width = 119;
            // 
            // марикрвокаДискаDataGridViewTextBoxColumn
            // 
            this.марикрвокаДискаDataGridViewTextBoxColumn.DataPropertyName = "Марикрвока диска";
            this.марикрвокаДискаDataGridViewTextBoxColumn.HeaderText = "Марикрвока диска";
            this.марикрвокаДискаDataGridViewTextBoxColumn.Name = "марикрвокаДискаDataGridViewTextBoxColumn";
            this.марикрвокаДискаDataGridViewTextBoxColumn.Width = 169;
            // 
            // датаПродажиDataGridViewTextBoxColumn
            // 
            this.датаПродажиDataGridViewTextBoxColumn.DataPropertyName = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.Name = "датаПродажиDataGridViewTextBoxColumn";
            this.датаПродажиDataGridViewTextBoxColumn.Width = 138;
            // 
            // времяПродажиDataGridViewTextBoxColumn
            // 
            this.времяПродажиDataGridViewTextBoxColumn.DataPropertyName = "Время продажи";
            this.времяПродажиDataGridViewTextBoxColumn.HeaderText = "Время продажи";
            this.времяПродажиDataGridViewTextBoxColumn.Name = "времяПродажиDataGridViewTextBoxColumn";
            this.времяПродажиDataGridViewTextBoxColumn.Width = 151;
            // 
            // ценаЗаШтукуDataGridViewTextBoxColumn
            // 
            this.ценаЗаШтукуDataGridViewTextBoxColumn.DataPropertyName = "Цена за штуку";
            this.ценаЗаШтукуDataGridViewTextBoxColumn.HeaderText = "Цена за штуку";
            this.ценаЗаШтукуDataGridViewTextBoxColumn.Name = "ценаЗаШтукуDataGridViewTextBoxColumn";
            this.ценаЗаШтукуDataGridViewTextBoxColumn.Width = 137;
            // 
            // EditRimsReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditRimsReq";
            this.Text = "TireService - Редактировать запрос продажи дисксов";
            this.Load += new System.EventHandler(this.EditRimsReq_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingrimsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingRimsVew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selingrimsViewBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.ComboBox RimsComboBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Tire_Service_DB tire_Service_DB;
        private System.Windows.Forms.BindingSource rimsBindingSource;
        private Tire_Service_DBTableAdapters.RimsTableAdapter rimsTableAdapter;
        private System.Windows.Forms.BindingSource useraccountsBindingSource;
        private Tire_Service_DBTableAdapters.User_accountsTableAdapter user_accountsTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Tire_Service_DBTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RimsSellNumbercomboBox;
        private System.Windows.Forms.DataGridView TableWindow2;
        private System.Windows.Forms.BindingSource sellingrimsBindingSource;
        private Tire_Service_DBTableAdapters.Selling_rimsTableAdapter selling_rimsTableAdapter;
        private SellingRimsVew sellingRimsVew;
        private System.Windows.Forms.BindingSource selingrimsViewBindingSource;
        private SellingRimsVewTableAdapters.Seling_rims_ViewTableAdapter seling_rims_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полноеИмяРаботникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полноеИмяКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn марикрвокаДискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаЗаШтукуDataGridViewTextBoxColumn;
    }
}