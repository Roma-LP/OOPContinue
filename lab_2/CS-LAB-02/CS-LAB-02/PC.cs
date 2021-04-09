using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_LAB_02
{
    public class PC
    {
        string TypePc;      // Ноутбук  Сервер   Рабочая станция
        string CPU;         // AMD Intel
        string GPU;         // Видеокрта
        int RAM;            // Оперативная память
        List<string> ROM;            // HDD  SSD
        DateTime DateOrder; // Дата заказа


        public PC(string typePc, string cPU, string gPU, int rAM, List<string> rOM, DateTime dateOrder)
        {
            TypePc = typePc;
            CPU = cPU;
            GPU = gPU;
            RAM = rAM;
            ROM = rOM;
            DateOrder = dateOrder;
        }

        public void MBShow()
        {
            // return TypePc + " " + CPU + " " + GPU + " " + RAM + " " + ROM.ForEach((x) => x.ToString()) + " " + DateOrder.ToShortDateString;
            System.Windows.Forms.MessageBox.Show($"{TypePc} {CPU} {GPU} {RAM} {ROM} {DateOrder.ToShortDateString()}");
        }

        public override string ToString()
        {
            return TypePc + "  " + CPU + "  " + GPU + "  " + RAM + "-GB  "+GetStrROM()+"  "+DateOrder.ToShortDateString();
        }

        private string GetStrROM()
        {
            string str ="" ;
            for(int i=0;i<ROM.Count;i++)
            {
                str = str + ROM[i]+" ";
            }
            return str;
        }
    }
}
