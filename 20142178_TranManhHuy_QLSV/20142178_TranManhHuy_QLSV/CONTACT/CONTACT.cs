using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using System.IO;

namespace _20142178_TranManhHuy_QLSV
{
    internal class CONTACT
    {
        MY_DB mydb = new MY_DB();

        public DataTable getContacts(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertContact(string contactID, string fname, string lname, string group, string phone, string email, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO MyContact (contactID, fname, lname, [group], phone, email, address, picture)" + " VALUES(@contactID, @fname, @lname, @group, @phone, @email, @address, @picture)", mydb.getConnection);
            command.Parameters.Add("@contactID", SqlDbType.NVarChar).Value = contactID;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@group", SqlDbType.NVarChar).Value = group;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();

            if ((command.ExecuteNonQuery() >= 1))

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

        public bool updateContact(string contactID, string fname, string lname, string group, string phone, string email, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE MyContact SET contactID = @contactID, fname = @fname, lname = @lname, [group] = @group, phone = @phone, email = @email, address = @address, picture = @picture  WHERE contactID = " + contactID, mydb.getConnection);

            command.Parameters.Add("@contactID", SqlDbType.NVarChar).Value = contactID;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@group", SqlDbType.NVarChar).Value = group;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if ((command.ExecuteNonQuery() >= 1))

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
        public bool deleteContact(int contactID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM MyContact WHERE contactID = @contactID", mydb.getConnection);

            command.Parameters.Add("@contactID", SqlDbType.Int).Value = contactID;

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
        public bool insertNotification(string contactID, string fname, string lname, string courseName, string title, string content, DateTime timeSend)
        {
            string fullName = fname + " " + lname;
            SqlCommand command = new SqlCommand("INSERT INTO Notification (contactID, fullName, courseName, title, content, timeSend)" + " VALUES(@contactID, @fullName, @courseName, @title, @content, @timeSend)", mydb.getConnection);
            command.Parameters.Add("@contactID", SqlDbType.NVarChar).Value = contactID;
            command.Parameters.Add("@fullName", SqlDbType.NVarChar).Value = fullName;
            command.Parameters.Add("@courseName", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
            command.Parameters.Add("@content", SqlDbType.NVarChar).Value = content;
            command.Parameters.Add("@timeSend", SqlDbType.DateTime).Value = timeSend;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() >= 1))

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
    }
}
