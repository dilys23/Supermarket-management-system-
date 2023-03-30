using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi1
{
    public partial class DetailForm : Form
    {

        public Load1 loader;// đối tượng property 
        private string MaSP
        {
            get;
            set;
        }
        public DetailForm(Load1 loader, string s)
        {
            InitializeComponent();
            MaSP = s;
            SetCBBMH();
            if (s != null)
            {
                SetGUI();
            }
            this.loader = loader; // gọi hàm Load_data trong 

        }
        public List<string> GetMH()
        {
            List<string> data = new List<string>();
            DataTable dt = new DataTable();

            string query = "select Distinct TenMH from MatHang";
            SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-JDFPBP30\\SQLEXPRESS;Initial Catalog=QuanLySieuThi1;Integrated Security=True");
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                data.Add(row["TenMH"].ToString());
            }
            return data;

        }
        public void SetCBBMH()
        {
            cbbMatHang.Items.AddRange(GetMH().ToArray());
        }
        public void SetGUI()
        {
            string query = "select MaSP, TenSP, NhaSX, Ngaynhap, TenMH, Tinhtrang from SanPham as S inner join MatHang as M on S.MaMH = M.MaMH where MaSP = '" + MaSP + "'";
            DataTable dt2 = DBHelper.Instance.GetRecords(query);
            foreach (DataRow dt in dt2.Rows)
            {

                txtMaSP.Text = MaSP;
                txtTenSP.Text = dt["TenSP"].ToString();
                // Ngaynhap.Value = DateTime.ParseExact("2022-03-23", "yyyy-MM-dd", null);
                Ngaynhap.Value = Convert.ToDateTime(dt["Ngaynhap"].ToString());
                cbbMatHang.Text = dt["TenMH"].ToString();
                cbbSX.Text = dt["NhaSX"].ToString();
                if (Convert.ToBoolean(dt["TinhTrang"].ToString()))
                {
                    rdCon.Checked = true;
                }
                else rdHet.Checked = true;
            }
            txtMaSP.ReadOnly = true;

        }

        private void DetailForm_Load(object sender, EventArgs e)
        {

        }

        private void cbbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.Instance.GetRecords("Select TenMH, NhaSX from MatHang");
            foreach (DataRow dr in dt.Rows)
            {
                if (cbbMatHang.Text == dr["TenMH"].ToString())
                {
                    cbbSX.Text = dr["NhaSX"].ToString();
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool bOk = true;
            SqlParameter[] p = new SqlParameter[7];
            p[0] = new SqlParameter("@MaSP", txtMaSP.Text);
            p[1] = new SqlParameter("@TenSP", txtTenSP.Text);
            p[2] = new SqlParameter("@Ngaynhap", Ngaynhap.Value.ToString());
            p[3] = new SqlParameter("@TenMH", cbbMatHang.Text);
            p[4] = new SqlParameter("@NhaSX", cbbSX.Text);
            p[5] = new SqlParameter("@Tinhtrang", rdCon.Checked);
            DataTable dt = DBHelper.Instance.GetRecords("select MaSP from SanPham");
            DataTable dt1 = DBHelper.Instance.GetRecords("select * from MatHang");
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Ban chua nhap Ma SP");
                bOk = false;
            }

            if (txtTenSP.Text == "")
            {
                bOk= false;
            }
            if (cbbMatHang.Text == "")
            {
                MessageBox.Show("Ban chua nhap Mat  SP");
                bOk = false;
            }
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Ban chua nhap Ma SP");
               bOk = false;
            }
            //if (rdCon.Checked = true && rdHet.Checked = false) {
            //    MessageBox.Show("Ban chua lua chon tinh trang");
            //}
            string MaMH = "";
            if (MaSP != null && bOk == true)
            {


                foreach (DataRow dr in dt1.Rows)
                {
                    if (cbbMatHang.Text == dr["TenMH"].ToString())
                    {
                        MaMH = dr["MaMH"].ToString();
                    }
                }
                p[6] = new SqlParameter("@MaMH", MaMH);
                string query1 = "update SanPham set TenSP = @TenSP , Ngaynhap = @Ngaynhap, Tinhtrang = @Tinhtrang,MaMH = @MaMH where MaSP =  '" + MaSP + "'";
                DBHelper.Instance.ExecuteDB(query1, p);
                this.loader();
                this.Dispose();

            }
            if (MaSP == null && bOk == true)
            {
                foreach (DataRow dr in dt1.Rows)
                {
                    if (cbbMatHang.Text == dr["TenMH"].ToString())
                    {
                        MaMH = dr["MaMH"].ToString();
                    }
                }
                p[6] = new SqlParameter("@MaMH", MaMH);
                List<string> list = new List<string>();
                list = DBHelper.Instance.Get_MSP();
                bool trung = false;
                foreach (string s in list)
                {
                    if (s == txtMaSP.Text)
                    {
                        MessageBox.Show("Ma SP bị trùng");
                        trung = true;
                    }
                }
                if (!trung)
                {

                    string query2 = "insert into SanPham values (@MaSP, @TenSP, @Ngaynhap, @Tinhtrang, @MaMH)";
                    DBHelper.Instance.ExecuteDB(query2, p);
                    this.loader();
                    this.Dispose();
                }

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

