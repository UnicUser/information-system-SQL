namespace WindowsFormsApp12
{
    partial class DeleteAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAcc));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отобразитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminCheck = new System.Windows.Forms.CheckBox();
            this.UserCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TableWindow2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.tire_Service_DB = new WindowsFormsApp12.Tire_Service_DB();
            this.adminaccountsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admin_accounts_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Admin_accounts_ViewTableAdapter();
            this.workeraccountsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worker_accounts_ViewTableAdapter = new WindowsFormsApp12.Tire_Service_DBTableAdapters.Worker_accounts_ViewTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminaccountsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeraccountsViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отобразитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // отобразитьToolStripMenuItem
            // 
            this.отобразитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAdminToolStripMenuItem,
            this.ShowUserToolStripMenuItem});
            this.отобразитьToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.отобразитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.отобразитьToolStripMenuItem.Name = "отобразитьToolStripMenuItem";
            this.отобразитьToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.отобразитьToolStripMenuItem.Text = "Отобразить";
            // 
            // ShowAdminToolStripMenuItem
            // 
            this.ShowAdminToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.ShowAdminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowAdminToolStripMenuItem.Name = "ShowAdminToolStripMenuItem";
            this.ShowAdminToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ShowAdminToolStripMenuItem.Text = "Администраторы";
            this.ShowAdminToolStripMenuItem.Click += new System.EventHandler(this.ShowAdminToolStripMenuItem_Click);
            // 
            // ShowUserToolStripMenuItem
            // 
            this.ShowUserToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.ShowUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowUserToolStripMenuItem.Name = "ShowUserToolStripMenuItem";
            this.ShowUserToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ShowUserToolStripMenuItem.Text = "Пользователи";
            this.ShowUserToolStripMenuItem.Click += new System.EventHandler(this.ShowUserToolStripMenuItem_Click);
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
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.AdminCheck);
            this.panel2.Controls.Add(this.UserCheck);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.TableWindow2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.Title);
            this.panel2.Location = new System.Drawing.Point(12, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 403);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // AdminCheck
            // 
            this.AdminCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AdminCheck.AutoSize = true;
            this.AdminCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.AdminCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdminCheck.Location = new System.Drawing.Point(317, 306);
            this.AdminCheck.Name = "AdminCheck";
            this.AdminCheck.Size = new System.Drawing.Size(186, 28);
            this.AdminCheck.TabIndex = 27;
            this.AdminCheck.Text = "Администратор";
            this.AdminCheck.UseVisualStyleBackColor = true;
            // 
            // UserCheck
            // 
            this.UserCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UserCheck.AutoSize = true;
            this.UserCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.UserCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserCheck.Location = new System.Drawing.Point(110, 306);
            this.UserCheck.Name = "UserCheck";
            this.UserCheck.Size = new System.Drawing.Size(170, 28);
            this.UserCheck.TabIndex = 26;
            this.UserCheck.Text = "Пользователь";
            this.UserCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(138, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Введите номер пользователя для удаления";
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
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.SlateGray;
            this.textBox1.Location = new System.Drawing.Point(215, 266);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 34);
            this.textBox1.TabIndex = 23;
            // 
            // TableWindow2
            // 
            this.TableWindow2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.DeleteButton.Location = new System.Drawing.Point(215, 361);
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
            // tire_Service_DB
            // 
            this.tire_Service_DB.DataSetName = "Tire_Service_DB";
            this.tire_Service_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminaccountsViewBindingSource
            // 
            this.adminaccountsViewBindingSource.DataMember = "Admin_accounts_View";
            this.adminaccountsViewBindingSource.DataSource = this.tire_Service_DB;
            // 
            // admin_accounts_ViewTableAdapter
            // 
            this.admin_accounts_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // workeraccountsViewBindingSource
            // 
            this.workeraccountsViewBindingSource.DataMember = "Worker_accounts_View";
            this.workeraccountsViewBindingSource.DataSource = this.tire_Service_DB;
            // 
            // worker_accounts_ViewTableAdapter
            // 
            this.worker_accounts_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeleteAcc";
            this.Text = "TireService - Удалить учётную запись";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWindow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tire_Service_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminaccountsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workeraccountsViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView TableWindow2;
        private System.Windows.Forms.ToolStripMenuItem отобразитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowUserToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AdminCheck;
        private System.Windows.Forms.CheckBox UserCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private Tire_Service_DB tire_Service_DB;
        private System.Windows.Forms.BindingSource adminaccountsViewBindingSource;
        private Tire_Service_DBTableAdapters.Admin_accounts_ViewTableAdapter admin_accounts_ViewTableAdapter;
        private System.Windows.Forms.BindingSource workeraccountsViewBindingSource;
        private Tire_Service_DBTableAdapters.Worker_accounts_ViewTableAdapter worker_accounts_ViewTableAdapter;
    }
}