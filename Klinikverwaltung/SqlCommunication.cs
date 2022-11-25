using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinikverwaltung
{
    internal class SqlCommunication
    {
        private static SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB;");
        private static SqlCommand cmd = new SqlCommand("", con);
        private static SqlDataReader sdr;

        public static void LoginSSIP()
        {
            try
            {
                con.ConnectionString += "Integrated securtiy = true;";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool LoginNoSSIP(string Inputusername, string Inputpassword)
        {
            try
            {
                con.Open();
                cmd.CommandText = "Select password from TblUsers where name = '" + Inputusername + "'";
                if (cmd.ExecuteScalar().Equals(Inputpassword))
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }  
        }

        public static void createDatabaseAndTables()
        {
            try
            {
                con.Open();

                bool existenceOfDatabase = false;
                cmd.CommandText = "Select name from master.dbo.sysdatabases where name = 'KlinikverwaltungObholzerDB'";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                {
                    cmd.CommandText = "create database KlinikverwaltungObholzerDB";
                    cmd.ExecuteNonQuery();

                    con.Close();
                    con.ConnectionString += "database=KlinikverwaltungObholzerDB";
                    con.Open();

                    cmd.CommandText = "CREATE TABLE TblPersonal([Id] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[Name] NVARCHAR (50), " +
                        "[Lastname] NVARCHAR (50)," +
                        "[Datum] date," +
                        "[Profession] NVARCHAR (50));";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE TblUsers([Id] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[Username] NVARCHAR (50), " +
                        "[Password] NVARCHAR (50));";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    con.Close();
                    con.ConnectionString += "create database KlinikverwaltungObholzerDB";
                    con.Open();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
