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
    public partial class Customer_add : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public string constring = @"Data Source=DESKTOP-5311C5J\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True";
        string type;
        
        public Customer_add()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(radioButton1.Checked == true)
            {
                type = radioButton1.Text;
            }
           else if(radioButton2.Checked == true) 
            { 
               type=radioButton2.Text;
            }
           else
            {
                type = radioButton3.Text;
            }
            con = new SqlConnection(constring);
            con.Open();
            if (name.Text != "" && village.Text != "" && phoneno.Text != "" && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                if (phoneno.Text.Length == 10)
                {
                    string query = "insert into Customer values(@name,@village,@no,@type)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@village", village.Text);
                    cmd.Parameters.AddWithValue("@no", phoneno.Text);
                    cmd.Parameters.AddWithValue("@type", type);


                    int a = cmd.ExecuteNonQuery();
                    //this is return 1 and 0
                    if (a > 0)
                    {



                        Payment();
                        name.Text = "";
                        village.Text = "";
                        phoneno.Text = "";
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        name.Focus();

                        MessageBox.Show("Inserted successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                }
                else
                {
                    MessageBox.Show("please check phone no", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phoneno.Focus();

                }
            }
            else
            {
                MessageBox.Show("Please Inserte All Filed", "failur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        public void Payment()
        {
            int c_id = 0;
            cmd = new SqlCommand("select max(Code) from Customer", con);
            SqlDataReader dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                c_id = Convert.ToInt32(dr.GetValue(0).ToString());
            }
            dr.Close();
            cmd = new SqlCommand("insert into pending_payment values('"+c_id+"','"+name.Text+"','" + 0 + "')", con);
            cmd.ExecuteNonQuery();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void village_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Customer_add_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-5311C5J\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True");
            con.Open();
        }

        //only character and whitespace allow

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)&& !char.IsWhiteSpace(e.KeyChar))
            { 
             e.Handled = true;
            }
           
        }

        private void village_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 47 && e.KeyChar <= 57 || e.KeyChar == 8 )//47 to 57 are 0 to 9 num ascci value and 8 no is  backspace
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
