using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Klinikverwaltung
{
    internal class SqlCommunication
    {
        static SqlConnection con = new SqlConnection("server=localdb)\\MSSQLLocalDB;");
        static SqlCommand cmd = new SqlCommand("", con);
        static SqlDataReader dr;

        static public bool checkForDatabase()
        {
            bool exist = false;
            try
            {
                con.Open();
                cmd.CommandText = "SELECT COUNT(*) FROM sys.databases WHERE name = 'DBKlinikverwaltungObholzer";

                exist = Convert.ToInt32(cmd.ExecuteScalar()) == 1;
                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                MessageBox.Show(ex.ToString());
            }

            if (exist)
                return true;
            else
                return false;
        }

        static public void createDatabase()
        {
            if (checkForDatabase())
            {
                con.ConnectionString += "database=DBKlinikverwaltungObholzer";
            }
            else
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "create database DBKlinikverwaltungObholzer";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.ConnectionString += "database=DBKlinikverwaltungObholzer";
                }
                catch (Exception ex)
                {
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        static public void createTables()
        {
            try
            {
                con.Open();

                cmd.CommandText = "CREATE TABLE TblUser([Id] INT NOT NULL PRIMARY KEY IDENTITY, " +
                    "[username] NVARCHAR (50), " +
                    "[password] NVARCHAR (100))";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE TblPatients([Id] INT NOT NULL PRIMARY KEY IDENTITY, " +
                    "[name] NVARCHAR (50), " +
                    "[lastname] NVARCHAR (50), " +
                    "[birthday] date," +
                    "[dateOfArrival] date," +
                    "[plannedLeave] date," +
                    "[notes] NVARCHAR (500))";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE TblStaff([Id] INT NOT NULL PRIMARY KEY IDENTITY, " +
                    "[name] NVARCHAR (50), " +
                    "[lastname] NVARCHAR (50), " +
                    "[birthday] date," +
                    "[monthlySalary] DECIMAL(8,2)" +
                    "[profession] NVARCHAR (50)," +
                    "[notes] NVARCHAR (500))";
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        static public void insertIntoUser(string username, string password)
        {
            try
            {
                con.Open();

                cmd.CommandText = "insert into TblUser values ('" + username + "', '" + BCrypt.HashPassword(password, BCrypt.GenerateSalt() + "')";
                cmd.BeginExecuteNonQuery();
                
                con.Open();
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        static public bool login(string username, string password)
        {
            return false;
        }
    }
}
