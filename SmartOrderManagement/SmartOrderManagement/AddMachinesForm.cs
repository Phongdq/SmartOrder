using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartOrderManagement
{
    public partial class AddMachinesForm : Form
    {
        private List<string> m_lstMachine = new List<string>();
        public AddMachinesForm()
        {
            InitializeComponent();
        }

        public void SetListMachine(List<string> lst)
        {
            m_lstMachine = lst;
        }

        public List<string> GetListMachine()
        {
            return m_lstMachine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_lstMachine.Count > 0)
            {
                m_lstMachine.Clear();
            }

            m_lstMachine = new List<string>(Regex.Split(m_MachineNames.Text, Environment.NewLine));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OnCancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddMachinesForm_Load(object sender, EventArgs e)
        {
            if (m_lstMachine.Count > 0)
                m_MachineNames.Text = String.Join(Environment.NewLine, m_lstMachine);
        }
    }
}
