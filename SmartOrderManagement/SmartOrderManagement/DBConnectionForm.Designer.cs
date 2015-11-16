namespace SmartOrderManagement
{
    partial class DBConnectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_ctrlServer = new System.Windows.Forms.TextBox();
            this.m_ctrlDBName = new System.Windows.Forms.TextBox();
            this.m_ctrlAccount = new System.Windows.Forms.TextBox();
            this.m_ctrlPassword = new System.Windows.Forms.TextBox();
            this.OnOK = new System.Windows.Forms.Button();
            this.OnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máy chủ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cơ Sở Dữ Liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // m_ctrlServer
            // 
            this.m_ctrlServer.Location = new System.Drawing.Point(152, 9);
            this.m_ctrlServer.Name = "m_ctrlServer";
            this.m_ctrlServer.Size = new System.Drawing.Size(100, 20);
            this.m_ctrlServer.TabIndex = 4;
            // 
            // m_ctrlDBName
            // 
            this.m_ctrlDBName.Location = new System.Drawing.Point(152, 47);
            this.m_ctrlDBName.Name = "m_ctrlDBName";
            this.m_ctrlDBName.Size = new System.Drawing.Size(100, 20);
            this.m_ctrlDBName.TabIndex = 5;
            // 
            // m_ctrlAccount
            // 
            this.m_ctrlAccount.Location = new System.Drawing.Point(152, 85);
            this.m_ctrlAccount.Name = "m_ctrlAccount";
            this.m_ctrlAccount.Size = new System.Drawing.Size(100, 20);
            this.m_ctrlAccount.TabIndex = 6;
            // 
            // m_ctrlPassword
            // 
            this.m_ctrlPassword.Location = new System.Drawing.Point(152, 123);
            this.m_ctrlPassword.Name = "m_ctrlPassword";
            this.m_ctrlPassword.PasswordChar = '*';
            this.m_ctrlPassword.Size = new System.Drawing.Size(100, 20);
            this.m_ctrlPassword.TabIndex = 7;
            this.m_ctrlPassword.UseSystemPasswordChar = true;
            // 
            // OnOK
            // 
            this.OnOK.Location = new System.Drawing.Point(80, 158);
            this.OnOK.Name = "OnOK";
            this.OnOK.Size = new System.Drawing.Size(75, 23);
            this.OnOK.TabIndex = 8;
            this.OnOK.Text = "Kết Nối";
            this.OnOK.UseVisualStyleBackColor = true;
            this.OnOK.Click += new System.EventHandler(this.OnOK_Click);
            // 
            // OnCancel
            // 
            this.OnCancel.Location = new System.Drawing.Point(185, 158);
            this.OnCancel.Name = "OnCancel";
            this.OnCancel.Size = new System.Drawing.Size(75, 23);
            this.OnCancel.TabIndex = 9;
            this.OnCancel.Text = "Hủy";
            this.OnCancel.UseVisualStyleBackColor = true;
            this.OnCancel.Click += new System.EventHandler(this.OnCancel_Click);
            // 
            // DBConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 193);
            this.Controls.Add(this.OnCancel);
            this.Controls.Add(this.OnOK);
            this.Controls.Add(this.m_ctrlPassword);
            this.Controls.Add(this.m_ctrlAccount);
            this.Controls.Add(this.m_ctrlDBName);
            this.Controls.Add(this.m_ctrlServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kết Nối Cơ Sở Dữ Liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_ctrlServer;
        private System.Windows.Forms.TextBox m_ctrlDBName;
        private System.Windows.Forms.TextBox m_ctrlAccount;
        private System.Windows.Forms.TextBox m_ctrlPassword;
        private System.Windows.Forms.Button OnOK;
        private System.Windows.Forms.Button OnCancel;
    }
}