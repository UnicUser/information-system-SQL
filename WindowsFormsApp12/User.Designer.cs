namespace WindowsFormsApp12
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SellingRimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CleanTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddReqServToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RimsReqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCustomertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditReqtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditRimstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditRimsReqtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCustomertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteReqtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRimstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRimsReqtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintThisDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TableWindow = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printthisDocument = new System.Drawing.Printing.PrintDocument();
            this.tire_Service_DB = new WindowsFormsApp12.Tire_Service_DB();
            this.customersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customers_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Customers_ViewTableAdapter();
            this.requestsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requests_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Requests_ViewTableAdapter();
            this.serviceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.service_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Service_ViewTableAdapter();
            this.selingrimsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seling_rims_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Seling_rims_ViewTableAdapter();
            this.rimsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rims_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Rims_ViewTableAdapter();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selingrimsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem,
            this.ShowToolStripMenuItem,
            this.recToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общаяToolStripMenuItem,
            this.пользовательToolStripMenuItem});
            this.информацияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // общаяToolStripMenuItem
            // 
            this.общаяToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.общаяToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.общаяToolStripMenuItem.Name = "общаяToolStripMenuItem";
            this.общаяToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.общаяToolStripMenuItem.Text = "Общая";
            this.общаяToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.пользовательToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.пользовательToolStripMenuItem.Text = "\"Пользователь\"";
            this.пользовательToolStripMenuItem.Click += new System.EventHandler(this.UserInfoToolStripMenuItem_Click);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientsToolStripMenuItem,
            this.RequestToolStripMenuItem,
            this.ServiceToolStripMenuItem1,
            this.SellingRimsToolStripMenuItem,
            this.RimsToolStripMenuItem,
            this.CleanTableToolStripMenuItem,
            this.RefreshToolStripMenuItem});
            this.ShowToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.ShowToolStripMenuItem.Text = "Просмотреть";
            // 
            // ClientsToolStripMenuItem
            // 
            this.ClientsToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.ClientsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            this.ClientsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ClientsToolStripMenuItem.Text = "Клиенты";
            this.ClientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // RequestToolStripMenuItem
            // 
            this.RequestToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.RequestToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem";
            this.RequestToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.RequestToolStripMenuItem.Text = "Обслуживание";
            this.RequestToolStripMenuItem.Click += new System.EventHandler(this.RequestToolStripMenuItem_Click);
            // 
            // ServiceToolStripMenuItem1
            // 
            this.ServiceToolStripMenuItem1.BackColor = System.Drawing.Color.SlateGray;
            this.ServiceToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServiceToolStripMenuItem1.Name = "ServiceToolStripMenuItem1";
            this.ServiceToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.ServiceToolStripMenuItem1.Text = "Услуги";
            this.ServiceToolStripMenuItem1.Click += new System.EventHandler(this.ServiceToolStripMenuItem_Click);
            // 
            // SellingRimsToolStripMenuItem
            // 
            this.SellingRimsToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.SellingRimsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SellingRimsToolStripMenuItem.Name = "SellingRimsToolStripMenuItem";
            this.SellingRimsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.SellingRimsToolStripMenuItem.Text = "Продажа дисков";
            this.SellingRimsToolStripMenuItem.Click += new System.EventHandler(this.SellingRimsToolStripMenuItem_Click);
            // 
            // RimsToolStripMenuItem
            // 
            this.RimsToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.RimsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RimsToolStripMenuItem.Name = "RimsToolStripMenuItem";
            this.RimsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.RimsToolStripMenuItem.Text = "Диски";
            this.RimsToolStripMenuItem.Click += new System.EventHandler(this.RimsToolStripMenuItem_Click);
            // 
            // CleanTableToolStripMenuItem
            // 
            this.CleanTableToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.CleanTableToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CleanTableToolStripMenuItem.Name = "CleanTableToolStripMenuItem";
            this.CleanTableToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.CleanTableToolStripMenuItem.Text = "Очистить таблицу";
            this.CleanTableToolStripMenuItem.Click += new System.EventHandler(this.CleanTableToolStripMenuItem_Click);
            // 
            // recToolStripMenuItem
            // 
            this.recToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.PrintThisDoc});
            this.recToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recToolStripMenuItem.Name = "recToolStripMenuItem";
            this.recToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.recToolStripMenuItem.Text = "Учёт";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.AddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCustomerToolStripMenuItem,
            this.AddReqServToolStripMenuItem,
            this.AddRimsToolStripMenuItem,
            this.RimsReqToolStripMenuItem});
            this.AddToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.AddToolStripMenuItem.Text = "Добавить запись";
            // 
            // AddCustomerToolStripMenuItem
            // 
            this.AddCustomerToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.AddCustomerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddCustomerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem";
            this.AddCustomerToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.AddCustomerToolStripMenuItem.Text = "Клиент";
            this.AddCustomerToolStripMenuItem.Click += new System.EventHandler(this.AddCustomerToolStripMenuItem_Click);
            // 
            // AddReqServToolStripMenuItem
            // 
            this.AddReqServToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.AddReqServToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddReqServToolStripMenuItem.Name = "AddReqServToolStripMenuItem";
            this.AddReqServToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.AddReqServToolStripMenuItem.Text = "Учёт и запись на обслуживание";
            this.AddReqServToolStripMenuItem.Click += new System.EventHandler(this.AddReqServToolStripMenuItem_Click_1);
            // 
            // AddRimsToolStripMenuItem
            // 
            this.AddRimsToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.AddRimsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddRimsToolStripMenuItem.Name = "AddRimsToolStripMenuItem";
            this.AddRimsToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.AddRimsToolStripMenuItem.Text = "Пополнение на складе";
            this.AddRimsToolStripMenuItem.Click += new System.EventHandler(this.AddRimsToolStripMenuItem_Click);
            // 
            // RimsReqToolStripMenuItem
            // 
            this.RimsReqToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.RimsReqToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RimsReqToolStripMenuItem.Name = "RimsReqToolStripMenuItem";
            this.RimsReqToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.RimsReqToolStripMenuItem.Text = "Продажа дисков";
            this.RimsReqToolStripMenuItem.Click += new System.EventHandler(this.RimsReqToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCustomertoolStripMenuItem,
            this.EditReqtoolStripMenuItem,
            this.EditRimstoolStripMenuItem,
            this.EditRimsReqtoolStripMenuItem});
            this.EditToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.EditToolStripMenuItem.Text = "Редактировать запись";
            // 
            // EditCustomertoolStripMenuItem
            // 
            this.EditCustomertoolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.EditCustomertoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditCustomertoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditCustomertoolStripMenuItem.Name = "EditCustomertoolStripMenuItem";
            this.EditCustomertoolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.EditCustomertoolStripMenuItem.Text = "Клиент";
            this.EditCustomertoolStripMenuItem.Click += new System.EventHandler(this.EditCustomertoolStripMenuItem_Click);
            // 
            // EditReqtoolStripMenuItem
            // 
            this.EditReqtoolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.EditReqtoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditReqtoolStripMenuItem.Name = "EditReqtoolStripMenuItem";
            this.EditReqtoolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.EditReqtoolStripMenuItem.Text = "Учёт и запись на обслуживание";
            this.EditReqtoolStripMenuItem.Click += new System.EventHandler(this.EditReqtoolStripMenuItem_Click);
            // 
            // EditRimstoolStripMenuItem
            // 
            this.EditRimstoolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.EditRimstoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditRimstoolStripMenuItem.Name = "EditRimstoolStripMenuItem";
            this.EditRimstoolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.EditRimstoolStripMenuItem.Text = "Пополнение на складе";
            this.EditRimstoolStripMenuItem.Click += new System.EventHandler(this.EditRimstoolStripMenuItem_Click);
            // 
            // EditRimsReqtoolStripMenuItem
            // 
            this.EditRimsReqtoolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.EditRimsReqtoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditRimsReqtoolStripMenuItem.Name = "EditRimsReqtoolStripMenuItem";
            this.EditRimsReqtoolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.EditRimsReqtoolStripMenuItem.Text = "Продажа дисков";
            this.EditRimsReqtoolStripMenuItem.Click += new System.EventHandler(this.EditRimsReqtoolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.DeleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteCustomertoolStripMenuItem,
            this.DeleteReqtoolStripMenuItem,
            this.DeleteRimstoolStripMenuItem,
            this.DeleteRimsReqtoolStripMenuItem});
            this.DeleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить запись";
            // 
            // DeleteCustomertoolStripMenuItem
            // 
            this.DeleteCustomertoolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.DeleteCustomertoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteCustomertoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteCustomertoolStripMenuItem.Name = "DeleteCustomertoolStripMenuItem";
            this.DeleteCustomertoolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.DeleteCustomertoolStripMenuItem.Text = "Клиент";
            this.DeleteCustomertoolStripMenuItem.Click += new System.EventHandler(this.DeleteCustomertoolStripMenuItem_Click);
            // 
            // DeleteReqtoolStripMenuItem
            // 
            this.DeleteReqtoolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.DeleteReqtoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteReqtoolStripMenuItem.Name = "DeleteReqtoolStripMenuItem";
            this.DeleteReqtoolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.DeleteReqtoolStripMenuItem.Text = "Учёт и запись на обслуживание";
            this.DeleteReqtoolStripMenuItem.Click += new System.EventHandler(this.DeleteReqtoolStripMenuItem_Click);
            // 
            // DeleteRimstoolStripMenuItem
            // 
            this.DeleteRimstoolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.DeleteRimstoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteRimstoolStripMenuItem.Name = "DeleteRimstoolStripMenuItem";
            this.DeleteRimstoolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.DeleteRimstoolStripMenuItem.Text = "Пополнение на складе";
            this.DeleteRimstoolStripMenuItem.Click += new System.EventHandler(this.DeleteRimstoolStripMenuItem_Click);
            // 
            // DeleteRimsReqtoolStripMenuItem
            // 
            this.DeleteRimsReqtoolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.DeleteRimsReqtoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteRimsReqtoolStripMenuItem.Name = "DeleteRimsReqtoolStripMenuItem";
            this.DeleteRimsReqtoolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.DeleteRimsReqtoolStripMenuItem.Text = "Продажа дисков";
            this.DeleteRimsReqtoolStripMenuItem.Click += new System.EventHandler(this.DeleteRimsReqtoolStripMenuItem_Click);
            // 
            // PrintThisDoc
            // 
            this.PrintThisDoc.BackColor = System.Drawing.Color.SlateGray;
            this.PrintThisDoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintThisDoc.Name = "PrintThisDoc";
            this.PrintThisDoc.Size = new System.Drawing.Size(313, 22);
            this.PrintThisDoc.Text = "Распечатать текущий документ";
            this.PrintThisDoc.Click += new System.EventHandler(this.PrintThisDocToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.TableWindow);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 426);
            this.panel1.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.SearchButton.ForeColor = System.Drawing.Color.SlateGray;
            this.SearchButton.Location = new System.Drawing.Point(192, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(103, 30);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TableWindow
            // 
            this.TableWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableWindow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableWindow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableWindow.BackgroundColor = System.Drawing.Color.SlateGray;
            this.TableWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableWindow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableWindow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableWindow.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableWindow.EnableHeadersVisualStyles = false;
            this.TableWindow.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.TableWindow.Location = new System.Drawing.Point(12, 41);
            this.TableWindow.Name = "TableWindow";
            this.TableWindow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableWindow.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableWindow.Size = new System.Drawing.Size(736, 373);
            this.TableWindow.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.SlateGray;
            this.textBox1.Location = new System.Drawing.Point(12, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 30);
            this.textBox1.TabIndex = 16;
            // 
            // tire_Service_DB
            // 
            this.tire_Service_DB.DataSetName = "Tire_Service_DB";
            this.tire_Service_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersViewBindingSource
            // 
            this.customersViewBindingSource.DataMember = "Customers_View";
            this.customersViewBindingSource.DataSource = this.tire_Service_DB;
            // 
            // customers_ViewTableAdapter
            // 
            this.customers_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // requestsViewBindingSource
            // 
            this.requestsViewBindingSource.DataMember = "Requests_View";
            this.requestsViewBindingSource.DataSource = this.tire_Service_DB;
            // 
            // requests_ViewTableAdapter
            // 
            this.requests_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // serviceViewBindingSource
            // 
            this.serviceViewBindingSource.DataMember = "Service_View";
            this.serviceViewBindingSource.DataSource = this.tire_Service_DB;
            // 
            // service_ViewTableAdapter
            // 
            this.service_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // selingrimsViewBindingSource
            // 
            this.selingrimsViewBindingSource.DataMember = "Seling_rims_View";
            this.selingrimsViewBindingSource.DataSource = this.tire_Service_DB;
            // 
            // seling_rims_ViewTableAdapter
            // 
            this.seling_rims_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // rimsViewBindingSource
            // 
            this.rimsViewBindingSource.DataMember = "Rims_View";
            this.rimsViewBindingSource.DataSource = this.tire_Service_DB;
            // 
            // rims_ViewTableAdapter
            // 
            this.rims_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.RefreshToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.RefreshToolStripMenuItem.Text = "Обновить";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User";
            this.Text = "TireService - Пользователь";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selingrimsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellingRimsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RimsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.DataGridView TableWindow;
        private System.Windows.Forms.ToolStripMenuItem recToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddReqServToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddRimsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RimsReqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CleanTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditReqtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditRimstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditRimsReqtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteReqtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteRimstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteRimsReqtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintThisDoc;
        private System.Drawing.Printing.PrintDocument printthisDocument;

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem AddCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCustomertoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCustomertoolStripMenuItem;
        private Tire_Service_DB tire_Service_DB;
        private System.Windows.Forms.BindingSource customersViewBindingSource;
        private Tire_Service_DBTableAdapters.Customers_ViewTableAdapter customers_ViewTableAdapter;
        private System.Windows.Forms.BindingSource requestsViewBindingSource;
        private Tire_Service_DBTableAdapters.Requests_ViewTableAdapter requests_ViewTableAdapter;
        private System.Windows.Forms.BindingSource serviceViewBindingSource;
        private Tire_Service_DBTableAdapters.Service_ViewTableAdapter service_ViewTableAdapter;
        private System.Windows.Forms.BindingSource selingrimsViewBindingSource;
        private Tire_Service_DBTableAdapters.Seling_rims_ViewTableAdapter seling_rims_ViewTableAdapter;
        private System.Windows.Forms.BindingSource rimsViewBindingSource;
        private Tire_Service_DBTableAdapters.Rims_ViewTableAdapter rims_ViewTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
    }
}