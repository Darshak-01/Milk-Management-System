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
    public partial class Profile : Form
    {
        //db connection object
        SqlConnection con;
        SqlCommand cmd;
        public string constring = @"Data Source=DESKTOP-5311C5J\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True";

        public Profile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(constring);
            con.Open();

            cmd = new SqlCommand("select Username from Login where Username='" + textBox1.Text + "'", con);
            SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    String s = "";
                    s = dr.GetValue(0).ToString();
                    dr.Close();
                    cmd = new SqlCommand("update Login set Username='" + textBox2.Text + "' where Username='" + s + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("UserName Change Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);//first is a message ,second ->  success is a message box hading & 3rd -> ok button declare & 4th -> ichon declare
                    textBox1.Text = "";
                    textBox2.Clear();
                    textBox1.Focus();
                }
                else 
                {
                    MessageBox.Show("please enter both field", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                dr.Close();
                 MessageBox.Show("incorect old username ...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Clear();
                textBox1.Focus();
                dr.Close() ;
            }
            con.Close();
        }

        private void Upanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
