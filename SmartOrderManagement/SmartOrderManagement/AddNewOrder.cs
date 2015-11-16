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
    public partial class AddNewOrderForm : Form
    {
        iOrder m_Order;
        bool m_bIsNewOrder = true;
        public AddNewOrderForm()
        {
            InitializeComponent();
        }

        public void InitForm(iOrder info, bool isNew)
        {
            m_Order = info;

            m_bIsNewOrder = isNew;
        }

        public iOrder GetOrder()
        {
            return m_Order;
        }

        private void AddNewOrder_Load(object sender, EventArgs e)
        {
            m_OrderID.Text = m_Order.ID.ToString();
            if (!m_bIsNewOrder)
            {
                OnOK.Text = "Đồng Ý";
                m_Customer.Text = m_Order.Customer;
                m_Production.Text = m_Order.Production;
                m_Properties.Text = m_Order.Properties;

                //m_AcceptDate.Format = DateTimePickerFormat.Short;
                m_AcceptDate.Value = m_Order.AcceptDate;//Convert.ToDateTime(m_Order.AcceptDate);

                //m_DeadlineDate.Format = DateTimePickerFormat.Short;
                m_DeadlineDate.Value = m_Order.DeadlineDate;//Convert.ToDateTime(m_Order.DeadlineDate);

                string[] machineItems = m_Order.Machines.Split(',');
                List<string> lstMachine = new List<string>(machineItems);
                m_MachineList.DataSource = lstMachine;

                m_Note.Text = m_Order.Note;
                m_TechnicalNote.Text = m_Order.Technical;
                m_Completed.ThreeState = true;
                m_Completed.Checked = m_Order.Completed;
                m_Delivered.ThreeState = true;
                m_Delivered.Checked = m_Order.Delivered;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_Order.ID = Convert.ToInt32(m_OrderID.Text);
            m_Order.Customer = m_Customer.Text;
            m_Order.Production = m_Production.Text;
            m_Order.Properties = m_Properties.Text;
            m_Order.AcceptDate = m_AcceptDate.Value/*.ToShortDateString()*/;
            m_Order.DeadlineDate = m_DeadlineDate.Value/*.ToShortDateString()*/;

            List<string> _lstMachine = new List<string>();
            foreach(string s in m_MachineList.Items)
            {
                _lstMachine.Add(s);
            }
            m_Order.Machines = String.Join(",", _lstMachine.ToArray()); ;
            m_Order.Note = m_Note.Text;
            m_Order.Technical = m_TechnicalNote.Text;
            m_Order.Completed = m_Completed.Checked;
            m_Order.Delivered = m_Delivered.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> _lstMachine = new List<string>();
            foreach (string s in m_MachineList.Items)
            {
                _lstMachine.Add(s);
            }
            AddMachinesForm _form = new AddMachinesForm();
            _form.SetListMachine(_lstMachine);
            if (_form.ShowDialog() == DialogResult.OK)
            {
                if (_lstMachine.Count > 0)
                    _lstMachine.Clear();

                _lstMachine = _form.GetListMachine();
                m_MachineList.DataSource = _lstMachine;

                //m_Order.Machines = String.Join(",", _lstMachine.ToArray());
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = m_MachineList.SelectedIndices.Count - 1; i >= 0 ; i++)
            {
                int idx = m_MachineList.SelectedIndices[i];
                m_MachineList.Items.RemoveAt(idx);
            }
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_MachineList.Items.Clear();
        }
    }
}
