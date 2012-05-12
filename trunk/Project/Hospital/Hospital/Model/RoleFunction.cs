using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Hospital.Functional;

namespace Hospital.Model
{
    class RoleFunction
    {
        public int FunctionID { get; set; }
        public String FucntionName { get; set; }
        public String Button { get; set; }

        public Boolean InsertFunction()
        {
            return true;
        }
        public Boolean UpdateFunction()
        {
            return true;
        }
        public Boolean DeleteFunction()
        {
            return true;
        }
        public static DataTable GetListFunction()
        {
            DataTable dtF = new DataTable();
            string sqlSelect = @"SELECT        FUNCTIONID, FUNCTIONNAME, BUTTON
                                FROM            'FUNCTION'";
            dtF = SqlResult.ExecuteQuery(sqlSelect);
            dtF.Columns[0].ColumnName = "Mã chức năng";
            dtF.Columns[1].ColumnName = "Tên chức năng";
            dtF.Columns[2].ColumnName = "Nút kích hoạt";
            return dtF;
        }
        public RoleFunction GetFunction()
        {
            RoleFunction newFunction = new RoleFunction();

            return newFunction;
        }
    }
}
