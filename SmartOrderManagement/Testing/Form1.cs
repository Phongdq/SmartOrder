using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=PhongDQ-PC\\SQLEXPRESS;Initial Catalog=OrderDB;User ID=admindb;Password=123abc";
            string sqlcmd = "Select * From Orderdb.dbo.[Order]";
            try {
                SqlConnection connection = new SqlConnection(connstring);
                SqlDataAdapter dataAdaper = new SqlDataAdapter(sqlcmd, connection);
                DataSet OrderDs = new DataSet();

                connection.Open();
                dataAdaper.Fill(OrderDs, "Test_DB");
                connection.Close();

                dataGridView1.DataSource = OrderDs;
                dataGridView1.DataMember = "Test_DB";
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderDBDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.orderDBDataSet.Order);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderTableAdapter.FillBy(this.orderDBDataSet.Order);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
