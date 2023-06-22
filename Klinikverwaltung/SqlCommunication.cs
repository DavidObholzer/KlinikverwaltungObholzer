using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

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

            return exist;
        }

        static public bool checkForAdmin(string username)
        {
            bool admin = false;

            if (username.Equals(""))
            {
                return false;
            }

            try
            {
                con.Open();
                cmd.CommandText = "SELECT admin from TblUser where username = '" + username + "'";

                admin = cmd.ExecuteScalar().ToString().Equals("True");

                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                MessageBox.Show(ex.ToString());
            }

            return admin;
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
                        "[password] NVARCHAR (100)," +
                        "[admin] BIT)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE TblRoom([roomId] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[roomName] NVARCHAR (50), " +
                        "[floorLevel] int)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE TblPatient([patientId] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[name] NVARCHAR (50), " +
                        "[lastname] NVARCHAR (50), " +
                        "[birthday] date," +
                        "[dateOfArrival] date," +
                        "[plannedLeave] date," +
                        "[roomId] int, " +
                        "CONSTRAINT FK_patient_roomId FOREIGN KEY (roomId)" +
                        "REFERENCES TblRoom (roomId))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE TblStaff([staffId] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[name] NVARCHAR (50), " +
                        "[lastname] NVARCHAR (50), " +
                        "[birthday] date," +
                        "[monthlySalary] DECIMAL(8,2)," +
                        "[profession] NVARCHAR (50))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE TblAppointment([appointmentId] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[pId] int, " +
                        "[sId] int, " +
                        "[date] date," +
                        "[rId] int," +
                        "[description] NVARCHAR (MAX), " +
                        "CONSTRAINT FK_appointment_patientId FOREIGN KEY (pId)" +
                        "REFERENCES TblPatient (patientId), " +
                        "CONSTRAINT FK_appointment_staffId FOREIGN KEY (sId)" +
                        "REFERENCES TblStaff (staffId), " +
                        "CONSTRAINT FK_appointment_roomId FOREIGN KEY (rId)" +
                        "REFERENCES TblRoom (roomId))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE TblShift([shiftId] INT NOT NULL PRIMARY KEY IDENTITY, " +
                        "[sId] int, " +
                        "[startDate] smalldatetime," +
                        "[endDate] smalldatetime," +
                        "[description] NVARCHAR (MAX)" +
                        "CONSTRAINT Fk_shift_staffID FOREIGN KEY (sId)" +
                        "REFERENCES TblStaff (staffId))";
                    cmd.ExecuteNonQuery();

                    //test stuff
                    cmd.CommandText = "insert into TblRoom values ('RaumRaum', 0)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "insert into TblStaff values ('Hans', 'Hasenauer', '2001-02-02', 3400.00, " +
                        "'Doktor');";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "insert into TblPatient values ('Peter', 'Fischer', '2001-02-02', '2023-02-23', " +
                        "'2023-05-20', 1);";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "insert into TblAppointment values (1, 1, '2023-05-12', 1, " +
                        "'dumb things happpening here')";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "insert into TblShift values (1, '2023-05-12 08:00:00', " +
                        "'2023-05-12 12:00:00', 'lorem ipsum')";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    insertIntoUser("david", "test", "true");
                }
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        static public void insertIntoUser(string username, string password, string admin)
        {
            try
            {
                con.Open();

                cmd.CommandText = "insert into TblUser values ('" + username + "', '" + BCrypt.HashPassword(password, BCrypt.GenerateSalt())
                    + "', '" + admin + "')";
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

        static public void deleteUser(string id)
        {
            try
            {
                con.Open();

                cmd.CommandText = "delete from TblUser where id= " + id;
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

                if (cmd.ExecuteScalar() == null)
                {
                    con.Close();
                    return false;
                }

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
            //should probably be replaced by a class 
            List<List<string>> appointments = new List<List<string>>();
            List<string> lsPatient = new List<string>();
            List<string> lsStaff = new List<string>();
            List<string> lsRoomName = new List<string>();
            List<string> lsId = new List<string>();



            try
            {
                con.Open();

                cmd.CommandText = "select TblPatient.name, TblPatient.lastname, TblStaff.name, TblStaff.lastname, " +
                    "roomName, TblAppointment.appointmentId from TblAppointment " +
                    "inner join TblPatient on (TblPatient.patientId = TblAppointment.pId) " +
                    "inner join TblStaff on (TblStaff.staffId = TblAppointment.sId) " +
                    "inner join TblRoom on (TblRoom.roomId = TblAppointment.rId) " +
                    "where TblAppointment.date = '" + date + "'";
                sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        lsPatient.Add(sdr[0].ToString() + " " + sdr[1].ToString());
                        lsStaff.Add(sdr[2].ToString() + " " + sdr[3].ToString());
                        lsRoomName.Add(sdr[4].ToString());
                        lsId.Add(sdr[5].ToString());
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
            appointments.Add(lsId);

            return appointments;
        }

        public static void deleteAppointment(int id)
        {
            try
            {
                con.Open();

                cmd.CommandText = "Delete from TblAppointment where appointmentId = " + id;

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

        //untested
        public static void setAppointment(string pId, string sId, string date, string roomId, string description)
        {
            try
            {
                con.Open();

                cmd.CommandText = "Insert into TblAppointment values(" + pId + ", " + sId + ", '" + date + "', " +
                    roomId + ", '" + description + "')";

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

        public static void createStaff(string name, string lastname, string birthdate, string salary, string profession)
        {
            try
            {
                con.Open();

                cmd.CommandText = "Insert into TblStaff values('" + name + "', '" + lastname + "', '" + birthdate + "', " +
                    salary + ", '" + profession + "')";

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Aktion erfolgreich ausgeführt", "Info", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        public static void changeStaff(string id, string name, string lastname, string birthday, string salary, string profession)
        {
            try
            {
                con.Open();

                cmd.CommandText = "Update TblStaff set name='" + name + "', lastname='" + lastname + "', birthday='" + birthday +
                    "', monthlySalary=" + salary + ", profession='" + profession + "' " +
                    "where staffId = " + id;

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Aktion erfolgreich ausgeführt", "Info", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool checkStaffId(string id)
        {
            bool exist = false;
            try
            {
                con.Open();
                cmd.CommandText = "SELECT COUNT(*) FROM TblStaff WHERE staffId = " + id;

                exist = Convert.ToInt32(cmd.ExecuteScalar()) == 1;
                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                MessageBox.Show(ex.ToString());
            }

            return exist;
        }

        public static List<Shift> getShifts(string id)
        {
            List<Shift> lShift = new List<Shift>();
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM TblShift WHERE sId = " + id
                    + " order by startDate";

                sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Shift newShift = new Shift();
                        newShift.shiftId = sdr.GetInt32(0);
                        newShift.sId = sdr.GetInt32(1);
                        newShift.startDate = sdr.GetDateTime(2);
                        newShift.endDate = sdr.GetDateTime(3);
                        //newShift.description = sdr.GetString(4);
                        lShift.Add(newShift);
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

            return lShift;
        }

        public static DataTable fillDataTable(string tableName)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select * from " + tableName, con);
                sda.Fill(dt);

                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();

                MessageBox.Show(ex.Message);
            }

            return dt;
        }
    }
}
