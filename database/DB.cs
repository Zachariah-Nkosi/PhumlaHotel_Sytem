using phumla_kamnandi_83.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phumla_kamnandi_83.database
{
    public class DB
    {
        #region Data Fields
        protected string strConn = Settings.Default.PhumlaConnString;
        protected DataSet dsMain;
        protected SqlConnection sqlConn;
        protected SqlDataAdapter dataAdapter;
        #endregion

        #region Constructor
        public DB ()
        {
            try
            {
                
                sqlConn = new SqlConnection(strConn);
                dsMain = new DataSet();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Update Data Set
        public void FillDataSet(string sqlStatement, string aTable)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(sqlStatement, sqlConn);
                sqlConn.Open();
                dsMain.Clear();

                dataAdapter.Fill(dsMain, aTable);
                sqlConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show (e.Message + " " + e.StackTrace);
            }
        }
        #endregion

        #region UpdateDataSource
        public bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                sqlConn.Open();

                dataAdapter.Update(dsMain, table);  //update database via data adapter
                sqlConn.Close();

                FillDataSet(sqlLocal, table);       //refresh the dataset
                
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + " " + errObj.StackTrace);
                success = false;
            }
            finally
            {
                
            }
            return success;
        }
        #endregion
    }
}
