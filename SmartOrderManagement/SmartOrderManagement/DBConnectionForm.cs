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
    public partial class DBConnectionForm : Form
    {
        DBServerStruct m_DBInfo = new DBServerStruct();
        public DBConnectionForm()
        {
            InitializeComponent();
            m_ctrlServer.Text = "PhongDQ-PC\\SQLEXPRESS";
            m_ctrlDBName.Text = "OrderDB";
            m_ctrlAccount.Text = "admindb";
            m_ctrlPassword.Text = "123abc";
        }

        public DBServerStruct GetData()
        {
            return m_DBInfo;
        }

        private void OnOK_Click(object sender, EventArgs e)
        {
            m_DBInfo.ServerName = m_ctrlServer.Text;
            m_DBInfo.DBName = m_ctrlDBName.Text;
            m_DBInfo.Account = m_ctrlAccount.Text;
            m_DBInfo.Password = m_ctrlPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OnCancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
