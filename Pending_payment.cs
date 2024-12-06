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
using System.Data.SqlClient;
namespace mms
{
    public partial class Pending_payment : Form
    {
        SqlConnection con;
        SqlCommand  cmd;
        public Pending_payment()
        {
            InitializeComponent();
        }

        private void Pending_payment_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-5311C5J\\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select * from pending_payment", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
