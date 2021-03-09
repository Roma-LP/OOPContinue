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
    public partial class Form2 : Form
    {
        PC pc;
        public Form2(PC pc)
        {
            this.pc = pc;
            InitializeComponent();
        }

        private void BT_SecSave_Click(object sender, EventArgs e)
        {
            User UserForm = new User(
                pc,
                TB_Name.Text,
                TB_SecName.Text,
                TB_MaskedNumber.Text,
                TB_NameFile.Text
                );
        }
    }
}
