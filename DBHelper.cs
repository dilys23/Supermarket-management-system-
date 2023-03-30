using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi1
{
    internal class DBHelper
    {
        // _cnn là biến thành viên của lớp DBHelper
        // _ trước tên biến để phân biệt biến thành viên và biến cục bộ 
        private SqlConnection _cnn;// thiết lập kết nối cơ sở dữ liệu
        private static DBHelper instance; // lưu trữ giá trị duy nhất trong dbhelper

        public static DBHelper Instance {  // thuộc tính đảm bảo chỉ có duy nhất 1 lớp DBHelper đc tạo 
            get
            {
               if(instance == null) instance = new DBHelper("Data Source=LAPTOP-JDFPBP30\\SQLEXPRESS;Initial Catalog=QuanLySieuThi1;Integrated Security=True");
               return instance; // kiểm tra đối tượng DBHelper đã đc tạo chưa, nếu thì tạo mới nó với chuỗi 
            }
            private set { }
        }
        private DBHelper(string s) // hàm khởi tạo và thiết lập cơ sở dữ liệu 
        {
            _cnn = new SqlConnection(s);
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
           // _cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, _cnn);
            _cnn.Open();
            da.Fill(dt);
            _cnn.Close();
            return dt;
        }
        public DataTable GetRecords (string query, SqlParameter p)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, _cnn);
            cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter (cmd);
            _cnn.Open ();
            da.Fill (dt);
            _cnn.Close();
            return dt;


        }
        public List<string> Get_MSP()
        {
            List<string> data = new List<string>();
            DataTable dt = GetRecords("Select MaSP from SanPham");
            foreach (DataRow dr in dt.Rows)
            {
                data.Add(dr["MaSP"].ToString());
            }
            return data.Distinct().ToList();
        }
        public void ExecuteDB(string query) // pthuc sử dụng để thực thi câu truy vấn ko có tham số
        {
            SqlCommand cmd = new SqlCommand(query, _cnn);
            _cnn.Open();
            cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        public void ExecuteDB(string query, SqlParameter p) // câu truy vấn chứa 1 tham số
        {
            SqlCommand cmd = new SqlCommand(query, _cnn);
            cmd.Parameters.Add(p);
            _cnn.Open();
            cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        public void ExecuteDB(string query, SqlParameter[] p) // câu truy vấn chứa nhìu tham số
        {
            SqlCommand cmd = new SqlCommand(query, _cnn);
            foreach (SqlParameter sp in p)
            {
                cmd.Parameters.Add(sp);
            }
            _cnn.Open();
            cmd.ExecuteNonQuery();
            _cnn.Close();
        }
    }
}
