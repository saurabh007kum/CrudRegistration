using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Registration.Models
{
    public class ADOLayer
    {
        public SqlConnection con;
        public ADOLayer()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        }
        public DataTable ExecuteADO(string pr_name, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand(pr_name, con);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter prm in param)
            {
                cmd.Parameters.Add(prm);
            }
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}