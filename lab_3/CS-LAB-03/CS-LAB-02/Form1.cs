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
using System.Text.Json;

namespace CS_LAB_02
{
    public partial class Form1 : Form
    {
        Users DataUser = new Users();
        PC FormPC;
        public string NameFile = "NoName";
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
            if (!CanContinue)
            {
                MessageBox.Show("Заполните данные");
                return;
            }
            FormPC = new PC(ComboBox_TypePC.Text,
                GetRadioButton(),
                UpDown_GPU.Text,
                TrackBarRAM.Value,
                GetCheckBox(),
                dateTimePicker1.Value.Date);

            // DataBase.Rows.Add(FormPC);
            Form2 SecondForm = new Form2(FormPC, this);
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
            CheckBox radioButton = (CheckBox)sender;

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
            string str = "";
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
            XmlSerializer formatter = new XmlSerializer(typeof(Users));
            using (FileStream fs = new FileStream("../../../" + NameFile + ".xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, DataUser);
            }

            //Если равно true, то новые данные добавляются в конец файла
            //Если равно false, то файл перезаписываетсяя заново
            using (StreamWriter sw = new StreamWriter("../../../" + NameFile + ".txt", false, Encoding.UTF8))
            {
                sw.WriteLine(OutData.Text);
            }
            MessageBox.Show("Файл сохранён");
        }

        private void SAveFileAs()
        {
            saveFileDialog_Form1.Filter = "Текстовые файлы (*.xml)|*.xml";
            if (saveFileDialog_Form1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog_Form1.FileName;

            XmlSerializer formatter = new XmlSerializer(typeof(Users));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, DataUser);
            }

            //Если равно true, то новые данные добавляются в конец файла
            //Если равно false, то файл перезаписываетсяя заново
            using (StreamWriter sw = new StreamWriter(filename.Remove(filename.Length - 3) + "txt", false, Encoding.UTF8))
            {
                sw.WriteLine(OutData.Text);
            }
            MessageBox.Show("Файл сохранён  как: " + filename);
        }

        private void BT_Load_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            openFileDialog1.Filter = "Текстовые файлы (*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // десериализация
            XmlSerializer formatter = new XmlSerializer(typeof(Users));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                AddInListUsers((Users)formatter.Deserialize(fs));
                AddUsersInDataBase();
                //MessageBox.Show("Объект десериализован");
            }
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename.Remove(filename.Length - 3) + "txt");
            OutData.Text += fileText.Remove(fileText.Length - 2);
            //MessageBox.Show("Файл открыт");
        }

        public void AddInListUser(User user)
        {
            DataUser.Add(user);
        }

        public void AddInListUsers(Users users)
        {
            DataUser.Add(users);
        }

        public void AddUsersInDataBase()
        {
            for (int i = 0; i < DataUser.UserList.Count; i++)
            {
                DataBase.Rows.Add(DataUser.UserList[i].Pc.TypePc,
                DataUser.UserList[i].Pc.CPU,
                DataUser.UserList[i].Pc.GPU,
                DataUser.UserList[i].Pc.RAM,
                DataUser.UserList[i].Pc.GetStrROM(),
                DataUser.UserList[i].Pc.DateOrder.ToShortDateString(),
                DataUser.UserList[i].FirstName,
                DataUser.UserList[i].SecName,
                DataUser.UserList[i].Number,
                DataUser.UserList[i].NameFile);
            }
        }
        public void AddUsersInDataBase(User user)
        {
            DataBase.Rows.Add(user.Pc.TypePc,
            user.Pc.CPU,
            user.Pc.GPU,
            user.Pc.RAM,
            user.Pc.GetStrROM(),
            user.Pc.DateOrder.ToShortDateString(),
            user.FirstName,
            user.SecName,
            user.Number,
            user.NameFile);
        }

        public void AddUsersInOutData()
        {
            for (int i = 0; i < DataUser.UserList.Count; i++)
            {
                OutData.Text += DataUser.UserList[i].ToString() + "\r\n";

            }
        }

        private void BT_Find_Click(object sender, EventArgs e)
        {
            FindForm Findform = new FindForm(DataUser);
            Findform.Show();
        }

        private void CloseForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAboutForm();
        }

        public void ShowAboutForm()
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_About_Click(object sender, EventArgs e)
        {
            ShowAboutForm();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SAveFileAs();
        }

        private void UpDateOutResult()
        {
            DataBase.Rows.Clear();
            AddUsersInDataBase();
            OutData.Text = "";
            AddUsersInOutData();
        }

        private void типКомпьютераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataUser.UserList = from i in DataUser.UserList
            //                    orderby i.Pc.TypePc
            //                    select i;
            //DataUser.UserList = (List<User>)DataUser.UserList.OrderBy(i => i.Pc.TypePc);
            DataUser.UserList = new List<User>(DataUser.UserList.OrderBy(i => i.Pc.TypePc));
            UpDateOutResult();
        }

        private void процессорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataUser.UserList = new List<User>(DataUser.UserList.OrderBy(i => i.Pc.CPU));
            UpDateOutResult();
        }

        private void видеокртаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataUser.UserList = new List<User>(DataUser.UserList.OrderBy(i => i.Pc.GPU));
            UpDateOutResult();
        }

        private void оЗУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataUser.UserList = new List<User>(DataUser.UserList.OrderBy(i => i.Pc.RAM));
            UpDateOutResult();
        }
        private void пЗУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var pr = DataUser.UserList.Pc.ROM.Sort;
            DataUser.UserList = new List<User>(DataUser.UserList.OrderBy(i => i.Pc.ROM));
            UpDateOutResult();
        }

        private void датаПокупкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataUser.UserList = new List<User>(DataUser.UserList.OrderBy(i => i.Pc.DateOrder));
            DataBase.Rows.Clear();
            AddUsersInDataBase();
            OutData.Text = "";
            AddUsersInOutData();
        }

        private void BT_DeleteRows_Click(object sender, EventArgs e)
        {
            DataUser.UserList.RemoveAt(DataBase.SelectedCells[0].RowIndex);
            //DataBase.Rows.RemoveAt(DataBase.SelectedCells[0].RowIndex);
            UpDateOutResult();
        }
    }
}
