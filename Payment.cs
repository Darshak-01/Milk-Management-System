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
    public partial class Payment : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-5311C5J\\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True");
            con.Open();
            DateTime dates = DateTime.Now;
            date.Text = dates.ToString("dd-MM-yyyy");

        }

        private void can_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            if(txt_id.Text=="")
            {
                MessageBox.Show("Plz Enter Valid Coustmer Id","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
            else
            {
                cmd = new SqlCommand("select Name from Customer where Code='" + Convert.ToInt32(txt_id.Text) + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    cnm.Text = dr.GetValue(0).ToString();
                }
                else
                {
                  
                    MessageBox.Show("Plz Enter Valid Coustmer Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_id.Clear();
                    txt_id.Focus();
                }
                dr.Close();
                cmd = new SqlCommand("select sum(milk_money) from temp where coust_id='" + Convert.ToInt32(txt_id.Text) + "'", con);
                SqlDataReader dr2 = cmd.ExecuteReader();
                if(dr2.Read())
                {
                    tp.Text = dr2.GetValue(0).ToString();
                }
                else
                {
                    MessageBox.Show("Plz Enter Valid Coustmer Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_id.Clear();
                    txt_id.Focus();
                }
                dr2.Close();
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if(txt_id.Text=="")
            {
                MessageBox.Show("Plz Enter Valid Coustmer Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Clear();
                txt_id.Focus();
            }
            else
            {
                if(tp.Text=="")
                {
                    MessageBox.Show("payment are already given","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_id.Clear();
                }
                else
                {
                cmd = new SqlCommand("insert into giving_payment values('" + Convert.ToInt32(txt_id.Text) + "','" + cnm.Text + "','" + date.Text + "','" + Convert.ToDouble(tp.Text) + "')", con);
                int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        delete_data();
                        txt_id.Clear();
                        tp.Text = "";
                        cnm.Text = "";
                        MessageBox.Show("Payment Giving Suceessfulyyy", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
        }
        public void delete_data()
        {
            cmd = new SqlCommand("delete from temp where coust_id='" + Convert.ToInt32(txt_id.Text) + "'", con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("update pending_payment set p_payment=0 where coust_id='" + Convert.ToInt32(txt_id.Text) + "'", con);
            cmd.ExecuteNonQuery();
        }
    }
}
