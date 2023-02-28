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
        static SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB; Integrated security = true;");
        static SqlCommand cmd = new SqlCommand("", con);
        static SqlDataReader sdr;
        private static bool bCreateTable = false;

        static public bool checkForDatabase()
        {
            //check for the existence of the database by selecting every databse in sys.databases
           
            bool exist = false;
            
            try
            {
                con.Open();
                cmd.CommandText = "SELECT COUNT(*) FROM sys.databases WHERE name = 'DBKlinikverwaltungObholzer'";

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

                    bCreateTable = true;
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
                if (bCreateTable)
                {
                    con.Open();

                    cmd.CommandText = "CREATE TABLE TblUser([Id] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[username] NVARCHAR (50), " +
                        "[password] NVARCHAR (100))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE TblPatient([patientId] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[name] NVARCHAR (50), " +
                        "[lastname] NVARCHAR (50), " +
                        "[birthday] date," +
                        "[dateOfArrival] date," +
                        "[plannedLeave] date," +
                        "[notes] NVARCHAR (500)," +
                        "[roomID] int)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE TblStaff([staffId] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[name] NVARCHAR (50), " +
                        "[lastname] NVARCHAR (50), " +
                        "[birthday] date," +
                        "[monthlySalary] DECIMAL(8,2)," +
                        "[profession] NVARCHAR (50)," +
                        "[notes] NVARCHAR (500))";
                    cmd.ExecuteNonQuery();

                    
                    cmd.CommandText = "CREATE TABLE TblAppointment([appointmentId] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[pId] int, " +
                        "[sId] int, " +
                        "[date] date," +
                        "[roomNumber] int," +
                        "[description] NVARCHAR (MAX), " +
                        "CONSTRAINT FK_patientId FOREIGN KEY (pId)" +
                        "REFERENCES TblPatient (patientId), " +
                        "CONSTRAINT FK_staffId FOREIGN KEY (sId)" +
                        "REFERENCES TblStaff (staffId), " +
                        "CONSTRAINT FK_roomId FOREIGN KEY (roomNumber)" +
                        "REFERENCES TblRoom (roomId) " +
                        "ON DELETE CASCADE" +
                        "ON UPDATE CASCADE)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE TblRoom([roomId] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[roomName] NVARCHAR (50), " +
                        "[floorLevel] int)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE TblShift([shiftId] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[sId] int, " +
                        "[starDate] date," +
                        "[endDate] date," +
                        "[description] NVARCHAR (MAX)" +
                        "CONSTRAINT Fk_staffID FOREIGN KEY (sId)" +
                        "REFERENCES TblStaff (staffId)" +
                        "ON DELETE CASCADE" +
                        "ON UPDATE CASCADE)";
                    cmd.ExecuteNonQuery();

                    //test stuff
                    cmd.CommandText = "insert into TblPatient values ('Peter', 'Fischer', 2001-02-02, 2023-02-23, " +
                        "2023-05-20, 'Nothing important', 1);";
                    cmd.CommandText += "insert into TblStaff values ('Hans', 'Hasenauer', 2001-02-02, 3400.00, " +
                        "Doktor, 'Nothing important');";
                    cmd.CommandText += "insert into TblAppointment values (1, 1, 2023-02-23, 1, " +
                        "'dumb things happpening here')";
                    cmd.CommandText += "insert into TblRoom values ('RaumRaum', 0)";
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
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

                cmd.CommandText = "insert into TblUser values ('" + username + "', '" + BCrypt.HashPassword(password, BCrypt.GenerateSalt()) + "')";
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

        static public bool login(string username, string password)
        {
            //checks for correct combination of username and password by "dehashing" the password in the user table
            try
            {
                con.Open();

                cmd.CommandText = "select password from TblUser where username = '" + username + "';";

                if (BCrypt.CheckPassword(password, cmd.ExecuteScalar().ToString()))
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
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                MessageBox.Show(ex.ToString());
            }

            return false;
        }

        public static List<List<string>> getAppointments(string date)
        {
            //returns a list of appointments on a certain date
            List<List<string>> appointments = new List<List<string>>();
            List<string> lsPatient = new List<string>();
            List<string> lsStaff = new List<string>();
            List<string> lsRoomName = new List<string>();

            

            try
            {
                con.Open();

                cmd.CommandText = "select TblPatient.name, TblPatient.lastname, TblStaff.name, TblStaff.lastname, " +
                    "roomName from TblAppointment" +
                    "where date = " + date;
                sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        lsPatient.Add(sdr[0].ToString() + " " + sdr[1].ToString());
                        lsStaff.Add(sdr[2].ToString() + " " + sdr[3].ToString());
                        lsRoomName.Add(sdr[4].ToString());
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                MessageBox.Show(ex.ToString());
            }

            appointments.Add(lsPatient);
            appointments.Add(lsStaff);
            appointments.Add(lsRoomName);

            return appointments;
        }
    }
}
