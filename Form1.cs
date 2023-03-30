using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLySieuThi1.MainForm;

namespace QuanLySieuThi1
{  
    public delegate void Load1();
    public partial class MainForm : Form
    {
        // ko có đối số, giống load_data
        //public LoadData  loadData;
        
        public MainForm()
        {
            InitializeComponent();
            SetCBBSort();
        
            }

        private void MainForm_Load(object sender, EventArgs e)
        {
           Load_data();
           // loadData = new LoadData(Load_data);
           // 
        }
        private void Load_data()
        {
            string query = "select MaSP, TenSP, NhaSX, Ngaynhap, TenMH, Tinhtrang from SanPham as S inner join MatHang as M on S.MaMH = M.MaMH ";
            DataTable dt = new DataTable();
            dt = DBHelper.Instance.GetRecords(query);
            dtgMain.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //dt.Rows[i]["Số thứ tự"] = i + 1;
                dtgMain.Rows[i].Cells[0].Value = (i + 1);
            }
        }
        //public void RefreshData()
        //{
        //    Load_data();
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dtgMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn SP cần xóa");
                return;
            }
            DataGridViewRow sel = dtgMain.SelectedRows[0];
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                List<string> del = new List<string>();
                foreach (DataGridViewRow i in dtgMain.SelectedRows)
                {
                    del.Add(i.Cells["MaSP"].Value.ToString());
                }    
                foreach(string MaSP in del)
                {
                    string query = "delete from SanPham where MaSP = '" + MaSP + "'";
                    DBHelper.Instance.ExecuteDB(query);

                }
                Load_data();
            } 
                
        }
        public void SetCBBSort()
        {
            cbbSort.Items.Add("Ngaynhap");
            cbbSort.Items.Add("MaSP");
            cbbSort.SelectedIndex = 0;

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string s = cbbSort.SelectedItem.ToString();
            DataTable dt = new DataTable();
            string query = "select MaSP, TenSP, NhaSX, Ngaynhap, TenMH, Tinhtrang from SanPham as S inner join MatHang as M on S.MaMH = M.MaMH order by " + s + " desc ";
            dt = DBHelper.Instance.GetRecords(query);
            dtgMain.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //dt.Rows[i]["Số thứ tự"] = i + 1;
                dtgMain.Rows[i].Cells[0].Value = (i + 1);
            }
        }
        public void GetSPsearch(string Tensp)
        {
            DataTable dt = new DataTable();
            if (txtSearch.Text == "")
            {
                Load_data();
            } 
            else if (txtSearch.Text != "")
            {
                string query = "select MaSP, TenSP, NhaSX, Ngaynhap, TenMH, Tinhtrang from SanPham as S inner join MatHang as M on S.MaMH = M.MaMH And TenSP = '" + Tensp + "'";
                dtgMain.DataSource = DBHelper.Instance.GetRecords(query);
            }    
                
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Tensp = txtSearch.Text;
            GetSPsearch(Tensp);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailForm f = new DetailForm(Load_data, null);
            f.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dtgMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chon Sinh Vien can Update");
                return;
            }
            if (dtgMain.SelectedRows.Count == 1)
            {
                string MaSP = dtgMain.SelectedRows[0].Cells["MaSP"].Value.ToString();
                DetailForm f = new DetailForm(Load_data,MaSP);
               
                f.Show();
               
            }
           
          
        }
    }
}
