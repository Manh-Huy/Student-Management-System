using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20142178_TranManhHuy_QLSV
{
    public static class Global
    {
        private static string globalUserID;
        public static string GlobalUserID { get => globalUserID; set => globalUserID = value; }

        public static void SetGlobalUserId(string userID)
        {
            GlobalUserID = userID;
        }
    }
}
