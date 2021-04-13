using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CS_LAB_02
{
    public partial class FindForm : Form
    {
        Users users;
        Users findUsers = new Users();
        public FindForm(Users users)
        {
            this.users = users;
            InitializeComponent();
        }

        private void BT_Find3Form_Click(object sender, EventArgs e)
        {
            ClearFindResult();

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
                            if (UpDown_RAM3Form.Text.Equals(users.UserList[i].Pc.RAM) || UpDown_RAM3Form.Text.Equals(""))
                            {
                                if (CheckCheckBoxRAM(i) || GetCheckBox().Count == 0)
                                {
                                    if (dateTimePicker1_3Form.Value.ToShortDateString().Equals(users.UserList[i].Pc.DateOrder.ToShortDateString()) || CheckBox_DateOff.Checked)
                                    {
                                        TB_Result.Text += users.UserList[i].ToString() + "\r\n";
                                        findUsers.Add(users.UserList[i]);
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

        private void CheckBox_DateOff_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_DateOff.Checked)
            {
                dateTimePicker1_3Form.Enabled = false;
            }
            else
            {
                dateTimePicker1_3Form.Enabled = true;

            }
        }

        private void BT_ClerAll_3Form_Click(object sender, EventArgs e)
        {
            ClearFindResult();
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    {
                        ClearTypePC();
                        ClearCPU();
                        ClearGPU();
                        ClearRAM();
                        ClearROM();
                        ClearData();
                        break;
                    }
                case 1:
                    {
                        RegexFinder();
                        break;
                    }
                default:
                    break;


            }
        }

        private void ClearFindResult()
        {
            TB_Result.Text = "";
        }
        private void ClearTypePC()
        {
            ComboBox_TypePC3Form.Text = "";
        }
        private void ClearCPU()
        {
            ComboBox_CPU3Form.Text = "";
        }
        private void ClearGPU()
        {
            UpDown_GPU3Form.Text = "";
        }
        private void ClearRAM()
        {
            UpDown_RAM3Form.Text = "";
        }
        private void ClearROM()
        {
            foreach (Control item in GroupLB_ROM3Form.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox radioButton = (CheckBox)item;
                    if (radioButton.Checked)
                    {
                        // MessageBox.Show(item.Name + " - " + radioButton.Text + " - " + item.Parent.Name);
                        radioButton.Checked = false;
                    }
                }
            }
        }
        private void ClearData()
        {
            CheckBox_DateOff.Checked = true;
        }

        private void BT_ClearTypePC_3Form_Click(object sender, EventArgs e)
        {
            ClearTypePC();
        }

        private void BT_ClearCPU_3Form_Click(object sender, EventArgs e)
        {
            ClearCPU();
        }

        private void BT_ClearGPU_3Form_Click(object sender, EventArgs e)
        {
            ClearGPU();
        }

        private void BT_ClearRAM_3Form_Click(object sender, EventArgs e)
        {
            ClearRAM();
        }

        private void BT_ClearROM_3Form_Click(object sender, EventArgs e)
        {
            ClearROM();
        }

        private void SaveFindForm_Click(object sender, EventArgs e)
        {
            if(TB_Result.Text.Equals(""))
            {
                MessageBox.Show("Нет результата!");
                return;
            }
            saveFileDialog_Form3.Filter = "Текстовые файлы (*.xml)|*.xml";
            if (saveFileDialog_Form3.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog_Form3.FileName;

            XmlSerializer formatter = new XmlSerializer(typeof(Users));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(fs, findUsers);
            }

            //Если равно true, то новые данные добавляются в конец файла
            //Если равно false, то файл перезаписываетсяя заново
            using (StreamWriter sw = new StreamWriter(filename.Remove(filename.Length - 3) + "txt", false, Encoding.UTF8))
            {
                sw.WriteLine(TB_Result.Text);
            }
            MessageBox.Show("Файл сохранён  как: " + filename);
        }
    }
}
