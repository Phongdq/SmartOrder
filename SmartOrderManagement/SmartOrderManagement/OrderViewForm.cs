using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartOrderManagement
{
    public partial class OrderViewForm : Form
    {
        ReportDataSource m_CurrentOrderList;
        public OrderViewForm()
        {
            InitializeComponent();
        }

        public void SetOrderList(DataTable dt)
        {
            m_CurrentOrderList = new ReportDataSource("Order List", dt);
        }
        private void OrderViewForm_Load(object sender, EventArgs e)
        {
            this.m_reportViewerSelection.LocalReport.DataSources.Clear();
            this.m_reportViewerSelection.LocalReport.DataSources.Add(m_CurrentOrderList);

            this.m_reportViewerSelection.RefreshReport();
        }
    }
}
