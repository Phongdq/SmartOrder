namespace SmartOrderManagement
{
    partial class AddNewOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_OrderID = new System.Windows.Forms.TextBox();
            this.m_Customer = new System.Windows.Forms.TextBox();
            this.m_Production = new System.Windows.Forms.TextBox();
            this.m_Properties = new System.Windows.Forms.TextBox();
            this.m_AcceptDate = new System.Windows.Forms.DateTimePicker();
            this.m_DeadlineDate = new System.Windows.Forms.DateTimePicker();
            this.m_MachineList = new System.Windows.Forms.ListBox();
            this.MachinesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Note = new System.Windows.Forms.TextBox();
            this.m_TechnicalNote = new System.Windows.Forms.TextBox();
            this.m_Completed = new System.Windows.Forms.CheckBox();
            this.m_Delivered = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OnOK = new System.Windows.Forms.Button();
            this.OnCancel = new System.Windows.Forms.Button();
            this.MachinesMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Đơn Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kích Thước";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Giao";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Máy Sản Xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ghi Chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kỹ Thuật";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // m_OrderID
            // 
            this.m_OrderID.Location = new System.Drawing.Point(92, 25);
            this.m_OrderID.Name = "m_OrderID";
            this.m_OrderID.ReadOnly = true;
            this.m_OrderID.Size = new System.Drawing.Size(154, 20);
            this.m_OrderID.TabIndex = 11;
            // 
            // m_Customer
            // 
            this.m_Customer.Location = new System.Drawing.Point(92, 50);
            this.m_Customer.Name = "m_Customer";
            this.m_Customer.Size = new System.Drawing.Size(154, 20);
            this.m_Customer.TabIndex = 12;
            // 
            // m_Production
            // 
            this.m_Production.Location = new System.Drawing.Point(92, 76);
            this.m_Production.Name = "m_Production";
            this.m_Production.Size = new System.Drawing.Size(154, 20);
            this.m_Production.TabIndex = 13;
            // 
            // m_Properties
            // 
            this.m_Properties.Location = new System.Drawing.Point(19, 126);
            this.m_Properties.Multiline = true;
            this.m_Properties.Name = "m_Properties";
            this.m_Properties.Size = new System.Drawing.Size(227, 69);
            this.m_Properties.TabIndex = 14;
            // 
            // m_AcceptDate
            // 
            this.m_AcceptDate.Location = new System.Drawing.Point(363, 38);
            this.m_AcceptDate.Name = "m_AcceptDate";
            this.m_AcceptDate.Size = new System.Drawing.Size(200, 20);
            this.m_AcceptDate.TabIndex = 15;
            // 
            // m_DeadlineDate
            // 
            this.m_DeadlineDate.Location = new System.Drawing.Point(363, 76);
            this.m_DeadlineDate.Name = "m_DeadlineDate";
            this.m_DeadlineDate.Size = new System.Drawing.Size(200, 20);
            this.m_DeadlineDate.TabIndex = 16;
            // 
            // m_MachineList
            // 
            this.m_MachineList.ContextMenuStrip = this.MachinesMenu;
            this.m_MachineList.FormattingEnabled = true;
            this.m_MachineList.Location = new System.Drawing.Point(19, 224);
            this.m_MachineList.Name = "m_MachineList";
            this.m_MachineList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.m_MachineList.Size = new System.Drawing.Size(227, 82);
            this.m_MachineList.TabIndex = 17;
            // 
            // MachinesMenu
            // 
            this.MachinesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMachineToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteAllToolStripMenuItem});
            this.MachinesMenu.Name = "MachinesMenu";
            this.MachinesMenu.Size = new System.Drawing.Size(132, 70);
            // 
            // addMachineToolStripMenuItem
            // 
            this.addMachineToolStripMenuItem.Name = "addMachineToolStripMenuItem";
            this.addMachineToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addMachineToolStripMenuItem.Text = "Thêm";
            this.addMachineToolStripMenuItem.Click += new System.EventHandler(this.addMachineToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteToolStripMenuItem.Text = "Xóa";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteAllToolStripMenuItem.Text = "Xóa Tất Cả";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // m_Note
            // 
            this.m_Note.Location = new System.Drawing.Point(296, 131);
            this.m_Note.Multiline = true;
            this.m_Note.Name = "m_Note";
            this.m_Note.Size = new System.Drawing.Size(117, 64);
            this.m_Note.TabIndex = 18;
            // 
            // m_TechnicalNote
            // 
            this.m_TechnicalNote.Location = new System.Drawing.Point(446, 131);
            this.m_TechnicalNote.Multiline = true;
            this.m_TechnicalNote.Name = "m_TechnicalNote";
            this.m_TechnicalNote.Size = new System.Drawing.Size(117, 64);
            this.m_TechnicalNote.TabIndex = 19;
            // 
            // m_Completed
            // 
            this.m_Completed.AutoSize = true;
            this.m_Completed.Location = new System.Drawing.Point(22, 25);
            this.m_Completed.Name = "m_Completed";
            this.m_Completed.Size = new System.Drawing.Size(103, 17);
            this.m_Completed.TabIndex = 20;
            this.m_Completed.Text = "Đã Hoàn Thành";
            this.m_Completed.UseVisualStyleBackColor = true;
            // 
            // m_Delivered
            // 
            this.m_Delivered.AutoSize = true;
            this.m_Delivered.Location = new System.Drawing.Point(150, 25);
            this.m_Delivered.Name = "m_Delivered";
            this.m_Delivered.Size = new System.Drawing.Size(94, 17);
            this.m_Delivered.TabIndex = 21;
            this.m_Delivered.Text = "Đã Giao Hàng";
            this.m_Delivered.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_Completed);
            this.groupBox1.Controls.Add(this.m_Delivered);
            this.groupBox1.Location = new System.Drawing.Point(296, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 88);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng Thái Đơn Hàng";
            // 
            // OnOK
            // 
            this.OnOK.Location = new System.Drawing.Point(389, 319);
            this.OnOK.Name = "OnOK";
            this.OnOK.Size = new System.Drawing.Size(75, 23);
            this.OnOK.TabIndex = 23;
            this.OnOK.Text = "Thêm";
            this.OnOK.UseVisualStyleBackColor = true;
            this.OnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // OnCancel
            // 
            this.OnCancel.Location = new System.Drawing.Point(483, 319);
            this.OnCancel.Name = "OnCancel";
            this.OnCancel.Size = new System.Drawing.Size(75, 23);
            this.OnCancel.TabIndex = 24;
            this.OnCancel.Text = "Hủy";
            this.OnCancel.UseVisualStyleBackColor = true;
            this.OnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddNewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 354);
            this.Controls.Add(this.OnCancel);
            this.Controls.Add(this.OnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_TechnicalNote);
            this.Controls.Add(this.m_Note);
            this.Controls.Add(this.m_MachineList);
            this.Controls.Add(this.m_DeadlineDate);
            this.Controls.Add(this.m_AcceptDate);
            this.Controls.Add(this.m_Properties);
            this.Controls.Add(this.m_Production);
            this.Controls.Add(this.m_Customer);
            this.Controls.Add(this.m_OrderID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewOrderForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Đơn Hàng";
            this.Load += new System.EventHandler(this.AddNewOrder_Load);
            this.MachinesMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox m_OrderID;
        private System.Windows.Forms.TextBox m_Customer;
        private System.Windows.Forms.TextBox m_Production;
        private System.Windows.Forms.TextBox m_Properties;
        private System.Windows.Forms.DateTimePicker m_AcceptDate;
        private System.Windows.Forms.DateTimePicker m_DeadlineDate;
        private System.Windows.Forms.ListBox m_MachineList;
        private System.Windows.Forms.TextBox m_Note;
        private System.Windows.Forms.TextBox m_TechnicalNote;
        private System.Windows.Forms.CheckBox m_Completed;
        private System.Windows.Forms.CheckBox m_Delivered;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OnOK;
        private System.Windows.Forms.Button OnCancel;
        private System.Windows.Forms.ContextMenuStrip MachinesMenu;
        private System.Windows.Forms.ToolStripMenuItem addMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
    }
}