using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20142178_TranManhHuy_QLSV
{
    internal class SCORE
    {
        MY_DB mydb = new MY_DB();

        public bool insertScore(string studentID, int courseID, float score, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Score (studentId, courseId, score, description)" + " VALUES(@studentID, @courseID, @score, @description)", mydb.getConnection);

            command.Parameters.Add("@studentID", SqlDbType.VarChar).Value = studentID;
            command.Parameters.Add("@courseID", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@score", SqlDbType.Float).Value = score;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;

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

        public bool deleteScore(string studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Score WHERE studentId = @studentID and courseID = @courseID", mydb.getConnection);

            command.Parameters.Add("@studentID", SqlDbType.VarChar).Value = studentID;
            command.Parameters.Add("@courseID", SqlDbType.Int).Value = courseID;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        public bool studentScoreExist(string studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE studentId = @studentID and courseId = @courseID", mydb.getConnection);

            command.Parameters.Add("@studentID", SqlDbType.VarChar).Value = studentID;
            command.Parameters.Add("@courseID", SqlDbType.Int).Value = courseID;

            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable getStudentScore()
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT Score.studentId AS [Student ID], Std.fname AS [First Name], Std.lname AS [Last Name], Score.courseId AS [Course ID], Course.label AS [Course Name], Score.score AS [Score] FROM Std INNER JOIN Score ON Std.id = Score.studentID INNER JOIN Course ON Score.courseId = Course.id");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // tính điểm trung bình của môn học đó với
        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT Course.label AS [Course Name], AVG(Score.score) AS [Average Grade] FROM Course, Score WHERE Course.id = Score.courseId GROUP BY Course.label");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // get course scores
        public DataTable getCourseScores(int courseId)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT Score.studentId, Std.fname, Std.lname, Score.courseId, Course.label, Score.score FROM Std INNER JOIN Std.id = score.studentId INNER JOIN Course on Score.courseId = Course.id WHERE Score.courseId = " + courseId + "'");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // get student 's scores by id
        public DataTable getStudentScores(string studentId)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT Score.courseId AS [Course ID], Course.label AS [Course Name], Score.score AS [Score], Score.description AS[Description] , Score.result AS [Result] FROM Course INNER JOIN Score ON Score.courseId = Course.id WHERE score.studentId = '" + studentId + "'");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count;
            if (command.ExecuteScalar() == null)
            {
                count = "0";
            }
            else
            {
                count = command.ExecuteScalar().ToString();

            }
            mydb.closeConnection();
            return count;
        }

        // tính số lượng học sinh học khóa học được truyền vào và xếp loại đươc truyền vào
        public string totalCourseStudentByType(string course, string type)
        {
            return execCount("SELECT COUNT(*) FROM Score INNER JOIN Course ON courseId = id WHERE result = '" + type + "' AND label = '" + course + "' GROUP BY Course.label");
        }
        // tính số lượng học sinh đã học khóa học truyền vào
        public string totalCourseStudent(string course)
        {
            return execCount("SELECT COUNT(*) FROM Score INNER JOIN Course ON courseId = id WHERE label = '" + course + "' GROUP BY Course.label");
        }
        // tính điểm trung bình học sinh đã học ở kì học truyền vào
        public string avgCourseStudentBySemester(string studentID, string semester)
        {
            return execCount("SELECT ROUND(AVG(score), 2) FROM Score INNER JOIN Course ON courseId = id WHERE semester = '" + semester + "' AND studentId = '" + studentID + "' GROUP BY studentId");
        }
        // tính điểm trung bình học sinh đã học ở kì học truyền vào
        public string avgAllCourseStudent(string studentID)
        {
            return execCount("SELECT ROUND(AVG(score), 2) FROM Score INNER JOIN Course ON courseId = id WHERE studentId = '" + studentID + "' GROUP BY studentId");
        }
    }
}
