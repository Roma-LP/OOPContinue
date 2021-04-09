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
                TB_Name.Text,
                TB_SecName.Text,
                TB_MaskedNumber.Text,
                TB_NameFile.Text
                );


            MainForm.OutData.Text += OutData() + "\n";
            MessageBox.Show("Данные записаны");
            MainForm.NameFile = TB_NameFile.Text;
            this.Close();
        }

        

        private string OutData()
        {
            string str="";
            str = UserForm.ToString();
            return str;
            
        }
    }
}
