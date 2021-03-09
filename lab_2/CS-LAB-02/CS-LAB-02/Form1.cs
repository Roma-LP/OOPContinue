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
    public partial class Form1 : Form
    {
        List<PC> DataPC = new List<PC>();
        PC FormPC;
        public Form1()
        {
            InitializeComponent();
            //primer.Validating += primer_Validating;
            //primer.Click += primerefCliefeck;
            ComboBox_TypePC.Validated += ComboBox_TypePC_Validating;
            UpDown_GPU.Validated += UpDown_GPU_Validating;
            RadBut_CPU1.Validated += RadBut_Validating;
            RadBut_CPU2.Validated += RadBut_Validating;
            CheckBox_ROM1.Validated += CheckBox_RAM_Validating;
            CheckBox_ROM2.Validated += CheckBox_RAM_Validating;
            CheckBox_ROM3.Validated += CheckBox_RAM_Validating;
            CheckBox_ROM4.Validated += CheckBox_RAM_Validating;

            TrackBarRAM.ValueChanged += LB_SizeTotalRAM_UpDate;

        }

        private void LB_SizeTotalRAM_UpDate(object sender, EventArgs e)
        {
            LB_SizeTotalRAM.Text = TrackBarRAM.Value.ToString() + " GB";
        }

        private void ComboBox_TypePC_Validating(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ComboBox_TypePC.Text))
            {
                errorProvider_TypePC.SetError(LB_typePc, "Не указан тип компьютера!");
            }
            else 
            {
                errorProvider_TypePC.Clear();
            }
        }
        private void UpDown_GPU_Validating(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UpDown_GPU.Text))
            {
                errorProvider_GPU.SetError(LB_GPU, "Не указана видеокарта!");
            }
            else
            {
                errorProvider_GPU.Clear();
            }
        }
        private void RadBut_Validating(object sender, EventArgs e)
        {
            if (!RadBut_CPU1.Checked)
            {
                if (!RadBut_CPU2.Checked)
                {
                    errorProvider_CPU.SetError(GroupLB_CPU, "Не указан процессор!");
                    return;
                }
            }
                errorProvider_CPU.Clear();
        }
        private void CheckBox_RAM_Validating(object sender, EventArgs e)
        {
            if (!CheckBox_ROM1.Checked)
            {
                if (!CheckBox_ROM2.Checked)
                {
                    if (!CheckBox_ROM3.Checked)
                    {
                        if (!CheckBox_ROM4.Checked)
                        {
                            errorProvider_ROM.SetError(GroupLB_ROM, "Не указана память!");
                            return;
                        }
                    }
                }
            }
            errorProvider_ROM.Clear();
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            FormPC = new PC(ComboBox_TypePC.Text,
                GetRadioButton(), 
                UpDown_GPU.Text,
                TrackBarRAM.Value,
                GetCheckBox(),
                dateTimePicker1.Value);

            FormPC.MBShow();
            DataPC.Add(FormPC);
        }

        private void s(string str)
        {
            MessageBox.Show(str);
        }

        private void CheckBox_ROM1_CheckedChanged(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------------------
            // приводим отправителя к элементу типа RadioButton
            CheckBox radioButton =(CheckBox)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }
        private bool CheckCorrect()
        {
            //if (errorProvider_TypePC)
              
            return true;
        }

        private List<string> GetCheckBox()
        {
            List<string> str = new List<string>();
            foreach (Control item in GroupLB_ROM.Controls)
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

        private string GetRadioButton()
        {
           string str="";
            foreach (Control item in GroupLB_CPU.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)item;
                    if (radioButton.Checked)
                    {
                        str = radioButton.Text;
                    }
                }
            }
            return str;
        }

        public object GetDataPC()
        {
            return DataPC;
        }

        public PC GetFormPC()
        {
            return FormPC;
        }
    }
}
