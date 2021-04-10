using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace CS_LAB_02
{
    public partial class Form2 : Form
    {
        PC pc;
        User UserForm;
        Form1 MainForm;
        public Form2(PC pc,Form1 form)
        {
            this.pc = pc;
            this.MainForm = form;
            InitializeComponent();
        }

        private void BT_SecSave_Click(object sender, EventArgs e)
        {
            UserForm = new User(
                pc,
                TB_FirstName.Text,
                TB_SecName.Text,
                TB_MaskedNumber.Text,
                TB_NameFile.Text
                );

            MainForm.AddUsersInDataBase(UserForm);
            MainForm.OutData.Text += UserForm.ToString() + "\r\n";
            MessageBox.Show("Данные записаны");
            MainForm.NameFile = TB_NameFile.Text;
            MainForm.AddInListUser(UserForm);
            this.Close();
        }

        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X,e.Y);
        }
    }
}
