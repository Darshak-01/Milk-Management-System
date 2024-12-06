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
    public partial class store_data : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public store_data()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void store_data_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-5311C5J\\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select  Date as 'Date',DayOfTime as 'Day Of Time',CowMilk as 'Cow Milk',BuffaloMilk as 'Buffalo Milk',BothMilk as 'Both Milk',TotalMilk 'Total Milk',TotalAmount as'Total ₹'  from store_data", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
