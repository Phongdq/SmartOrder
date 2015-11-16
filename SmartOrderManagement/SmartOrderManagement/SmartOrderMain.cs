using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SmartOrderManagement
{
    public struct DBServerStruct
    {
        public string ServerName;
        public string DBName;
        public string Account;
        public string Password;
        
    }

    public struct iOrder
    {
        public int      ID;
        public string Customer ;
        public string Production;
        public string Properties;
        public DateTime AcceptDate;
        public DateTime DeadlineDate;
        public string Machines;
        public string Note;
        public string Technical;
        public bool Completed;
        public bool Delivered;
        
    }
    public partial class SmartOrderMain : Form
    {
        //Global Variable
        OrderDB m_DB = new OrderDB();
        public int m_nCurrentOrderListCount = 0;
        private DataSet m_dsCurrentOrderList = new DataSet();
        public SmartOrderMain()
        {
            InitializeComponent();
        }

        private void DataviewColumnConfig()
        {
            //Define Header Name
            {
                m_ctrlDataViewer.Columns[0].HeaderText = "STT";
                m_ctrlDataViewer.Columns[1].HeaderText = "Khách Hàng";
                m_ctrlDataViewer.Columns[2].HeaderText = "Sản Phẩm";
                m_ctrlDataViewer.Columns[3].HeaderText = "Kích Thước";
                m_ctrlDataViewer.Columns[4].HeaderText = "Ngày Nhận";
                m_ctrlDataViewer.Columns[5].HeaderText = "Ngày Giao";
                m_ctrlDataViewer.Columns[6].HeaderText = "Máy Sản Xuất";
                m_ctrlDataViewer.Columns[7].HeaderText = "Ghi Chú";
                m_ctrlDataViewer.Columns[8].HeaderText = "Kỹ Thuật";
                m_ctrlDataViewer.Columns[9].HeaderText = "Đã Hoàn Thành";
                m_ctrlDataViewer.Columns[10].HeaderText = "Đã Giao Hàng";
            }
            //Config Column Size
            m_ctrlDataViewer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            for(int i = 1; i < m_ctrlDataViewer.Columns.Count; i++)
            {
                m_ctrlDataViewer.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            m_ctrlDataViewer.Sort(m_ctrlDataViewer.Columns["ID"], ListSortDirection.Descending);
            m_ctrlDataViewer.Columns["properties"].SortMode = DataGridViewColumnSortMode.NotSortable;
            m_ctrlDataViewer.Columns["machines"].SortMode = DataGridViewColumnSortMode.NotSortable;
            m_ctrlDataViewer.Columns["note"].SortMode = DataGridViewColumnSortMode.NotSortable;
            m_ctrlDataViewer.Columns["technical"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void UpdateOrderView()
        {
            if (m_DB.Query(ref m_dsCurrentOrderList))
            {
                m_nCurrentOrderListCount = m_dsCurrentOrderList.Tables[0].Rows.Count;
                DataViewRefresh(m_dsCurrentOrderList);
            }
        }
        private void DataViewRefresh(DataSet ds)
        {
            if (m_ctrlDataViewer.DataSource != null)
            {
                m_ctrlDataViewer.DataSource = null;
                m_ctrlDataViewer.Update();
                m_ctrlDataViewer.Refresh();
            }
            
            m_ctrlDataViewer.DataSource = ds;
            m_ctrlDataViewer.DataMember = "Order_List";

            DataviewColumnConfig();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBServerStruct dbinfo = new DBServerStruct();
            DBConnectionForm dbForm = new DBConnectionForm();
            if (dbForm.ShowDialog() == DialogResult.OK)
            {
                dbinfo = dbForm.GetData();
                m_DB.Initialize(dbinfo);

                UpdateOrderView();
            }
        }

        private void AddNewOrder()
        {
            iOrder newOrder = new iOrder();

            newOrder.ID = m_nCurrentOrderListCount + 1;
            AddNewOrderForm newOrderForm = new AddNewOrderForm();

            newOrderForm.InitForm(newOrder, true);
            if (newOrderForm.ShowDialog() == DialogResult.OK)
            {
                newOrder = newOrderForm.GetOrder();
                if (m_DB.Insert(newOrder))
                {
                    m_nCurrentOrderListCount++;
                    UpdateOrderView();
                }
                    
            }
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewOrder();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewOrder();
        }

        private int m_nRowSelected = -1;
        private int m_nIDSelected = -1;
        
        private void m_ctrlDataViewer_MouseClick(object sender, MouseEventArgs e)
        {
            m_ctrlDataViewer.ClearSelection();
            if (e.Button == MouseButtons.Right)
            {
                m_nRowSelected = m_ctrlDataViewer.HitTest(e.X, e.Y).RowIndex;
                if (m_nRowSelected < 0 || m_nRowSelected >= m_nCurrentOrderListCount)
                    return;
                m_ctrlDataViewer.Rows[m_nRowSelected].Selected = true;
                m_nIDSelected = Convert.ToInt16(m_ctrlDataViewer.Rows[m_nRowSelected].Cells["ID"].Value.ToString());
                m_ctrlDGVMenu.Show(m_ctrlDataViewer, new Point(e.X, e.Y));
            }
        }

        private void OnUpdateOrder()
        {
            iOrder _currentOrder = new iOrder();
            if (!m_DB.Query(m_nIDSelected, ref _currentOrder))
            {
                string strErr = "Không Tìm thấy Đơn Hàng có Mã: " + m_nIDSelected;
                MessageBox.Show(strErr);
                return;
            }

            AddNewOrderForm orderForm = new AddNewOrderForm();
            orderForm.InitForm(_currentOrder, false);

            if (orderForm.ShowDialog() == DialogResult.OK)
            {
                iOrder newOrder = orderForm.GetOrder();
                if (m_DB.Update(_currentOrder.ID, newOrder))
                    UpdateOrderView();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnUpdateOrder();
        }

        private void m_ctrlDataViewer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            m_ctrlDataViewer.ClearSelection();
            if (e.Button == MouseButtons.Left)
            {
                m_nRowSelected = m_ctrlDataViewer.HitTest(e.X, e.Y).RowIndex;
                if (m_nRowSelected < 0 || m_nRowSelected >= m_nCurrentOrderListCount)
                    return;
                m_ctrlDataViewer.Rows[m_nRowSelected].Selected = true;
                m_nIDSelected = Convert.ToInt16(m_ctrlDataViewer.Rows[m_nRowSelected].Cells["ID"].Value.ToString());
                OnUpdateOrder();
            }
        }

        private void ExportDataToExcelFile(string filePath)
        {
            Excel.Application ex = new Excel.Application();

            Excel.Workbook workbook = ex.Workbooks.Add();

            DataTable _OrderDT = m_dsCurrentOrderList.Tables[0];

            Excel.Worksheet _sheet = workbook.Worksheets.Add();
            _sheet.Name = "Danh Sách Đơn Hàng";

            {
                _sheet.Cells[1, 1] = "STT";
                _sheet.Cells[1, 2] = "Khách Hàng";
                _sheet.Cells[1, 3] = "Sản Phẩm";
                _sheet.Cells[1, 4] = "Kích Thước";
                _sheet.Cells[1, 5] = "Ngày Nhận";
                _sheet.Cells[1, 6] = "Ngày Giao";
                _sheet.Cells[1, 7] = "Máy Sản Xuất";
                _sheet.Cells[1, 8] = "Ghi Chú";
                _sheet.Cells[1, 9] = "Kỹ Thuật";
                _sheet.Cells[1, 10] = "Đã Hoàn Thành";
                _sheet.Cells[1, 11] = "Đã Giao Hàng";
            }

            for (int i = 0; i < _OrderDT.Rows.Count; i ++)
            {
                for (int j = 0; j < _OrderDT.Columns.Count; j++)
                {
                    _sheet.Cells[i + 2, j + 1] = _OrderDT.Rows[i].ItemArray[j].ToString();
                }
            }

            workbook.SaveAs(filePath);
            workbook.Close();
            ex.Quit();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.InitialDirectory = @"C:\";
            saveDlg.Filter = "Excel 97-2003 files (*.xls)|*.xls|Excel 2007-2010 files (*xlsx)|*.xlsx";
            saveDlg.FilterIndex = 0;
            saveDlg.RestoreDirectory = true;
            saveDlg.Title = "Xuất Danh Sách Đơn Hàng Ra File Excel";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                string strpath = saveDlg.FileName;
                ExportDataToExcelFile(strpath);
            }
        }
    }
}
