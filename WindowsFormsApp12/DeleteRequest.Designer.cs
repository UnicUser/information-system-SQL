namespace WindowsFormsApp12
{
    partial class DeleteRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRequest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RequestNamecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TableWindow2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tire_Service_DB = new WindowsFormsApp12.Tire_Service_DB();
            this.sellingRimsVew = new WindowsFormsApp12.SellingRimsVew();
            this.requestsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requests_ViewTableAdapter = new WindowsFormsApp12.SellingRimsVewTableAdapters.Requests_ViewTableAdapter();
            this.номерЗапросаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полноеИмяКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сервисDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полноеИмяРаботникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОбслуживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяОбслуживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsTableAdapter = new WindowsFormsApp12.SellingRimsVewTableAdapters.RequestsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingRimsVew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(630, 435);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.RequestNamecomboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TableWindow2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.Title);
            this.panel2.Location = new System.Drawing.Point(12, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 403);
            this.panel2.TabIndex = 2;
            // 
            // RequestNamecomboBox
            // 
            this.RequestNamecomboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RequestNamecomboBox.DataSource = this.requestsBindingSource;
            this.RequestNamecomboBox.DisplayMember = "id_requests";
            this.RequestNamecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RequestNamecomboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.RequestNamecomboBox.FormattingEnabled = true;
            this.RequestNamecomboBox.Location = new System.Drawing.Point(194, 268);
            this.RequestNamecomboBox.Name = "RequestNamecomboBox";
            this.RequestNamecomboBox.Size = new System.Drawing.Size(243, 32);
            this.RequestNamecomboBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(170, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Введите номер запроса к удалению";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(212, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 24;
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
            this.TableWindow2.Location = new System.Drawing.Point(23, 72);
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
            this.TableWindow2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(190, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 18;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.SlateGray;
            this.DeleteButton.Location = new System.Drawing.Point(218, 361);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(194, 35);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Font = new System.Drawing.Font("Agency FB", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.SlateGray;
            this.Title.Location = new System.Drawing.Point(206, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(189, 52);
            this.Title.TabIndex = 4;
            this.Title.Text = "TireService";
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
            // sellingRimsVew
            // 
            this.sellingRimsVew.DataSetName = "SellingRimsVew";
            this.sellingRimsVew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestsViewBindingSource
            // 
            this.requestsViewBindingSource.DataMember = "Requests_View";
            this.requestsViewBindingSource.DataSource = this.sellingRimsVew;
            // 
            // requests_ViewTableAdapter
            // 
            this.requests_ViewTableAdapter.ClearBeforeFill = true;
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
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.sellingRimsVew;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteRequest";
            this.Text = "TireService - Удаление записи обслуживания";
            this.Load += new System.EventHandler(this.DeleteRequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingRimsVew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox RequestNamecomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TableWindow2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Tire_Service_DB tire_Service_DB;
        private SellingRimsVew sellingRimsVew;
        private System.Windows.Forms.BindingSource requestsViewBindingSource;
        private SellingRimsVewTableAdapters.Requests_ViewTableAdapter requests_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗапросаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полноеИмяКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сервисDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полноеИмяРаботникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОбслуживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяОбслуживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private SellingRimsVewTableAdapters.RequestsTableAdapter requestsTableAdapter;
    }
}