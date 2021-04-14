using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_LAB_02
{
    [Serializable]
    public class PC : IComparable<string>
    {
        public string TypePc;      // Ноутбук  Сервер   Рабочая станция
        public string CPU;         // AMD Intel
        public string GPU;         // Видеокрта
        public int RAM;            // Оперативная память
        public List<string> ROM;            // HDD  SSD
        public DateTime DateOrder; // Дата заказа

        public PC() { }
        public PC(string typePc, string cpu, string gPU, int rAM, List<string> rOM, DateTime dateOrder)
        {
            TypePc = typePc;
            CPU = cpu;
            GPU = gPU;
            RAM = rAM;
            ROM = rOM;
            DateOrder = dateOrder;
        }

        //public string TypePc { get { return typePc; } }
        //public string CPU { get { return cpu; } }
        //public string GPU { get => gpu; }
        //public int RAM { get => ram; }
        //public List<string> ROM { get => rom; }
        //public DateTime DateOrder { get => dateorder; }

        public void MBShow()
        {
            // return TypePc + " " + CPU + " " + GPU + " " + RAM + " " + ROM.ForEach((x) => x.ToString()) + " " + DateOrder.ToShortDateString;
            System.Windows.Forms.MessageBox.Show($"{TypePc} {CPU} {GPU} {RAM} {ROM} {DateOrder.ToShortDateString()}");
        }

        public override string ToString()
        {
            return TypePc + "  " + CPU + "  " + GPU + "  " + RAM + "-GB  " + GetStrROM() + "  " + DateOrder.ToShortDateString();
        }

        public string GetStrROM()
        {
            string str = "";
            for (int i = 0; i < ROM.Count; i++)
            {
                str = str + ROM[i] + " ";
            }
            return str;
        }

        public int CompareTo(string obj)
        {
            //PC p = obj as PC;
            //if (p != null)
            //{
            //    if (p.ROM.Count < this.ROM.Count)
            //        return 1;
            //    else
            //        if (p.ROM.Count > this.ROM.Count)
            //        return -1;
            //    else
            //        return 0;

            //}
            //else
            //    throw new Exception("Невозможно сравнить два объекта");
            if (this.GetStrROM().Length > obj.Length)
                return 1;
            if (this.GetStrROM().Length < obj.Length)
                return -1;
            else
                return 0;
        }
    }
}
