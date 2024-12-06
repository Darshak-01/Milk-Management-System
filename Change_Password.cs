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
    public partial class Change_Password : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public string constring = @"Data Source=DESKTOP-5311C5J\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True";

        public Change_Password()
        {
            InitializeComponent();
        }

   

        private void button1_Click_1(object sender, EventArgs e)
        {
            con = new SqlConnection(constring);
            con.Open();
            cmd = new SqlCommand("select Password from Login where Password='" + textBox1.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() )
            {
                if (textBox2.Text.Length <= 6 && textBox2.Text.Length >= 2 && textBox1.Text != "" && textBox2.Text != "")
                {
                    String s = "";
                    s = dr.GetValue(0).ToString();
                    dr.Close();
                    cmd = new SqlCommand("update Login set Password='" + textBox2.Text + "' where Password='" + s + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Change Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);//first is a message ,second ->  success is a message box hading & 3rd -> ok button declare & 4th -> ichon declare
                    textBox1.Text = "";
                    textBox2.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("please enter password min 2 charater or maximum 6 character", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
            }
            else
            {
                dr.Close();
                MessageBox.Show("incorect old Password ...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Clear();
                textBox1.Focus();
                dr.Close();
            }
            con.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
