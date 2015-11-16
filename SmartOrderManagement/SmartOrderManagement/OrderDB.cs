using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SmartOrderManagement
{
    class OrderDB
    {
        private SqlConnection m_DBConnection;
        private DBServerStruct m_dbInfor;
        public void Initialize(DBServerStruct svInfo)
        {   
            string DBConnectionString = "Data Source=" + svInfo.ServerName + ";Initial Catalog="+svInfo.DBName + ";User ID=" + svInfo.Account + ";Password=" + svInfo.Password;
            m_DBConnection = new SqlConnection(DBConnectionString);
            m_dbInfor = svInfo;   
        }
        public void UnInitialize()
        {
            m_DBConnection.Close();
        }
        public bool IsExistOrderTable()
        {
            bool bResult = false;
            if (m_DBConnection == null)
                return bResult;

            try
            {
                string strcmd = "SELECT CASE WHEN EXISTS((SELECT * FROM OrderDB.INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Order')) THEN 1 ELSE 0 END";

                m_DBConnection.Open();
                SqlCommand sqlcmd = new SqlCommand(strcmd, m_DBConnection);

                bResult = (int)sqlcmd.ExecuteScalar() == 1;
                sqlcmd.Dispose();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            m_DBConnection.Close();

            return bResult;
        }
        public bool CreateNewTable()
        {
            bool bResult = false;
            if (m_DBConnection == null)
                return bResult;

            string strCmd = String.Format("CREATE TABLE OrderDB.dbo.[Order](" +
                                            "id int IDENTITY(1,1) NOT NULL  PRIMARY KEY," +
                                            "customer nvarchar(max) NOT NULL," +
                                            "production nvarchar(max)," +
                                            "properties nvarchar(max),"+
                                            "acceptdate datetime,"+
                                            "deadline datetime,"+
                                            "machines nvarchar(max),"+
                                            "note nvarchar(max),"+
                                            "technical nvarchar(max),"+
                                            "Completed int,Delivered int)");
          
            try
            {
                m_DBConnection.Open();
                SqlCommand sqlcmd = new SqlCommand(strCmd, m_DBConnection);
                sqlcmd.ExecuteNonQuery();
                
                bResult = true;
                sqlcmd.Dispose();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            m_DBConnection.Close();

            return bResult;
        }
        public bool Insert(iOrder data)
        {
            bool bResult = false;
            if (!IsExistOrderTable())
                if (!CreateNewTable())
                    return bResult;

            int nCompleted = data.Completed ? 1 : 0;
            int nDelivered = data.Delivered ? 1 : 0;

            string strCmd = "INSERT INTO " + 
                            m_dbInfor.DBName + ".dbo.[Order] " +
                            "(customer,production,properties,acceptdate,deadline,machines,note,technical,completed,delivered) " +
                            "VALUES (N'" +
                            data.Customer + "',N'" +
                            data.Production + "',N'" +
                            data.Properties + "','" +
                            data.AcceptDate + "','" +
                            data.DeadlineDate + "',N'" +
                            data.Machines + "',N'" +
                            data.Note + "',N'" +
                            data.Technical + "'," +
                            nCompleted + "," +
                            nDelivered + ")";
            try
            {
                m_DBConnection.Open();
                SqlCommand sqlcmd = new SqlCommand(strCmd, m_DBConnection);

                sqlcmd.ExecuteNonQuery();

                sqlcmd.Dispose();
                bResult = true;
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
            }
            m_DBConnection.Close();
            return bResult;
        }
        public bool Update(int nID, iOrder data)
        {
            bool bResult = false;
            if (!IsExistOrderTable())
                if (!CreateNewTable())
                    return bResult;

            int nCompleted = data.Completed ? 1 : 0;
            int nDelivered = data.Delivered ? 1 : 0;
            string strCmd = "UPDATE " + m_dbInfor.DBName + ".dbo.[Order] " +
                            "SET customer=N'" + data.Customer + "'," +
                            "production=N'" + data.Production + "'," +
                            "properties=N'" + data.Properties + "'," +
                            "acceptdate='" + data.AcceptDate + "'," +
                            "deadline='" + data.DeadlineDate + "'," +
                            "machines=N'" + data.Machines + "'," +
                            "note=N'" + data.Note + "'," +
                            "technical=N'" + data.Technical + "'," +
                            "completed=" + nCompleted + "," +
                            "delivered=" + nDelivered + " " +
                            "WHERE ID=" + nID + ";"; 
            try
            {
                m_DBConnection.Open();
                SqlCommand sqlcmd = new SqlCommand(strCmd, m_DBConnection);

                sqlcmd.ExecuteNonQuery();
                bResult = true;
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
            }
            m_DBConnection.Close();
            return bResult;

        }
        public bool Query(ref DataSet ds)
        {
            bool bResult = false;
            if (!IsExistOrderTable())
            {
                Console.WriteLine("Order Table is not exist!");
                return bResult;
            }
            string strcmd = "SELECT id,customer,production,properties,acceptdate,deadline,machines,note,technical,completed,delivered FROM " + m_dbInfor.DBName + ".dbo.[Order]";
            try
            {
                m_DBConnection.Open();
                SqlDataAdapter _adapter = new SqlDataAdapter(strcmd, m_DBConnection);
                _adapter.Fill(ds, "Order_List");

                bResult = true;
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
            }
            m_DBConnection.Close();
            return bResult;
        }

        public bool Query(int nID, ref iOrder order)
        {
            bool bResult = false;
            if (!IsExistOrderTable())
            {
                Console.WriteLine("Order Table is not exist!");
                return bResult;
            }

            string strcmd = "SELECT id,customer,production,properties,acceptdate,deadline,machines,note,technical,completed,delivered FROM " + m_dbInfor.DBName + ".dbo.[Order] WHERE ID=" + nID;
            try
            {
                m_DBConnection.Open();
                SqlCommand _sqlcmd = new SqlCommand(strcmd, m_DBConnection);
                SqlDataReader _reader = _sqlcmd.ExecuteReader();
                while (_reader.Read())
                {
                    order.ID = _reader.GetInt32(_reader.GetOrdinal("ID"));
                    order.Customer = _reader.GetString(_reader.GetOrdinal("customer"));
                    order.Production = _reader.GetString(_reader.GetOrdinal("production"));
                    order.Properties = _reader.GetString(_reader.GetOrdinal("properties"));
                    order.AcceptDate = _reader.GetDateTime(_reader.GetOrdinal("acceptdate")); 
                    order.DeadlineDate = _reader.GetDateTime(_reader.GetOrdinal("deadline"));
                    order.Machines = _reader.GetString(_reader.GetOrdinal("machines"));
                    order.Note = _reader.GetString(_reader.GetOrdinal("note"));
                    order.Technical = _reader.GetString(_reader.GetOrdinal("technical"));
                    order.Completed = _reader.GetInt32(_reader.GetOrdinal("completed")) == 1 ? true :false;
                    order.Delivered = _reader.GetInt32(_reader.GetOrdinal("delivered")) == 1 ? true : false; 
                }

                bResult = true;
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
            }
            m_DBConnection.Close();
            return bResult;
        }
        public bool Query(string customer, string production, string AccecptDate, string DeadLineDate, ref DataSet ds)
        {
            bool bResult = false;

            if (!IsExistOrderTable())
            {
                Console.WriteLine("Order Table is not exist!");
                return bResult;
            }

            try
            {

                bResult = true;
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
            }
            return bResult;
        }
        public bool Query(string DateFrom, String DateTo, ref DataSet ds)
        {
            bool bResult = false;

            if (!IsExistOrderTable())
            {
                Console.WriteLine("Order Table is not exist!");
                return bResult;
            }

            try
            {

                bResult = true;
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
            }
            return bResult;
        }
    }
}
