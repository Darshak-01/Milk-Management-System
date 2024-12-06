using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mms
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel2.Width >= panel1.Width)
            {
                Login obj = new Login();
                obj.Close();

                timer1.Stop();
                

                Main a = new Main();
                 a.Show();
                this.Close();

                // add a = new add();
                // a.Show();
            }
            else
            {
                Login obj = new Login();
                obj.Close();

                panel2.Width += 3;
                


            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
