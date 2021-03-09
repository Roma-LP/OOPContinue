using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LAB_01
{
    public partial class Form1 : Form
    {
        double sum = 0;
        double memor = 0;
        byte leftscobs = 0;
        byte rigthscobs = 0;
        private Stack<char> operation = new Stack<char>();
        private List<string> resPN = new List<string>();
        private Stack<double> numb = new Stack<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_clr_Click(object sender, EventArgs e)
        {
            text.Clear();
            resPN.Clear();
            sum = 0;
        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_num7_Click(object sender, EventArgs e)
        {
            WriteText('7');
        }

        private void bt_num8_Click(object sender, EventArgs e)
        {
            WriteText('8');
        }

        private void bt_num9_Click(object sender, EventArgs e)
        {
            WriteText('9');
        }

        private void bt_num4_Click(object sender, EventArgs e)
        {
            WriteText('4');
        }

        private void bt_num5_Click(object sender, EventArgs e)
        {
            WriteText('5');
        }

        private void bt_num6_Click(object sender, EventArgs e)
        {
            WriteText('6');
        }

        private void bt_num1_Click(object sender, EventArgs e)
        {
            WriteText('1');
        }

        private void bt_num2_Click(object sender, EventArgs e)
        {
            WriteText('2');
        }

        private void bt_num3_Click(object sender, EventArgs e)
        {
            WriteText('3');
        }

        private void bt_num0_Click(object sender, EventArgs e)
        {
            WriteText('0');
        }

        private void bt_point_Click(object sender, EventArgs e)
        {
            if (Program.IsOperation(text.Text.Last()) && !(text.Text.Last().Equals(')') && !(text.Text.Last().Equals(','))))
            {
                ReplaceLastOperation(',');
            }
            else
            {
                WriteText(',');
            }
        }
        private void bt_plus_Click(object sender, EventArgs e)
        {
            if (Program.IsOperation(text.Text.Last()) && !(text.Text.Last().Equals(')')))
            {
                ReplaceLastOperation('+');
            }
            else
            {
                WriteText('+');
            }
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            if (Program.IsOperation(text.Text.Last()) && !(text.Text.Last().Equals(')')))
            {
                ReplaceLastOperation('-');
            }
            else
            {
                WriteText('-');
            }
        }

        private void bt_umn_Click(object sender, EventArgs e)
        {
            if (Program.IsOperation(text.Text.Last()) && !(text.Text.Last().Equals(')')))
            {
                ReplaceLastOperation('*');
            }
            else
            {
                WriteText('*');
            }
        }

        private void bt_delit_Click(object sender, EventArgs e)
        {
            if (Program.IsOperation(text.Text.Last()) && !(text.Text.Last().Equals(')')))
            {
                ReplaceLastOperation('/');
            }
            else
            {
                WriteText('/');
            }
        }

        private void bt_lscob_Click(object sender, EventArgs e)
        {
            if (Program.IsNumber(text.Text.Last()))
            {
                WriteText('*');
            }
            WriteText('(');
            leftscobs++;
        }

        private void bt_rscob_Click(object sender, EventArgs e)
        {
            if (leftscobs > rigthscobs)
            {
                WriteText(')');
                rigthscobs++;
            }

        }
        private void bt_del_Click(object sender, EventArgs e)
        {
            if (text.Text.Length != 0)
            {
                text.Text = text.Text.Remove(text.Text.Length - 1, 1);
            }
        }

        private void bt_rovn_Click(object sender, EventArgs e)
        {
            CheckScobs();
            ConvertPolishNat();
            CalculateResult();
            text.Text = sum.ToString();
        }

        private void ReplaceLastOperation(char ch)
        {
            text.Text = text.Text.Remove(text.Text.Length - 1, 1);
            text.Text = text.Text + ch;
        }

        private void WriteText(char ch)
        {
            text.Text = text.Text + ch;
        }

        private void ConvertPolishNat()
        {
            if (!(Program.IsOperation(text.Text.Last()) && !(text.Text.Last().Equals(')'))))
            {
                for (int i = 0; i < text.Text.Length; i++)
                {

                    if (Program.IsOperation(text.Text[i]))
                    {
                        if (operation.Count == 0)
                        {
                            operation.Push(text.Text[i]); // если стек пуст, кладем отперацию в стек
                        }
                        else
                        {
                            if (text.Text[i].Equals('(')) // добавляем скобку всегда в стек
                            {
                                operation.Push(text.Text[i]);
                            }
                            else
                            {
                                if (text.Text[i].Equals(')'))
                                {
                                    while (!operation.Peek().Equals('('))
                                    { // выталкивем всё, пока не встретим '('
                                        resPN.Add(operation.Pop().ToString());

                                    }
                                    operation.Pop(); // удаляем скобку '('
                                }
                                else
                                {
                                    // если приоритет текущей операции выше, чем в стеке, кладем в стек
                                    if (Priority(text.Text[i]) > Priority(operation.Peek()))
                                    {
                                        operation.Push(text.Text[i]);
                                        
                                    }
                                    else
                                    {
                                        // если приоритет текущей операции равен меньше чем в стеке, выталкиваем знак из стека в результат,
                                        // а текущий добавляем в стек.
                                        if (Priority(text.Text[i]) <= Priority(operation.Peek()))
                                        {
                                            resPN.Add(operation.Pop().ToString());
                                            operation.Push(text.Text[i]);


                                        }
                                    }
                                }
                            }
                        }
                    }
                    else // если число
                    {
                        if (i != 0)
                        {
                            if (!Program.IsOperation(text.Text[i - 1]))
                            {
                                if (resPN.Count() != 0)
                                {
                                    resPN[resPN.Count - 1] = resPN[resPN.Count - 1] + text.Text[i];
                                }
                                else
                                {
                                    resPN[0] = resPN[0] + text.Text[i];
                                }
                            }
                            else
                            {
                                resPN.Add(text.Text[i].ToString());
                            }
                        }
                        else
                        {
                                resPN.Add(text.Text[i].ToString());
                        }
                    }
                }
                while (operation.Count != 0)
                {
                    resPN.Add(operation.Pop().ToString()); // выгружаем всё что осталось в стеке в результат
                }
            }
            else
            {
                MessageBox.Show("Допишите условие");
            }
        }
        private int Priority(char ch)
        {
            if (ch == '(' || ch == ')')
            {
                return 0;
            }
            if (ch == '+' || ch == '-')
            {
                return 1;
            }
            if (ch == '*' || ch == '/')
            {
                return 2;
            }
            return -1;
        }

        private void CheckScobs()
        {
            while (leftscobs < rigthscobs)
            {
                WriteText(')');
            }
        }

        private void CalculateResult()
        {
            for (int i = 0; i < resPN.Count; i++)
            {
                if (Program.IsOperation(resPN[i]))
                {
                    numb.Push(DoOperation(numb.Pop(), numb.Pop(), resPN[i]));
                }
                else
                {
                    numb.Push(Convert.ToDouble(resPN[i]));
                }

            }
            sum=numb.Pop();
        }

        private double DoOperation(double x,double y, string operation)
        {
            switch (operation)
            {
                case "-":
                    {
                        return y - x;
                    }
                case "+":
                    {
                        return y + x;
                    }
                case "*":
                    {
                        return y * x;
                    }
                case "/":
                    {
                        return y / x;
                    }
                case "%":
                    {
                        return y % x;
                    }
                default:
                    return 0;
            }
        }

        private void bt_toMemorry_Click(object sender, EventArgs e)
        {
            memor = sum;
        }

        private void bt_fromMemmory_Click(object sender, EventArgs e)
        {
            if (memor != 0)
            {
                text.Text = text.Text + memor;
            }
        }
    }
}
