namespace WindowsFormsApp12
{
    partial class WorkerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerInfo));
            this.AllInfo = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllInfo
            // 
            this.AllInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllInfo.BackColor = System.Drawing.Color.SlateGray;
            this.AllInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AllInfo.Location = new System.Drawing.Point(12, 12);
            this.AllInfo.Name = "AllInfo";
            this.AllInfo.Size = new System.Drawing.Size(302, 349);
            this.AllInfo.TabIndex = 13;
            this.AllInfo.Text = resources.GetString("AllInfo.Text");
            this.AllInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AllInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.AllInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OkButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.OkButton.ForeColor = System.Drawing.Color.SlateGray;
            this.OkButton.Location = new System.Drawing.Point(66, 313);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(195, 35);
            this.OkButton.TabIndex = 24;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // WorkerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(326, 370);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.AllInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkerInfo";
            this.Text = "TireService - Информация пользователя";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label AllInfo;
        private System.Windows.Forms.Button OkButton;
    }
}