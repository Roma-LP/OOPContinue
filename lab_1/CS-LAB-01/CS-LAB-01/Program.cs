using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LAB_01
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       public static bool IsOperation(char ch)
        {
            char[] oper = { '/', '*', '-', '+', '%','(',')'};
            for(int i=0;i<oper.Length;i++)
            {
                if(ch.Equals(oper[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsOperation(string ch)
        {
            if (IsOperation(ch[0]))
                return true;
            else
                return false;
        }

        public static bool IsNumber(char ch)
        {
            char[] numb = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < numb.Length; i++)
            {
                if (ch.Equals(numb[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
