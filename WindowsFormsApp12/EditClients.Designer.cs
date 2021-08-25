namespace WindowsFormsApp12
{
    partial class EditClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.TableWindow2 = new System.Windows.Forms.DataGridView();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полноеИмяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tire_Service_DB = new WindowsFormsApp12.Tire_Service_DB();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.customersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customers_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Customers_ViewTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersViewBindingSource1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(630, 614);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PhoneTextBox);
            this.panel2.Controls.Add(this.MiddleNameTextBox);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.SurnameTextBox);
            this.panel2.Controls.Add(this.TableWindow2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Title);
            this.panel2.Controls.Add(this.Edit);
            this.panel2.Location = new System.Drawing.Point(12, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 582);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(319, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(319, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(123, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(123, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Фамилия";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhoneTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.PhoneTextBox.ForeColor = System.Drawing.Color.SlateGray;
            this.PhoneTextBox.Location = new System.Drawing.Point(323, 170);
            this.PhoneTextBox.Multiline = true;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(177, 34);
            this.PhoneTextBox.TabIndex = 40;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MiddleNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MiddleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MiddleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.MiddleNameTextBox.ForeColor = System.Drawing.Color.SlateGray;
            this.MiddleNameTextBox.Location = new System.Drawing.Point(323, 104);
            this.MiddleNameTextBox.Multiline = true;
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(177, 34);
            this.MiddleNameTextBox.TabIndex = 39;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.NameTextBox.ForeColor = System.Drawing.Color.SlateGray;
            this.NameTextBox.Location = new System.Drawing.Point(127, 170);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(174, 34);
            this.NameTextBox.TabIndex = 38;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SurnameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.SurnameTextBox.ForeColor = System.Drawing.Color.SlateGray;
            this.SurnameTextBox.Location = new System.Drawing.Point(127, 104);
            this.SurnameTextBox.Multiline = true;
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(174, 34);
            this.SurnameTextBox.TabIndex = 37;
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
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.полноеИмяDataGridViewTextBoxColumn});
            this.TableWindow2.DataSource = this.customersViewBindingSource;
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
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 102;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 66;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 96;
            // 
            // полноеИмяDataGridViewTextBoxColumn
            // 
            this.полноеИмяDataGridViewTextBoxColumn.DataPropertyName = "Полное имя";
            this.полноеИмяDataGridViewTextBoxColumn.HeaderText = "Полное имя";
            this.полноеИмяDataGridViewTextBoxColumn.Name = "полноеИмяDataGridViewTextBoxColumn";
            this.полноеИмяDataGridViewTextBoxColumn.Width = 122;
            // 
            // customersViewBindingSource
            // 
            this.customersViewBindingSource.DataMember = "Customers_View";
            this.customersViewBindingSource.DataSource = this.tire_Service_DB;
            // 
            // tire_Service_DB
            // 
            this.tire_Service_DB.DataSetName = "Tire_Service_DB";
            this.tire_Service_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(103, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Выберите имя клиента к редактированию\r\n";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox4.DataSource = this.customersViewBindingSource1;
            this.comboBox4.DisplayMember = "Полное имя";
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBox4.ForeColor = System.Drawing.Color.SlateGray;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(129, 465);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(373, 32);
            this.comboBox4.TabIndex = 34;
            // 
            // customersViewBindingSource1
            // 
            this.customersViewBindingSource1.DataMember = "Customers_View";
            this.customersViewBindingSource1.DataSource = this.tire_Service_DB;
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
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customers_ViewTableAdapter
            // 
            this.customers_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // EditClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditClients";
            this.Text = "TireService - Редактировать запись клиента";
            this.Load += new System.EventHandler(this.EditClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView TableWindow2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Tire_Service_DB tire_Service_DB;
        private System.Windows.Forms.BindingSource customersViewBindingSource;
        private Tire_Service_DBTableAdapters.Customers_ViewTableAdapter customers_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полноеИмяDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.BindingSource customersViewBindingSource1;
    }
}