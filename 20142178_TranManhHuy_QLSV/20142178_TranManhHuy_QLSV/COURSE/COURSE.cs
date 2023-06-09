using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20142178_TranManhHuy_QLSV
{
    internal class COURSE
    {
        MY_DB mydb = new MY_DB();
        // function to insert a new course

        public bool insertCourse(int id, string courseName, string group, string contactID, int hoursNumber, string semester, string dayOfWeek, int classPeriodStart, int classPeriodEnd, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course (id, label, [group], contactID, period, semester, dayOfWeek, classPeriodStart, classPeriodEnd, description) VALUES (@id, @label, @group, @contactID, @hrs, @semes, @day, @classStart, @classEnd, @descr)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@group", SqlDbType.NVarChar).Value = group;
            command.Parameters.Add("@contactID", SqlDbType.NVarChar).Value = contactID;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@semes", SqlDbType.NVarChar).Value = semester;
            command.Parameters.Add("@day", SqlDbType.NVarChar).Value = dayOfWeek;
            command.Parameters.Add("@classStart", SqlDbType.Int).Value = classPeriodStart;
            command.Parameters.Add("@classEnd", SqlDbType.Int).Value = classPeriodEnd;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;

            mydb.openConnection();

            if (command.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool updateCourse(int id, string courseName, string group, string contactID, int hoursNumber, string semester, string dayOfWeek, int classPeriodStart, int classPeriodEnd, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET label=@name, [group]=@group, contactID=@contactID, period=@hrs, description=@descr, semester=@semes, dayOfWeek=@day, classPeriodStart=@classStart, classPeriodEnd=@classEnd WHERE id = " + id, mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@group", SqlDbType.NVarChar).Value = group;
            command.Parameters.Add("@contactID", SqlDbType.NVarChar).Value = contactID;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@semes", SqlDbType.NVarChar).Value = semester;
            command.Parameters.Add("@day", SqlDbType.NVarChar).Value = dayOfWeek;
            command.Parameters.Add("@classStart", SqlDbType.Int).Value = classPeriodStart;
            command.Parameters.Add("@classEnd", SqlDbType.Int).Value = classPeriodEnd;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;

            mydb.openConnection();

            if (command.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool deleteCourse(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            mydb.openConnection();

            if (command.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // function to return a course by id
        public bool checkCourseName(string courseName, int courseId = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label=@label and id <> @id", mydb.getConnection);
            command.Parameters.Add("@label", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@id", SqlDbType.Int).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable getCourses(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllCourses()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        // funct to return a course by ID
        public DataTable getCoursesById(int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE id = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // function to execute the count query
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }

        public string totalCourses()
        {
            return execCount("Select count(*) from Course");
        }
    }
}
