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

namespace CS_LAB_02
{
    public partial class Form1 : Form
    {
        List<PC> DataPC = new List<PC>();
        PC FormPC;
        public string NameFile;
        bool CanContinue = false;
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
                CanContinue = false;
            }
            else 
            {
                errorProvider_TypePC.Clear();
                CanContinue = true;
            }
        }
        private void UpDown_GPU_Validating(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UpDown_GPU.Text))
            {
                errorProvider_GPU.SetError(LB_GPU, "Не указана видеокарта!");
                CanContinue = false;
            }
            else
            {
                errorProvider_GPU.Clear();
                CanContinue = true;
            }
        }
        private void RadBut_Validating(object sender, EventArgs e)
        {
            if (!RadBut_CPU1.Checked)
            {
                if (!RadBut_CPU2.Checked)
                {
                    errorProvider_CPU.SetError(GroupLB_CPU, "Не указан процессор!");
                    CanContinue = false;
                }
            }
                errorProvider_CPU.Clear();
            CanContinue = true;
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
                            CanContinue = false;
                        }
                    }
                }
            }
            errorProvider_ROM.Clear();
            CanContinue = true;
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            if(!CanContinue)
            {
                MessageBox.Show("Заполните данные");
                return;
            }
            FormPC = new PC(ComboBox_TypePC.Text,
                GetRadioButton(), 
                UpDown_GPU.Text,
                TrackBarRAM.Value,
                GetCheckBox(),
                dateTimePicker1.Value);

            DataPC.Add(FormPC);

            Form2 SecondForm = new Form2(FormPC,this);
            SecondForm.Show();
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

        private void BT_Save_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void SaveToFile()
        {
            //Если равно true, то новые данные добавляются в конец файла
            //Если равно false, то файл перезаписываетсяя заново
            using (StreamWriter sw = new StreamWriter(NameFile+".txt", false, Encoding.UTF8))
            { 
                sw.WriteLine(OutData.Text);
            }
            MessageBox.Show("Файл сохранён");
        }

        private void BT_Load_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            OutData.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

       
    }
}
