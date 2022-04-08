using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class DataLayer
    {
        public DataTable ExecuteData(Property p)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@action",p.action),
                new SqlParameter("@name",p.name),
                new SqlParameter("@email",p.email),
                new SqlParameter("@password",p.password),
                new SqlParameter("@dob",p.dob)
            };
            ADOLayer ado = new ADOLayer();
            DataTable dt = ado.ExecuteADO("sp_Register", param);
            return dt;
        }
    }
}