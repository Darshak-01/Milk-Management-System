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

namespace mms
{
    public partial class EditCustomer : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public EditCustomer()
        {
            InitializeComponent();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            con=new SqlConnection("Data Source=DESKTOP-5311C5J\\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True");
            con.Open();
            getdata();
            panel1.Hide();
        }
        public void getdata()
        {
            cmd = new SqlCommand("select * from customer", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt= new DataTable();  
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                DialogResult r=MessageBox.Show("Do You Want To Delete this Record","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(r==DialogResult.Yes)
                {
                    int code = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    cmd = new SqlCommand("delete from customer where code='" + code + "'", con);
                    cmd.ExecuteNonQuery();
                    getdata();
                }
            }

            if(e.ColumnIndex == 1)
            {
                panel1.Show();
                Code.Text=(dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                name.Text=dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                village.Text= dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                phoneno.Text= dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                String s = (dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                if(s=="Cow")
                {
                    radioButton1.Checked = true;
                }
                else if(s== "Buffalo")
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton3.Checked = true;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && village.Text != "" && phoneno.Text != "" && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))

            {

                if (phoneno.Text.Length == 10)
                {
                    cmd = new SqlCommand("update customer set Name='" + name.Text + "',Village='" + village.Text + "',PhoneNum='" + phoneno.Text + "',Typeofproduct='" + (radioButton1.Checked == true ? "Cow" : radioButton2.Checked == true ? "Buffalo" : "Both") + "'where code='" + Convert.ToInt32(Code.Text) + "'", con);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Your Data Update SuccessFulyyy...!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel1.Hide();
                        getdata();
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

        private void name_KeyPress(object sender, KeyPressEventArgs e) //only letter and whitespace allow
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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
            if (e.KeyChar >= 47 && e.KeyChar <= 57 || e.KeyChar == 8)//47 to 57 are 0 to 9 num ascci value and 8 no is  backspace
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
