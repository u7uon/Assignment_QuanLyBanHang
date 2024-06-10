using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang
{
    public class DBConnect
    {
        //Tạo chuỗi kết nối đến cơ sở dữ liệu
        protected SqlConnection _conn = new SqlConnection(@"Data Source=U7;Initial Catalog=QuanLyBanHangg;Integrated Security=True;Encrypt=False    ");

    }
}
