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
    public partial class FindForm : Form
    {
        Users users;
        public FindForm(Users users)
        {
            this.users = users;
            InitializeComponent();
        }

        private void BT_Find3Form_Click(object sender, EventArgs e)
        {
            TB_Result.Text = "";

            switch (TabControl.SelectedIndex)
            {
                case 0: { SimpleFinder(); break; }
                case 1: { RegexFinder(); break; }
                default:
                    break;
            }



        }

        private List<string> GetCheckBox()
        {
            List<string> str = new List<string>();
            foreach (Control item in GroupLB_ROM3Form.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox radioButton = (CheckBox)item;
                    if (radioButton.Checked)
                    {
                        // MessageBox.Show(item.Name + " - " + radioButton.Text + " - " + item.Parent.Name);
                        str.Add(radioButton.Text);
                    }
                }
            }
            return str;
        }

        private bool CheckCheckBoxRAM(short i)
        {
            List<string> checkstrRAM = GetCheckBox();
            return users.UserList[i].Pc.ROM.SequenceEqual(checkstrRAM);
        }

        private void SimpleFinder()
        {
            for (short i = 0; i < users.Count(); i++)
            {
                if (ComboBox_TypePC3Form.Text.Equals(users.UserList[i].Pc.TypePc) || ComboBox_TypePC3Form.Text.Equals(""))
                {
                    if (ComboBox_CPU3Form.Text.Equals(users.UserList[i].Pc.CPU) || ComboBox_CPU3Form.Text.Equals(""))
                    {
                        if (UpDown_GPU3Form.Text.Equals(users.UserList[i].Pc.GPU) || UpDown_GPU3Form.Text.Equals(""))
                        {
                            if (domainUpDown1.Text.Equals(users.UserList[i].Pc.RAM) || domainUpDown1.Text.Equals(""))
                            {
                                if (CheckCheckBoxRAM(i) || GetCheckBox().Count == 0)
                                {
                                    if (dateTimePicker1_3Form.Value.ToShortDateString().Equals(users.UserList[i].Pc.DateOrder.ToShortDateString()) || dateTimePicker1_3Form.Value.ToShortDateString().Equals(""))
                                    {
                                        TB_Result.Text += users.UserList[i].ToString() + "\r\n";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void RegexFinder()
        {
            MessageBox.Show("dfffdf");
        }

        private void CloseForm3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
