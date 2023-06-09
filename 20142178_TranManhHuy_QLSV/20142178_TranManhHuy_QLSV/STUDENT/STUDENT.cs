using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _20142178_TranManhHuy_QLSV
{
    internal class STUDENT
    {
        MY_DB mydb = new MY_DB();

        // function to insert a new student

        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, string faculty, string major, string hometown, string acayear, string email, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, faculty, major, hometown, acayear, email, picture)" + " VALUES(@id, @fn, @ln, @bdt, @gdr, @phn, @adrs, @facty, @mjor, @htown, @ayear, @email, @pic)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@facty", SqlDbType.VarChar).Value = faculty;
            command.Parameters.Add("@mjor", SqlDbType.VarChar).Value = major;
            command.Parameters.Add("@htown", SqlDbType.VarChar).Value = hometown;
            command.Parameters.Add("@ayear", SqlDbType.VarChar).Value = acayear;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getFaculty()
        {
            SqlCommand command = new SqlCommand("SELECT DISTINCT faculty FROM Std", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable getMajor()
        {
            SqlCommand command = new SqlCommand("SELECT DISTINCT major FROM Std", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable getAcayear()
        {
            SqlCommand command = new SqlCommand("SELECT DISTINCT acayear FROM Std", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public bool updateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, string faculty, string major, string hometown, string acayear, string email, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET id = @id, fname = @fn, lname = @ln, bdate = @bdt, gender = @gdr, phone = @phn, address = @adrs, faculty = @facty, major = @mjor, hometown = @htown, acayear = @ayear, email = @email, picture = @pic WHERE id = " + Id, mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@facty", SqlDbType.VarChar).Value = faculty;
            command.Parameters.Add("@mjor", SqlDbType.VarChar).Value = major;
            command.Parameters.Add("@htown", SqlDbType.VarChar).Value = hometown;
            command.Parameters.Add("@ayear", SqlDbType.VarChar).Value = acayear;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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

        public bool deleteStudent(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

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

        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM Std");
        }
        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM Std WHERE gender = 'Male'");
        }
        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM Std WHERE gender = 'Female'");
        }

        public bool insertStudentCourse(int Id, string fname, string lname, string coursename, string semester)
        {
            SqlCommand command = new SqlCommand("INSERT INTO CourseStudent (studentId, fname, lname, courseName,semester)" + " VALUES(@id, @fn, @ln, @courn, @sester)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@courn", SqlDbType.VarChar).Value = coursename;
            command.Parameters.Add("@sester", SqlDbType.VarChar).Value = semester;

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

        public DataTable getStudentCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CourseStudent", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public bool deleteCourseStudent(int Id, string nameCourse, string semester)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CourseStudent WHERE studentId = @id AND courseName = @nameCour AND semester = @semes", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@nameCour", SqlDbType.VarChar).Value = nameCourse;
            command.Parameters.Add("@semes", SqlDbType.VarChar).Value = semester;

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
    }
}
