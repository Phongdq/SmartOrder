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
    public partial class SearchEngineForm : Form
    {
        //Local Avaiable
        private string m_strFilterResult;
        public SearchEngineForm()
        {
            InitializeComponent();

            m_ctrlEnableAcceptDateFilter.CheckState = CheckState.Unchecked;
            m_ctrlEnableStatusFilter.CheckState = CheckState.Unchecked;

            m_ctrlAcceptDateFrom.Enabled = false;
            m_ctrlAcceptDateTo.Enabled = false;
            m_ctrlDeliveDateFrom.Enabled = false;
            m_ctrlDeliveDateTo.Enabled = false;
            m_ctrlIsCompleted.Enabled = false;
            m_ctrlIsDelivered.Enabled = false;
        }

        public string GetFilterString( )
        {
            string sCustomer, sProduction;
            int isCompleted, isDelivered;
            DateTime dtAcceptDateFrom, dtAcceptDateTo, dtDeadlineFrom, dtDeadlineTo;

            if (m_ctrlProductionFilter.Text != "")
            {
                sProduction = m_ctrlProductionFilter.Text;

                m_strFilterResult = "-p:" + sProduction + " ";
            }

            if (m_ctrlEnableAcceptDateFilter.CheckState == CheckState.Checked)
            {
                dtAcceptDateFrom = m_ctrlAcceptDateFrom.Value;
                dtAcceptDateTo = m_ctrlAcceptDateTo.Value;

                m_strFilterResult += "-aFrom:" + dtAcceptDateFrom.Date.ToShortDateString() + " -aTo:" + dtAcceptDateTo.Date.ToShortDateString() + " ";
            }

            if (m_ctrlEnableDeadlineFilter.CheckState == CheckState.Checked)
            {
                dtDeadlineFrom = m_ctrlDeliveDateFrom.Value;
                dtDeadlineTo = m_ctrlDeliveDateTo.Value;

                m_strFilterResult += "-dFrom:" + dtDeadlineFrom.Date.ToShortDateString() + " -dTo:" + dtDeadlineFrom.Date.ToShortDateString() + " ";
            }

            if (m_ctrlEnableStatusFilter.CheckState == CheckState.Checked)
            {
                isCompleted = m_ctrlIsCompleted.Checked == true ? 1 : 0;

                m_strFilterResult += "-c:" + isCompleted.ToString() + " ";
            }

            if (m_ctrlEnableDeliveredFilter.CheckState == CheckState.Checked)
            {
                isDelivered = m_ctrlIsDelivered.Checked == true ? 1 : 0;

                m_strFilterResult += "-g:" + isDelivered.ToString() + " ";
            }

            if (m_ctrlCustomerFilter.Text != null)
            {
                sCustomer = m_ctrlCustomerFilter.Text;
                m_strFilterResult += sCustomer;
            }

            return m_strFilterResult;
        }

        private void OnSearching_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void OnCancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void m_ctrlEnableTimeFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ctrlEnableAcceptDateFilter.CheckState == CheckState.Checked)
            {
                m_ctrlAcceptDateFrom.Enabled = true;
                m_ctrlAcceptDateTo.Enabled = true;
                
            }
            else
            {
                m_ctrlAcceptDateFrom.Enabled = false;
                m_ctrlAcceptDateTo.Enabled = false;
                
            }
        }

        private void m_ctrlEnableStatusFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ctrlEnableStatusFilter.CheckState == CheckState.Checked)
            {
                m_ctrlIsCompleted.Enabled = true;
            }
            else
            {
                m_ctrlIsCompleted.Enabled = false;
            }
        }

        

        private void m_ctrlEnableDeadlineFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ctrlEnableDeadlineFilter.CheckState == CheckState.Checked)
            {
                m_ctrlDeliveDateFrom.Enabled = true;
                m_ctrlDeliveDateTo.Enabled = true;
            }
            else
            {
                m_ctrlDeliveDateFrom.Enabled = false;
                m_ctrlDeliveDateTo.Enabled = false;
            }
        }

        private void m_ctrlEnableDeliveredFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ctrlEnableDeliveredFilter.CheckState == CheckState.Checked)
                m_ctrlIsDelivered.Enabled = true;
            else
                m_ctrlIsDelivered.Enabled = false;
        }
    }
}
