namespace SmartOrderManagement
{
    partial class OrderViewForm
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
            this.m_reportViewerSelection = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // m_reportViewerSelection
            // 
            this.m_reportViewerSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_reportViewerSelection.Location = new System.Drawing.Point(0, 0);
            this.m_reportViewerSelection.Name = "m_reportViewerSelection";
            this.m_reportViewerSelection.Size = new System.Drawing.Size(774, 424);
            this.m_reportViewerSelection.TabIndex = 0;
            // 
            // OrderViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 424);
            this.Controls.Add(this.m_reportViewerSelection);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderViewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Danh Sách Đơn Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer m_reportViewerSelection;
    }
}