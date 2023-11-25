using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongMe
{
    class Database
    {
        SqlConnection sqlConn; //Đối tượng kết nối CSDL
        SqlDataAdapter da;//Bộ điều phối dữ liệu
        DataSet ds; //Đối tượng chứa CSDL khi giao tiếp
        //Tự thấy data source = tên máy của mình để chạy được

        public Database()
        {
            string strCnn = "data source=DANGKHOABACH;initial catalog=QLTiemTraSua;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            sqlConn = new SqlConnection(strCnn);
        }

        //Phương thức để thực hiện câu lệnh strSQL truy vấn dữ liệu
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
