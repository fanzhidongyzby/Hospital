using System.Data.SqlClient;
using System;
using System.Data;

namespace Hospital
{
    public class Database
    {
        private static String connStr = @"server=.;Initial Catalog=hospital;Integrated Security=True";

        private static Database db = null;

        private SqlConnection conn = null;

        private Database()
        {
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        ~Database()
        {
            try
            {
                conn.Close();
            }
            catch
            { }

        }

        public static Database getInstance()
        {
            if (db == null)
            {
                db = new Database();
            }

            return db;
        }

        private bool onTransaction = false;
        private SqlTransaction trans = null;

        public void beginTransaction()
        {
            onTransaction = true;
            trans = conn.BeginTransaction();
        }

        public void endTransaction(bool norollback)
        {
            if (norollback)
            {
                trans.Commit();
            }
            else 
            {
                trans.Rollback();
            }

            trans = null;
            onTransaction = false;
        }

        public bool update(String cmd)
        {
            try
            {
                SqlCommand com = new SqlCommand(cmd, conn);
                if (onTransaction)
                {
                    com.Transaction = trans;
                }
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            { }
            return false;
        }

        public DataTable queryDataTable(String cmd)
        {
            try
            {
                SqlCommand com = new SqlCommand(cmd, conn);
                if (onTransaction)
                {
                    com.Transaction = trans;
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = com;
                DataSet set = new DataSet();
                adapter.Fill(set);
                return set.Tables[0];
            }
            catch (Exception)
            { }
            return null;
        }
    }
}