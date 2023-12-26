using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TangTanBao_HangHoa
{
    public partial class Fromhanghoa : Form
    {
       
        SqlConnection Kn = new SqlConnection("Data Source=.;Initial Catalog=QLBH;Integrated Security=True;Encrypt=False");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        DataTable dtb = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public Fromhanghoa()
        {
            InitializeComponent();
        }

        private void Fromhanghoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet1.MATHANG' table. You can move, or remove it, as needed.
            this.mATHANGTableAdapter1.Fill(this.qLBHDataSet1.MATHANG);
            // TODO: This line of code loads data into the 'qLBHDataSet.MATHANG' table. You can move, or remove it, as needed.

            loadthongtin();
            databinding();
        }

        private void loadthongtin()
        {
            string query = "SELECT * FROM LOAIHANG";
        adapter = new SqlDataAdapter(query, Kn);
        DataTable dtbtt = new DataTable();
        adapter.Fill(dtbtt);
            bs.DataSource = dtbtt;
            bindingNavigator1.BindingSource = bs;
        }
    private void databinding()
    {
        //string sql = "SELECT * FROM LOAIHANG";
        //adapter = new SqlDataAdapter(sql, Kn);
        //ds.Clear();
        //adapter.Fill(ds);
        //bs.DataSource = ds.Tables[0];
        //txtMaLH.DataBindings.Clear();
        //txtLoaiHang.DataBindings.Clear();
        txtMaLH.DataBindings.Add("Text", bs, "MaLoaiHang", true);
        txtLoaiHang.DataBindings.Add("Text", bs, "TenLoaiHang", true);
    }
    private void loadmathangtheodoi(string maloai)
    {
        string query = "SELECT * FROM MATHANG WHERE MALOAIHANG = '" + txtMaLH.Text + "'";
        adapter = new SqlDataAdapter(query, Kn);
        DataTable dtbmh = new DataTable();
        adapter.Fill(dtbmh);
        dataGridViewMH.DataSource = dtbmh;
    }
    private void tinhtongtien(string maloai)
    {
        string sql = "SELECT SUM(SoLuong*GiaHang) FROM MATHANG WHERE MaLoaiHang = '" + txtMaLH.Text + "'";
        cmd = new SqlCommand(sql, Kn);
        if (Kn.State == ConnectionState.Closed)
            Kn.Open();
        txttongtien.Text = cmd.ExecuteScalar().ToString();
    }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT SUM(SoLuong*GiaHang) FROM MATHANG WHERE MaLoaiHang = '" + txtMaLH.Text + "'";
            cmd = new SqlCommand(sql, Kn);
            if (Kn.State == ConnectionState.Closed)
                Kn.Open();
            txttongtien.Text = cmd.ExecuteScalar().ToString();
        }

        private void txtMaLH_TextChanged(object sender, EventArgs e)
        {
            loadmathangtheodoi(txtMaLH.Text);
            tinhtongtien(txtMaLH.Text);
        }
    }
}
