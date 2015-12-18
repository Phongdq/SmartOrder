namespace SmartOrderManagement
{
    partial class SearchEngineForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_ctrlEnableDeadlineFilter = new System.Windows.Forms.CheckBox();
            this.m_ctrlDeliveDateTo = new System.Windows.Forms.DateTimePicker();
            this.m_ctrlDeliveDateFrom = new System.Windows.Forms.DateTimePicker();
            this.m_ctrlAcceptDateTo = new System.Windows.Forms.DateTimePicker();
            this.m_ctrlAcceptDateFrom = new System.Windows.Forms.DateTimePicker();
            this.m_ctrlEnableAcceptDateFilter = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_ctrlIsDelivered = new System.Windows.Forms.CheckBox();
            this.m_ctrlIsCompleted = new System.Windows.Forms.CheckBox();
            this.m_ctrlEnableStatusFilter = new System.Windows.Forms.CheckBox();
            this.m_ctrlCustomerFilter = new System.Windows.Forms.TextBox();
            this.m_ctrlProductionFilter = new System.Windows.Forms.TextBox();
            this.m_ctrlNoteFilter = new System.Windows.Forms.TextBox();
            this.m_ctrlTechnicalFilter = new System.Windows.Forms.TextBox();
            this.OnSearching = new System.Windows.Forms.Button();
            this.OnCancelBtn = new System.Windows.Forms.Button();
            this.m_ctrlEnableDeliveredFilter = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kỹ Thuật";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_ctrlEnableDeadlineFilter);
            this.groupBox1.Controls.Add(this.m_ctrlDeliveDateTo);
            this.groupBox1.Controls.Add(this.m_ctrlDeliveDateFrom);
            this.groupBox1.Controls.Add(this.m_ctrlAcceptDateTo);
            this.groupBox1.Controls.Add(this.m_ctrlAcceptDateFrom);
            this.groupBox1.Controls.Add(this.m_ctrlEnableAcceptDateFilter);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời Gian";
            // 
            // m_ctrlEnableDeadlineFilter
            // 
            this.m_ctrlEnableDeadlineFilter.AutoSize = true;
            this.m_ctrlEnableDeadlineFilter.Location = new System.Drawing.Point(20, 77);
            this.m_ctrlEnableDeadlineFilter.Name = "m_ctrlEnableDeadlineFilter";
            this.m_ctrlEnableDeadlineFilter.Size = new System.Drawing.Size(200, 17);
            this.m_ctrlEnableDeadlineFilter.TabIndex = 9;
            this.m_ctrlEnableDeadlineFilter.Text = "Tìm Kiếm Theo Thời Gian Giao Hàng";
            this.m_ctrlEnableDeadlineFilter.UseVisualStyleBackColor = true;
            this.m_ctrlEnableDeadlineFilter.CheckedChanged += new System.EventHandler(this.m_ctrlEnableDeadlineFilter_CheckedChanged);
            // 
            // m_ctrlDeliveDateTo
            // 
            this.m_ctrlDeliveDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_ctrlDeliveDateTo.Location = new System.Drawing.Point(302, 102);
            this.m_ctrlDeliveDateTo.Name = "m_ctrlDeliveDateTo";
            this.m_ctrlDeliveDateTo.Size = new System.Drawing.Size(136, 20);
            this.m_ctrlDeliveDateTo.TabIndex = 8;
            // 
            // m_ctrlDeliveDateFrom
            // 
            this.m_ctrlDeliveDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_ctrlDeliveDateFrom.Location = new System.Drawing.Point(75, 102);
            this.m_ctrlDeliveDateFrom.Name = "m_ctrlDeliveDateFrom";
            this.m_ctrlDeliveDateFrom.Size = new System.Drawing.Size(136, 20);
            this.m_ctrlDeliveDateFrom.TabIndex = 7;
            // 
            // m_ctrlAcceptDateTo
            // 
            this.m_ctrlAcceptDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_ctrlAcceptDateTo.Location = new System.Drawing.Point(302, 43);
            this.m_ctrlAcceptDateTo.Name = "m_ctrlAcceptDateTo";
            this.m_ctrlAcceptDateTo.Size = new System.Drawing.Size(136, 20);
            this.m_ctrlAcceptDateTo.TabIndex = 6;
            // 
            // m_ctrlAcceptDateFrom
            // 
            this.m_ctrlAcceptDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_ctrlAcceptDateFrom.Location = new System.Drawing.Point(75, 43);
            this.m_ctrlAcceptDateFrom.Name = "m_ctrlAcceptDateFrom";
            this.m_ctrlAcceptDateFrom.Size = new System.Drawing.Size(136, 20);
            this.m_ctrlAcceptDateFrom.TabIndex = 5;
            // 
            // m_ctrlEnableAcceptDateFilter
            // 
            this.m_ctrlEnableAcceptDateFilter.AutoSize = true;
            this.m_ctrlEnableAcceptDateFilter.Location = new System.Drawing.Point(20, 19);
            this.m_ctrlEnableAcceptDateFilter.Name = "m_ctrlEnableAcceptDateFilter";
            this.m_ctrlEnableAcceptDateFilter.Size = new System.Drawing.Size(204, 17);
            this.m_ctrlEnableAcceptDateFilter.TabIndex = 4;
            this.m_ctrlEnableAcceptDateFilter.Text = "Tìm Kiếm Theo Thời Gian Nhận Hàng";
            this.m_ctrlEnableAcceptDateFilter.UseVisualStyleBackColor = true;
            this.m_ctrlEnableAcceptDateFilter.CheckedChanged += new System.EventHandler(this.m_ctrlEnableTimeFilter_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giao Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhận Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_ctrlEnableDeliveredFilter);
            this.groupBox2.Controls.Add(this.m_ctrlIsDelivered);
            this.groupBox2.Controls.Add(this.m_ctrlIsCompleted);
            this.groupBox2.Controls.Add(this.m_ctrlEnableStatusFilter);
            this.groupBox2.Location = new System.Drawing.Point(17, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 115);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng Thái";
            // 
            // m_ctrlIsDelivered
            // 
            this.m_ctrlIsDelivered.AutoSize = true;
            this.m_ctrlIsDelivered.Location = new System.Drawing.Point(238, 53);
            this.m_ctrlIsDelivered.Name = "m_ctrlIsDelivered";
            this.m_ctrlIsDelivered.Size = new System.Drawing.Size(94, 17);
            this.m_ctrlIsDelivered.TabIndex = 2;
            this.m_ctrlIsDelivered.Text = "Đã Giao Hàng";
            this.m_ctrlIsDelivered.UseVisualStyleBackColor = true;
            // 
            // m_ctrlIsCompleted
            // 
            this.m_ctrlIsCompleted.AutoSize = true;
            this.m_ctrlIsCompleted.Location = new System.Drawing.Point(15, 53);
            this.m_ctrlIsCompleted.Name = "m_ctrlIsCompleted";
            this.m_ctrlIsCompleted.Size = new System.Drawing.Size(103, 17);
            this.m_ctrlIsCompleted.TabIndex = 1;
            this.m_ctrlIsCompleted.Text = "Đã Hoàn Thành";
            this.m_ctrlIsCompleted.UseVisualStyleBackColor = true;
            // 
            // m_ctrlEnableStatusFilter
            // 
            this.m_ctrlEnableStatusFilter.AutoSize = true;
            this.m_ctrlEnableStatusFilter.Location = new System.Drawing.Point(15, 30);
            this.m_ctrlEnableStatusFilter.Name = "m_ctrlEnableStatusFilter";
            this.m_ctrlEnableStatusFilter.Size = new System.Drawing.Size(152, 17);
            this.m_ctrlEnableStatusFilter.TabIndex = 0;
            this.m_ctrlEnableStatusFilter.Text = "Tìm Kiếm Theo Trạng Thái";
            this.m_ctrlEnableStatusFilter.UseVisualStyleBackColor = true;
            this.m_ctrlEnableStatusFilter.CheckedChanged += new System.EventHandler(this.m_ctrlEnableStatusFilter_CheckedChanged);
            // 
            // m_ctrlCustomerFilter
            // 
            this.m_ctrlCustomerFilter.Location = new System.Drawing.Point(87, 28);
            this.m_ctrlCustomerFilter.Name = "m_ctrlCustomerFilter";
            this.m_ctrlCustomerFilter.Size = new System.Drawing.Size(114, 20);
            this.m_ctrlCustomerFilter.TabIndex = 6;
            // 
            // m_ctrlProductionFilter
            // 
            this.m_ctrlProductionFilter.Location = new System.Drawing.Point(87, 54);
            this.m_ctrlProductionFilter.Name = "m_ctrlProductionFilter";
            this.m_ctrlProductionFilter.Size = new System.Drawing.Size(114, 20);
            this.m_ctrlProductionFilter.TabIndex = 7;
            // 
            // m_ctrlNoteFilter
            // 
            this.m_ctrlNoteFilter.Location = new System.Drawing.Point(315, 31);
            this.m_ctrlNoteFilter.Name = "m_ctrlNoteFilter";
            this.m_ctrlNoteFilter.Size = new System.Drawing.Size(141, 20);
            this.m_ctrlNoteFilter.TabIndex = 8;
            // 
            // m_ctrlTechnicalFilter
            // 
            this.m_ctrlTechnicalFilter.Location = new System.Drawing.Point(315, 57);
            this.m_ctrlTechnicalFilter.Name = "m_ctrlTechnicalFilter";
            this.m_ctrlTechnicalFilter.Size = new System.Drawing.Size(141, 20);
            this.m_ctrlTechnicalFilter.TabIndex = 9;
            // 
            // OnSearching
            // 
            this.OnSearching.Location = new System.Drawing.Point(269, 352);
            this.OnSearching.Name = "OnSearching";
            this.OnSearching.Size = new System.Drawing.Size(75, 23);
            this.OnSearching.TabIndex = 10;
            this.OnSearching.Text = "Tìm Kiếm";
            this.OnSearching.UseVisualStyleBackColor = true;
            this.OnSearching.Click += new System.EventHandler(this.OnSearching_Click);
            // 
            // OnCancelBtn
            // 
            this.OnCancelBtn.Location = new System.Drawing.Point(375, 352);
            this.OnCancelBtn.Name = "OnCancelBtn";
            this.OnCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.OnCancelBtn.TabIndex = 11;
            this.OnCancelBtn.Text = "Hủy";
            this.OnCancelBtn.UseVisualStyleBackColor = true;
            this.OnCancelBtn.Click += new System.EventHandler(this.OnCancelBtn_Click);
            // 
            // m_ctrlEnableDeliveredFilter
            // 
            this.m_ctrlEnableDeliveredFilter.AutoSize = true;
            this.m_ctrlEnableDeliveredFilter.Location = new System.Drawing.Point(238, 30);
            this.m_ctrlEnableDeliveredFilter.Name = "m_ctrlEnableDeliveredFilter";
            this.m_ctrlEnableDeliveredFilter.Size = new System.Drawing.Size(191, 17);
            this.m_ctrlEnableDeliveredFilter.TabIndex = 4;
            this.m_ctrlEnableDeliveredFilter.Text = "Tìm Kiếm Theo Đơn Hàng Đã Giao";
            this.m_ctrlEnableDeliveredFilter.UseVisualStyleBackColor = true;
            this.m_ctrlEnableDeliveredFilter.CheckedChanged += new System.EventHandler(this.m_ctrlEnableDeliveredFilter_CheckedChanged);
            // 
            // SearchEngineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 387);
            this.Controls.Add(this.OnCancelBtn);
            this.Controls.Add(this.OnSearching);
            this.Controls.Add(this.m_ctrlTechnicalFilter);
            this.Controls.Add(this.m_ctrlNoteFilter);
            this.Controls.Add(this.m_ctrlProductionFilter);
            this.Controls.Add(this.m_ctrlCustomerFilter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchEngineForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm Kiếm Đơn Hàng Nâng Cao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox m_ctrlCustomerFilter;
        private System.Windows.Forms.TextBox m_ctrlProductionFilter;
        private System.Windows.Forms.TextBox m_ctrlNoteFilter;
        private System.Windows.Forms.TextBox m_ctrlTechnicalFilter;
        private System.Windows.Forms.DateTimePicker m_ctrlAcceptDateFrom;
        private System.Windows.Forms.CheckBox m_ctrlEnableAcceptDateFilter;
        private System.Windows.Forms.DateTimePicker m_ctrlAcceptDateTo;
        private System.Windows.Forms.DateTimePicker m_ctrlDeliveDateTo;
        private System.Windows.Forms.DateTimePicker m_ctrlDeliveDateFrom;
        private System.Windows.Forms.CheckBox m_ctrlIsDelivered;
        private System.Windows.Forms.CheckBox m_ctrlIsCompleted;
        private System.Windows.Forms.CheckBox m_ctrlEnableStatusFilter;
        private System.Windows.Forms.Button OnSearching;
        private System.Windows.Forms.Button OnCancelBtn;
        private System.Windows.Forms.CheckBox m_ctrlEnableDeadlineFilter;
        private System.Windows.Forms.CheckBox m_ctrlEnableDeliveredFilter;
    }
}