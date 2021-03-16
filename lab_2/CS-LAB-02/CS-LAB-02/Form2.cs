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
        public Form2(PC pc)
        {
            this.pc = pc;
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

            MessageBox.Show(UserForm.ToString());
            SaveToFile();



        }

        private void SaveToFile()
        {
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(User));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(TB_NameFile.Text+".xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, UserForm);
                Console.WriteLine("Объект сериализован");
            }
        }

    }
}
