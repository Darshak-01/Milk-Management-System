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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;


namespace mms
{
    public partial class Stock : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        store_data sd = new store_data();
        public Stock()
        {
            InitializeComponent();
        }

        //today total milk of buffalo
        private void label7_Click(object sender, EventArgs e)
        {

        }

       //today total milk of both       
        private void label9_Click(object sender, EventArgs e)
        {

        }

        //total day of milk
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {
           
            //today total milk of cow

           con = new SqlConnection(@"Data Source=DESKTOP-5311C5J\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True");
           con.Open();
          
            DateTime dates = DateTime.Now;
            date.Text = dates.ToString("dd-MM-yyyy");
        }

        private void cmdDay_of_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("Select SUM(liter) from DailyEntry where Product_type='cow' and Date='"+DateTime.Now+"' and day_of_time='"+dot.Text+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            c.Text = "0";
            if (dr.Read())
            {
                c.Text = dr.GetValue(0).ToString(); //milk total print
                if (c.Text == "")
                {
                    c.Text = "0";
                }
            }
            else
            {
                c.Text = "0";   
            }
            dr.Close();
            cmd = new SqlCommand("Select SUM(liter) from DailyEntry where Product_type='buffalo' and Date='"+DateTime.Now+"' and day_of_time='"+dot.Text+"'", con);
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                bm.Text = dr1.GetValue(0).ToString(); //milk total print 
                if (bm.Text == "")
                {
                    bm.Text = "0";
                }
            }
            else
            {
                bm.Text = "0";
            }
            dr1.Close();
            cmd = new SqlCommand("Select SUM(liter) from DailyEntry where Product_type='both' and Date='"+DateTime.Now+"' and day_of_time='"+dot.Text+"'", con);
            SqlDataReader dr2 = cmd.ExecuteReader();
            if (dr2.Read())
            {
                both.Text = dr2.GetValue(0).ToString(); //milk total print
                if (both.Text == "")
                {
                    both.Text = "0";
                }
            }
            else
            {
                both.Text = "0";
            }
            dr2.Close();
            cmd = new SqlCommand("Select SUM(liter) from DailyEntry where Date='" + DateTime.Now + "' and day_of_time='" + dot.Text + "'", con);
            SqlDataReader dr3 = cmd.ExecuteReader();
            if (dr3.Read())
            {
                tm.Text = dr3.GetValue(0).ToString(); //milk total print 
                if (tm.Text == "")
                {
                    tm.Text = "0";
                }
            }
            else
            {
                tm.Text = "0";
            }
            dr3.Close();
            cmd = new SqlCommand("Select SUM(amount) from DailyEntry where Date='" + DateTime.Now + "' and day_of_time='" + dot.Text + "'", con);
            SqlDataReader dr4 = cmd.ExecuteReader();
            if (dr4.Read())
            {
                ta.Text = dr4.GetValue(0).ToString(); //milk total print 
                if(ta.Text == "")
                {
                    ta.Text = "0";
                }
            }
            else
            {
                ta.Text = "0";
            }
            dr4.Close();
            //Object result1 = cmd.ExecuteScalar();
            /* if (result1 != DBNull.Value && result1 != null)
             {
                 label9.Text = Convert.ToDecimal(result1).ToString(); //milk total print 
             }
             else
             {
                 label9.Text = "0";
             }*/
        }
        public void getdata()
        {
            if (dot.Text != "")
            {

                date.Text = DateTime.Now.ToString();
                cmd = new SqlCommand("insert into store_data values('" + DateTime.Now + "','" + dot.Text + "','" + Convert.ToDouble(c.Text) + "','" + Convert.ToDouble(bm.Text) + "','" + Convert.ToDouble(both.Text) + "','" + Convert.ToDouble(tm.Text) + "','" + Convert.ToDouble(ta.Text) + "')", con);
                int a = cmd.ExecuteNonQuery();
                if (a>0)
                {
                    MessageBox.Show("Data Save Successfully", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("please select day of time", "data not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
        private void button1_Click(object sender, EventArgs e)
        {
            getdata();

        }
    }
}
