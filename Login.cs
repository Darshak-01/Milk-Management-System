using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//db connection mate
using System.Data.SqlClient;

namespace mms
{
    public partial class Login : Form
    {

        //db connection object
        SqlConnection con;
        SqlCommand cmd;

        public Login()
        {
            InitializeComponent();
        }
        public string constring = @"Data Source=DESKTOP-5311C5J\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True";
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Enter UserName";
            textBox2.Text = "Enter Password";
            textBox1.ForeColor = Color.LightGray;
            textBox2.ForeColor = Color.LightGray;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter UserName")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter UserName";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {

                textBox2.Text = "Enter Password";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

            if (textBox2.Text == "Enter Password")
            {

                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked; //checked method check hase to true thase ane check ny hoy to false thase
            switch (check)
            {
                case true: //chcek karel hoy to password batavse
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            con = new SqlConnection(constring);
            con.Open();

            cmd = new SqlCommand("select * from Login where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'",con);
            SqlDataReader dr = cmd.ExecuteReader();//data read mate
            if (dr.Read())//dr.HasRows == true
            {
                SplashForm sp = new SplashForm();
                sp.Show();
                this.Hide();
                dr.Close();
                //MessageBox.Show("login succesfully ...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);//first is a message ,second ->  success is a message box hading & 3rd -> ok button declare & 4th -> ichon declare
            }
            else
            {
                MessageBox.Show("incorect username or password...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Clear();
                textBox1.Focus();
            }
            con.Close();
        }
    }
}
