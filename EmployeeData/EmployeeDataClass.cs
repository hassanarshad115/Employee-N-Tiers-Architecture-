using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
   public class EmployeeDataClass
    {
        public static void InsertEmployeeData(EmployeeModelClass textboxkijga)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["test"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn) { 
            SqlCommand cmd = new SqlCommand("insertklye", conn);
            cmd.CommandType = CommandType.StoredProcedure;
                //textboxkijga k sath lazmi . krky propery likhni ha jo enter krni ho
            cmd.Parameters.AddWithValue("@name", textboxkijga.namep);
            cmd.Parameters.AddWithValue("@fathername", textboxkijga.fathernamep);
            conn.Open();
            cmd.ExecuteNonQuery();
            //conn.Close();
        }
        }
    }
}
