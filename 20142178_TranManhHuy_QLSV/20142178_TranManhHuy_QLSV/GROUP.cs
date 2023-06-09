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
    internal class GROUP
    {
        MY_DB mydb = new MY_DB();

        public bool insertGroup(string hrID, string nameGroup)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Group] (hrID, nameGroup)" + " VALUES(@hrID, @nameGroup)", mydb.getConnection);
            command.Parameters.Add("@hrID", SqlDbType.NVarChar).Value = hrID;
            command.Parameters.Add("@nameGroup", SqlDbType.NVarChar).Value = nameGroup;
            
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

        public bool updateGroup(string oldNameGroup, string newNameGroup)
        {
            SqlCommand command = new SqlCommand("UPDATE [Group] SET nameGroup = @newNameGroup WHERE nameGroup = '" + oldNameGroup + "'", mydb.getConnection);

            command.Parameters.Add("@newNameGroup", SqlDbType.NVarChar).Value = newNameGroup;

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
        public bool deleteGroup(string nameGroup)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Group] WHERE nameGroup = @nameGroup", mydb.getConnection);

            command.Parameters.Add("@nameGroup", SqlDbType.NVarChar).Value = nameGroup;

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
        public DataTable getAllGroups()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Group]", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}