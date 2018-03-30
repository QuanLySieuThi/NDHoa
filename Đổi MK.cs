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
    public partial class formdoipass : Form
    {
        public formdoipass()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NL36GS2\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True");
    
              
        }
       