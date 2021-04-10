using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LAB_02
{
    public partial class AboutForm : Form
    {
        
     

        public AboutForm()
        {
            InitializeComponent();
        }

        private void BT_OK4Form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_4Form_Tick(object sender, EventArgs e)
        {
            LabelTime_4Form.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }


        Point lastpoint;
        private void AboutForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void AboutForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
