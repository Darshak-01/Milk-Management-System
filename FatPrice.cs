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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;

namespace mms
{
    public partial class FatPrice : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public FatPrice()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("update fat set Fat_price='" + textBox1.Text + "'", con);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Your Data Update SuccessFulyyy...!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox1.Focus();
                    //label ni value change karva
                    con = new SqlConnection("Data Source=DESKTOP-5311C5J\\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True");

                    cmd = new SqlCommand("select fat_price from fat ", con);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        oldprice.Text = dr.GetValue(0).ToString();
                        dr.Close();
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Inserte All Filed", "failur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }

        private void FatPrice_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-5311C5J\\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True");
            cmd = new SqlCommand("select fat_price from fat ",con);
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read()) 
            { 
                oldprice.Text = dr.GetValue(0).ToString();
                dr.Close();
            }
            con.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 47 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 46)//47 to 57 are 0 to 9 num ascci value and 8 no is backspace 46 no is . ascii value
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
    }
}
