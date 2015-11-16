namespace SmartOrderManagement
{
    partial class AddMachinesForm
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
            this.m_MachineNames = new System.Windows.Forms.TextBox();
            this.OnOK = new System.Windows.Forms.Button();
            this.OnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập danh sách Máy vào khung bên dưới. Mỗi Máy là một dòng.";
            // 
            // m_MachineNames
            // 
            this.m_MachineNames.Location = new System.Drawing.Point(12, 44);
            this.m_MachineNames.Multiline = true;
            this.m_MachineNames.Name = "m_MachineNames";
            this.m_MachineNames.Size = new System.Drawing.Size(191, 264);
            this.m_MachineNames.TabIndex = 1;
            // 
            // OnOK
            // 
            this.OnOK.Location = new System.Drawing.Point(113, 314);
            this.OnOK.Name = "OnOK";
            this.OnOK.Size = new System.Drawing.Size(42, 23);
            this.OnOK.TabIndex = 2;
            this.OnOK.Text = "Thêm";
            this.OnOK.UseVisualStyleBackColor = true;
            this.OnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // OnCancel
            // 
            this.OnCancel.Location = new System.Drawing.Point(161, 314);
            this.OnCancel.Name = "OnCancel";
            this.OnCancel.Size = new System.Drawing.Size(42, 23);
            this.OnCancel.TabIndex = 3;
            this.OnCancel.Text = "Hủy";
            this.OnCancel.UseVisualStyleBackColor = true;
            this.OnCancel.Click += new System.EventHandler(this.OnCancel_Click);
            // 
            // AddMachinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 340);
            this.Controls.Add(this.OnCancel);
            this.Controls.Add(this.OnOK);
            this.Controls.Add(this.m_MachineNames);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMachinesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Máy";
            this.Load += new System.EventHandler(this.AddMachinesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_MachineNames;
        private System.Windows.Forms.Button OnOK;
        private System.Windows.Forms.Button OnCancel;
    }
}