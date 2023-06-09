using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20142178_TranManhHuy_QLSV
{
    internal class USER
    {
        MY_DB mydb = new MY_DB();

        public DataTable getUsers(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // function to insert a new user to temp-login

        public bool insertTempUser(string Id, string username, string password, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Temp_Log_in (Id, username, password, email)" + " VALUES(@id, @uname, @pass, @email)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))

            {
                mydb.closeConnection();
                return true;
            }

            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool insertTempHumanResource(string id, string fname, string lname, string username, string password, string email, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Temp_HumanResource (Id, fname, lname, username, password, email, picture)" + " VALUES(@id, @fn, @ln, @uname, @pass, @email, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@uname", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))

            {
                mydb.closeConnection();
                return true;
            }

            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        // function to insert a new user

        public bool insertUser(string Id, string username, string password, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Log_in (Id, username, password, email)" + " VALUES(@id, @uname, @pass, @email)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))

            {
                mydb.closeConnection();
                return true;
            }

            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool CheckUserName(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Log_in where username = @uname", mydb.getConnection);
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        public bool CheckUserHumanResourceName(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource where username = @uname", mydb.getConnection);
            command.Parameters.Add("@uname", SqlDbType.NVarChar).Value = username;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        public bool CheckUserHumanResourceID(string id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource where id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        public bool insertTempContact(string Id, string username, string password, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Temp_Log_in_Contact (Id, username, password, email)" + " VALUES(@id, @uname, @pass, @email)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))

            {
                mydb.closeConnection();
                return true;
            }

            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool inserContact(string Id, string username, string password, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Log_in_Contact (Id, username, password, email)" + " VALUES(@id, @uname, @pass, @email)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))

            {
                mydb.closeConnection();
                return true;
            }

            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool CheckContactName(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Log_in_Contact where username = @uname", mydb.getConnection);
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
    }
}
