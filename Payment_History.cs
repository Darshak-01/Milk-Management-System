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
namespace mms
{
    public partial class Payment_History : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Payment_History()
        {
            InitializeComponent();
        }

        private void Payment_History_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-5311C5J\\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select coust_id as 'Code',coust_name as 'Customer Name',giving_date as 'Payment Date',giving_money as 'Pay Amount' from giving_payment", con);
            SqlDataReader dr=cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
