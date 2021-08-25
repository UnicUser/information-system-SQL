namespace WindowsFormsApp12
{
    partial class EditReq1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReq1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.TableWindow2 = new System.Windows.Forms.DataGridView();
            this.номерЗапросаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полноеИмяКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сервисDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полноеИмяРаботникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОбслуживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяОбслуживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tire_Service_DB_Number = new WindowsFormsApp12.Tire_Service_DB_Number();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.workeraccountsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tire_Service_DB = new WindowsFormsApp12.Tire_Service_DB();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.serviceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatetextBox = new System.Windows.Forms.TextBox();
            this.TimetextBox = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customers_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Customers_ViewTableAdapter();
            this.worker_accounts_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Worker_accounts_ViewTableAdapter();
            this.service_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Service_ViewTableAdapter();
            this.requests_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DB_NumberTableAdapters.Requests_ViewTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB_Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeraccountsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersViewBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.TableWindow2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Title);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.DatetextBox);
            this.panel2.Controls.Add(this.TimetextBox);
            this.panel2.Controls.Add(this.Edit);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(12, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 582);
            this.panel2.TabIndex = 13;
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
            this.номерЗапросаDataGridViewTextBoxColumn,
            this.полноеИмяКлиентаDataGridViewTextBoxColumn,
            this.телефонныйНомерDataGridViewTextBoxColumn,
            this.сервисDataGridViewTextBoxColumn,
            this.полноеИмяРаботникаDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.датаОбслуживанияDataGridViewTextBoxColumn,
            this.времяОбслуживанияDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.TableWindow2.DataSource = this.requestsViewBindingSource;
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
            this.TableWindow2.Location = new System.Drawing.Point(23, 260);
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
            this.TableWindow2.TabIndex = 36;
            // 
            // номерЗапросаDataGridViewTextBoxColumn
            // 
            this.номерЗапросаDataGridViewTextBoxColumn.DataPropertyName = "Номер запроса";
            this.номерЗапросаDataGridViewTextBoxColumn.HeaderText = "Номер запроса";
            this.номерЗапросаDataGridViewTextBoxColumn.Name = "номерЗапросаDataGridViewTextBoxColumn";
            this.номерЗапросаDataGridViewTextBoxColumn.Width = 143;
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
            // сервисDataGridViewTextBoxColumn
            // 
            this.сервисDataGridViewTextBoxColumn.DataPropertyName = "Сервис";
            this.сервисDataGridViewTextBoxColumn.HeaderText = "Сервис";
            this.сервисDataGridViewTextBoxColumn.Name = "сервисDataGridViewTextBoxColumn";
            this.сервисDataGridViewTextBoxColumn.Width = 84;
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
            // датаОбслуживанияDataGridViewTextBoxColumn
            // 
            this.датаОбслуживанияDataGridViewTextBoxColumn.DataPropertyName = "Дата обслуживания";
            this.датаОбслуживанияDataGridViewTextBoxColumn.HeaderText = "Дата обслуживания";
            this.датаОбслуживанияDataGridViewTextBoxColumn.Name = "датаОбслуживанияDataGridViewTextBoxColumn";
            this.датаОбслуживанияDataGridViewTextBoxColumn.Width = 180;
            // 
            // времяОбслуживанияDataGridViewTextBoxColumn
            // 
            this.времяОбслуживанияDataGridViewTextBoxColumn.DataPropertyName = "Время обслуживания";
            this.времяОбслуживанияDataGridViewTextBoxColumn.HeaderText = "Время обслуживания";
            this.времяОбслуживанияDataGridViewTextBoxColumn.Name = "времяОбслуживанияDataGridViewTextBoxColumn";
            this.времяОбслуживанияDataGridViewTextBoxColumn.Width = 193;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 70;
            // 
            // requestsViewBindingSource
            // 
            this.requestsViewBindingSource.DataMember = "Requests_View";
            this.requestsViewBindingSource.DataSource = this.tire_Service_DB_Number;
            // 
            // tire_Service_DB_Number
            // 
            this.tire_Service_DB_Number.DataSetName = "Tire_Service_DB_Number";
            this.tire_Service_DB_Number.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(141, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Номер запроса к редактированию";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox4.DataSource = this.requestsViewBindingSource;
            this.comboBox4.DisplayMember = "Номер запроса";
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBox4.ForeColor = System.Drawing.Color.SlateGray;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(194, 465);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(243, 32);
            this.comboBox4.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(215, 510);
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
            this.label5.Location = new System.Drawing.Point(327, 182);
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
            this.label4.Location = new System.Drawing.Point(327, 123);
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
            this.label3.Location = new System.Drawing.Point(327, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Сервис";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(36, 123);
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
            this.label1.Location = new System.Drawing.Point(36, 61);
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
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox3.DataSource = this.workeraccountsViewBindingSource;
            this.comboBox3.DisplayMember = "Фамилия работника";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBox3.ForeColor = System.Drawing.Color.SlateGray;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(40, 147);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(243, 32);
            this.comboBox3.TabIndex = 26;
            // 
            // workeraccountsViewBindingSource
            // 
            this.workeraccountsViewBindingSource.DataMember = "Worker_accounts_View";
            this.workeraccountsViewBindingSource.DataSource = this.tire_Service_DB;
            // 
            // tire_Service_DB
            // 
            this.tire_Service_DB.DataSetName = "Tire_Service_DB";
            this.tire_Service_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox2.DataSource = this.serviceViewBindingSource;
            this.comboBox2.DisplayMember = "Сервис";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBox2.ForeColor = System.Drawing.Color.SlateGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(331, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(243, 32);
            this.comboBox2.TabIndex = 25;
            // 
            // serviceViewBindingSource
            // 
            this.serviceViewBindingSource.DataMember = "Service_View";
            this.serviceViewBindingSource.DataSource = this.tire_Service_DB;
            // 
            // DatetextBox
            // 
            this.DatetextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatetextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.DatetextBox.ForeColor = System.Drawing.Color.SlateGray;
            this.DatetextBox.Location = new System.Drawing.Point(331, 147);
            this.DatetextBox.Multiline = true;
            this.DatetextBox.Name = "DatetextBox";
            this.DatetextBox.Size = new System.Drawing.Size(243, 32);
            this.DatetextBox.TabIndex = 24;
            // 
            // TimetextBox
            // 
            this.TimetextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimetextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.TimetextBox.ForeColor = System.Drawing.Color.SlateGray;
            this.TimetextBox.Location = new System.Drawing.Point(331, 209);
            this.TimetextBox.Multiline = true;
            this.TimetextBox.Name = "TimetextBox";
            this.TimetextBox.Size = new System.Drawing.Size(243, 32);
            this.TimetextBox.TabIndex = 11;
            // 
            // Edit
            // 
            this.Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Edit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Edit.ForeColor = System.Drawing.Color.SlateGray;
            this.Edit.Location = new System.Drawing.Point(218, 530);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(195, 35);
            this.Edit.TabIndex = 23;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DataSource = this.customersViewBindingSource;
            this.comboBox1.DisplayMember = "Фамилия";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.Color.SlateGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 32);
            this.comboBox1.TabIndex = 12;
            // 
            // customersViewBindingSource
            // 
            this.customersViewBindingSource.DataMember = "Customers_View";
            this.customersViewBindingSource.DataSource = this.tire_Service_DB;
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
            this.panel1.Size = new System.Drawing.Size(630, 614);
            this.panel1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customers_ViewTableAdapter
            // 
            this.customers_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // worker_accounts_ViewTableAdapter
            // 
            this.worker_accounts_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // service_ViewTableAdapter
            // 
            this.service_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // requests_ViewTableAdapter
            // 
            this.requests_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // EditReq1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditReq1";
            this.Text = "TireServce - Редактировать запрос на обслуживание";
            this.Load += new System.EventHandler(this.EditReq1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB_Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeraccountsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersViewBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox DatetextBox;
        private System.Windows.Forms.TextBox TimetextBox;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBox4;
        private Tire_Service_DB tire_Service_DB;
        private System.Windows.Forms.BindingSource customersViewBindingSource;
        private Tire_Service_DBTableAdapters.Customers_ViewTableAdapter customers_ViewTableAdapter;
        private System.Windows.Forms.BindingSource workeraccountsViewBindingSource;
        private Tire_Service_DBTableAdapters.Worker_accounts_ViewTableAdapter worker_accounts_ViewTableAdapter;
        private System.Windows.Forms.BindingSource serviceViewBindingSource;
        private Tire_Service_DBTableAdapters.Service_ViewTableAdapter service_ViewTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView TableWindow2;
        private Tire_Service_DB_Number tire_Service_DB_Number;
        private System.Windows.Forms.BindingSource requestsViewBindingSource;
        private Tire_Service_DB_NumberTableAdapters.Requests_ViewTableAdapter requests_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗапросаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полноеИмяКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сервисDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полноеИмяРаботникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОбслуживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяОбслуживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}