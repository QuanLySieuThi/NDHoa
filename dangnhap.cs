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

namespace Quản_lý_bán_hàng
{
    public partial class Formdangnhap : Form
    {
        
        public Formdangnhap()
        {
            InitializeComponent();
        }

        private void Fdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
                       
         SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NL36GS2\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True");

            string tk = txtTenDN.Text.Trim();
            string mk = txtMK.Text.Trim();
            string query = "Select * from tblDangNhap where TenDangNhap = '" + txtTenDN.Text.Trim() + "' and MatKhau = '" + txtMK.Text.Trim() + "'";
         conn.Open();
         SqlDataAdapter sda1 = new SqlDataAdapter(query, conn); // Thực thi lệnh query voi ket noi tren
         DataTable dtbl = new DataTable();
         sda1.Fill(dtbl);
         if(dtbl.Rows.Count ==1)
        {
            frmMain objfrmMain = new frmMain();
            this.Hide();
            objfrmMain.ShowDialog();
                this.Close();//thêm cái này vao.khi show frm mới thì đóng frm cũ
        }      
        
        
    }
}
