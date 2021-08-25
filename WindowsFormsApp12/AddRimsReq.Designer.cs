namespace WindowsFormsApp12
{
    partial class AddRimsReq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRimsReq));
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
            this.useraccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tire_Service_DB = new WindowsFormsApp12.Tire_Service_DB();
            this.RimsComboBox = new System.Windows.Forms.ComboBox();
            this.rimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.user_accountsTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.User_accountsTableAdapter();
            this.customersTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.CustomersTableAdapter();
            this.rimsTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.RimsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(630, 483);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
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
            this.panel2.Size = new System.Drawing.Size(606, 451);
            this.panel2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(220, 382);
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
            this.label5.Location = new System.Drawing.Point(279, 306);
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
            this.label4.Location = new System.Drawing.Point(286, 244);
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
            this.label3.Location = new System.Drawing.Point(280, 63);
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
            this.label2.Location = new System.Drawing.Point(264, 123);
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
            this.label1.Location = new System.Drawing.Point(275, 182);
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
            this.UserComboBox.Location = new System.Drawing.Point(177, 147);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(277, 32);
            this.UserComboBox.TabIndex = 26;
            // 
            // useraccountsBindingSource
            // 
            this.useraccountsBindingSource.DataMember = "User_accounts";
            this.useraccountsBindingSource.DataSource = this.tire_Service_DB;
            // 
            // tire_Service_DB
            // 
            this.tire_Service_DB.DataSetName = "Tire_Service_DB";
            this.tire_Service_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RimsComboBox
            // 
            this.RimsComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RimsComboBox.DataSource = this.rimsBindingSource;
            this.RimsComboBox.DisplayMember = "RIms_name";
            this.RimsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RimsComboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.RimsComboBox.FormattingEnabled = true;
            this.RimsComboBox.Location = new System.Drawing.Point(41, 88);
            this.RimsComboBox.Name = "RimsComboBox";
            this.RimsComboBox.Size = new System.Drawing.Size(541, 32);
            this.RimsComboBox.TabIndex = 25;
            // 
            // rimsBindingSource
            // 
            this.rimsBindingSource.DataMember = "Rims";
            this.rimsBindingSource.DataSource = this.tire_Service_DB;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.DateTextBox.ForeColor = System.Drawing.Color.SlateGray;
            this.DateTextBox.Location = new System.Drawing.Point(226, 271);
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
            this.TimeTextBox.Location = new System.Drawing.Point(226, 333);
            this.TimeTextBox.Multiline = true;
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(179, 32);
            this.TimeTextBox.TabIndex = 11;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Add.ForeColor = System.Drawing.Color.SlateGray;
            this.Add.Location = new System.Drawing.Point(218, 405);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(195, 35);
            this.Add.TabIndex = 23;
            this.Add.Text = "Добавить";
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
            this.CustomerComboBox.Location = new System.Drawing.Point(177, 209);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(277, 32);
            this.CustomerComboBox.TabIndex = 12;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.tire_Service_DB;
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
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // user_accountsTableAdapter
            // 
            this.user_accountsTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // rimsTableAdapter
            // 
            this.rimsTableAdapter.ClearBeforeFill = true;
            // 
            // AddRimsReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRimsReq";
            this.Text = "TireService - Продажа дисков";
            this.Load += new System.EventHandler(this.AddRimsReq_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource useraccountsBindingSource;
        private Tire_Service_DBTableAdapters.User_accountsTableAdapter user_accountsTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Tire_Service_DBTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource rimsBindingSource;
        private Tire_Service_DBTableAdapters.RimsTableAdapter rimsTableAdapter;
    }
}