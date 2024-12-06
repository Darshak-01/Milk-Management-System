using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mms
{
    public partial class Main : Form
    {
        SqlConnection con;
        SqlCommand cmd;
     
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
     
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

      

      
       

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditCustomer eo = new EditCustomer();
            eo.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Customer_add obj = new Customer_add();
            obj.Close();
            Customer_add obj1 = new Customer_add();
            obj1.Show();
        }

        

        private void sellProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellProduct sp1 = new SellProduct();
            sp1.Show();     
        }

        private void fatPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FatPrice fp1 = new FatPrice();
            fp1.Show();
        }

        private void cowMilkToolStripMenuItem_Click(object sender, EventArgs e)
        {
             ProdcutPrice pp1 = new ProdcutPrice();
             pp1.Show();
        }

        private void buffeloMilkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdcutPrice pp1 = new ProdcutPrice();
            pp1.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock sk1 = new Stock();
            sk1.Show();
        }

       

       

       

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
           //this event use to one time all form close click to main page close button
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {

      

            //date and time to save
            DateTime Date_and_time = DateTime.Now;
            //date
            Show_date.Text = Date_and_time.ToString("dd-MM-yyyy");
            timer1.Start();
            Show_time.Text = DateTime.Now.ToLongTimeString();
            con = new SqlConnection("Data Source=DESKTOP-5311C5J\\SQLEXPRESS;Initial Catalog=mms;Integrated Security=True");
            con.Open();
            getdata();
            comboBox1.Focus();
            Estimated();//function call

           //this code is use focus is day of time and all textbox are blur 
            if (comboBox1.SelectedIndex >= -1)
            {
                txtcode.Enabled = false;
                txtfat.Enabled = false;
                txtliter.Enabled = false;
            }
            else
            {
                txtcode.Enabled = true;
                txtfat.Enabled = true;
                txtliter.Enabled = true;
            }
        }
       //estimated number show function
        public void Estimated()
        {
            int c=0;
            int x=0;
            cmd = new SqlCommand("select count(*) from customer", con);
            SqlDataReader dr=cmd.ExecuteReader();
            if(dr.Read())
            {
                c =Convert.ToInt32(dr.GetValue(0).ToString());
                dr.Close();
            }
            dr.Close();
            cmd = new SqlCommand("select count(*) from DailyEntry  where Date='"+DateTime.Now+"' and day_of_time='"+comboBox1.Text+"'", con);
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                x= Convert.ToInt32(dr1.GetValue(0).ToString());
                dr1.Close();
            }
            dr1.Close();
            int temp = c - x;
            if(temp==-1)
            {
                temp = 0;
            }
            label6.Text=temp.ToString();
        }

        //time upadate
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            Show_time.Text = DateTime.Now.ToLongTimeString();
        }
       
        //submit btn code
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtcode.Text=="" || txtfat.Text=="" || txtliter.Text=="" ||comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Please Enter All Field","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = new SqlCommand("insert into DailyEntry values('" + txtcode.Text + "','" + c_name.Text + "','" + pt.Text + "','" + DateTime.Now + "','" + Show_time.Text + "','" + comboBox1.Text + "','" + Convert.ToDouble(txtliter.Text) + "','" + Convert.ToDouble(txtfat.Text) + "','" + Convert.ToDouble(ta.Text) + "')", con);
                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    
                    MessageBox.Show("Your Data Insert Successfulyy","Insert",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Payment();
                    txtcode.Text = "";
                    txtfat.Text = "";
                    txtliter.Text = "";
                    ta.Text = "0";
                    lp.Text = "0";
                    c_name.Text = "-";
                    txtcode.Focus();
                    getdata();
                    Estimated();
                }
                else
                {
                    MessageBox.Show("Your Data is Invalid PleaseCheck Data","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
            }
        }
        public void Payment()
        {
            int c_id = Convert.ToInt32(txtcode.Text);
            cmd = new SqlCommand("insert into temp values('" + c_id + "','" + Convert.ToDouble(ta.Text) + "')", con);

            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select sum(milk_money) from temp where coust_id='" + c_id + "'", con);
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                int sum = Convert.ToInt32(dr1.GetValue(0));
                dr1.Close();
                cmd = new SqlCommand("update pending_payment set p_payment='" + sum + "' where coust_id='" + c_id + "'", con);
                cmd.ExecuteNonQuery();
            }
        }

        //datagrid view ma data show mate
        public void getdata()
        {
            cmd = new SqlCommand("select code as 'Code',name as 'Name',product_type as 'Milk Type',Date as 'Date',time as 'Time',day_of_time as 'Day Of Time',liter as'Liter',fat as 'Fat',amount as 'Total' from DailyEntry where Date='"+ DateTime.Now +"' and day_of_time='"+comboBox1.Text+"'", con);
            SqlDataReader dr=cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
        }

        //textcode keypress event
        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 47 && e.KeyChar <= 57 || e.KeyChar == 8 )//47 to 57 are 0 to 9 num ascci value and 8 no is backspace 46 no is . ascii value
            {
                e.Handled = false;    
            }

            else
            {
                e.Handled = true;
            }
        }
    
        //day of time code
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getdata();
            Estimated();
            txtcode.Enabled = true;
            txtfat.Enabled = true;
            txtliter.Enabled = true;
            txtcode.Focus();

        }

       
        //variable declare
        Double fat;

        
        //fat code
        private void txtfat_Leave(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select fat_price from fat", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() && txtfat.Text != "")
            {
               fp.Text = dr.GetValue(0).ToString();

                fat = (Convert.ToDouble(txtfat.Text) * Convert.ToDouble(fp.Text));
                lp.Text = fat.ToString();
                dr.Close();
            }
            
               else
            {
                MessageBox.Show("Please Enter Fat");
                dr.Close();
            }
            
        }

        //liter code
        private void txtliter_Leave(object sender, EventArgs e)
        {
            if (txtliter.Text == "")
            {
                MessageBox.Show("Please Enter Liter");
            }
            else
            {
                ta.Text = (Convert.ToDouble(txtliter.Text) * fat).ToString();
            }
        }
        
        //id(customer no) code
        private void txtcode_Leave(object sender, EventArgs e)
        {
                cmd = new SqlCommand("select Name,typeofproduct from Customer where Code ='" + txtcode.Text + "'", con);
       
            SqlDataReader dr = cmd.ExecuteReader();//Object Of Select Query
                if (dr.Read())
                {
                    c_name.Text = dr.GetValue(0).ToString();
                    pt.Text = dr.GetValue(1).ToString();
                    pt.Hide();
                    txtfat.Focus();
                    dr.Close();
                    
                //Already Enter Record Second time dont't enter    
                    cmd = new SqlCommand("select * from DailyEntry where Date='" + DateTime.Now + "' and day_of_time='" + comboBox1.Text + "' and code='"+Convert.ToInt32(txtcode.Text)+"'", con);
                    SqlDataReader dr1=cmd.ExecuteReader();
                    if(dr1.Read())
                    {
                            MessageBox.Show("The Code Number Is Alredy Entry", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtcode.Clear();
                            txtcode.Focus();
                            dr1.Close();
                    }
                    dr1.Close();
                }
               
                else
                {
                   DialogResult r=MessageBox.Show("Do You Wont To Exit...!", "error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                   txtcode.Clear();
                if (DialogResult.Yes == r)
                {

                }
                else
                {
                    txtcode.Focus();
                }
                   dr.Close() ;
                }
                dr.Close();
            
        }

        //clear btn code
        private void button2_Click(object sender, EventArgs e)
        {
            txtcode.Text = "";
            txtfat.Text = "";
            txtliter.Text = "";
            ta.Text = "0";
            lp.Text = "0";
            c_name.Text = "-";
            txtcode.Focus();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Profile pro1 = new Profile();
            pro1.Show();
        }
         
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Change_Password cp1 = new Change_Password();
            cp1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void storeDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            store_data sd=new store_data();
            sd.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment payment_obj = new Payment();
            payment_obj.Show();
        }

        private void paymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment_History payment_History_obj=new Payment_History();
            payment_History_obj.Show();
        }

        private void pendingPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pending_payment pending_Payment_obj = new Pending_payment();
            pending_Payment_obj.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtfat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtliter_KeyPress(object sender, KeyPressEventArgs e)
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
