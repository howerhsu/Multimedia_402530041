using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Boolean babala = false;
        Boolean pc = false;
        String temp="";
        String ch="";
        public Form1()
        {
            InitializeComponent();
        }

        public void calculate(String btText)//計算函式(+-*/)
        {
            if (babala == false || ch == "=")//沒有連續運算元或是前面是 =
            {
                if (ch == "")//代表前面沒有運算元或是剛算完=
                {
                    temp = txtbox.Text;
                    ch = btText;
                }
                else
                {
                    double a, b, c;
                    a = Double.Parse(temp);
                    b = Double.Parse(txtbox.Text);
                    switch (ch)
                    {
                        case "+":
                            c = a + b;
                            temp = c.ToString();
                            break;
                        case "-":
                            c = a - b;
                            temp = c.ToString();
                            break;
                        case "*":
                            c = a * b;
                            temp = c.ToString();
                            break;
                        case "/":
                            c = a / b;
                            temp = c.ToString();
                            break;
                        case "^":
                            c = 1;
                            for (int i = 0; i < b; i++)
                            {
                                c =c*a;
                            }
                            temp = c.ToString();
                            break;
                        case "√":
                            c = Math.Pow(a, 1 / b);
                            temp = c.ToString();
                            break;
                    }
                    txtbox.Text = temp;
                    ch = btText;
                }
                babala = true;
                pc = false;
            }
        }

        public void numberrule(String numText)//數字鍵法則(1~9)
        {
            if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += numText;
                babala = false;
            }
            else { txtbox.Text += numText; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt0_Click(object sender, EventArgs e)//按鍵0
        {
            if (txtbox.Text != "0")
            {

                if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
                {
                    txtbox.Text = "";
                    txtbox.Text += bt0.Text;
                    babala = false;
                }
                else { txtbox.Text += bt0.Text; }
            }

        }

        private void bt1_Click(object sender, EventArgs e)//按鍵1
        {
            numberrule(bt1.Text);
        }

        private void bt2_Click(object sender, EventArgs e)//按鍵2
        {
            numberrule(bt2.Text);
        }

        private void bt3_Click(object sender, EventArgs e)//按鍵3
        {
            numberrule(bt3.Text);
        }

        private void bt4_Click(object sender, EventArgs e)//按鍵4
        {
            numberrule(bt4.Text);
        }

        private void bt5_Click(object sender, EventArgs e)//按鍵5
        {
            numberrule(bt5.Text);
        }

        private void bt6_Click(object sender, EventArgs e)//按鍵6
        {
            numberrule(bt6.Text);
        }

        private void bt7_Click(object sender, EventArgs e)//按鍵7
        {
            numberrule(bt7.Text);
        }

        private void bt8_Click(object sender, EventArgs e)//按鍵8
        {
            numberrule(bt8.Text);
        }

        private void bt9_Click(object sender, EventArgs e)//按鍵9
        {
            numberrule(bt9.Text);
        }

        private void btClear_Click(object sender, EventArgs e)//清除鍵
        {
            txtbox.Text = "";
            temp = "";
            ch = "";
            pc = false;
            babala = false;
        }

        private void btPlus_Click(object sender, EventArgs e)//加法鍵
        {
            calculate(btPlus.Text);
        }

        private void btMinus_Click(object sender, EventArgs e)//減法鍵
        {
            calculate(btMinus.Text);     
        }

        private void btMulti_Click(object sender, EventArgs e)//乘法鍵
        {
            calculate(btMulti.Text);
        }

        private void btDiv_Click(object sender, EventArgs e)//除法鍵
        {
            calculate(btDiv.Text);
        }

        private void btAns_Click(object sender, EventArgs e)//等於鍵
        {
            if (babala == false)
            {
                if (ch == "")
                {
                return;
                 }
                else//前面有計算
                {
                double a, b, c;
                a = Double.Parse(temp);
                b = Double.Parse(txtbox.Text);
                    switch (ch)
                    {
                    case "+":
                        c = a + b;
                        temp = c.ToString();
                        break;
                    case "-":
                        c = a - b;
                        temp = c.ToString();
                        break;
                    case "*":
                        c = a * b;
                        temp = c.ToString();
                        break;
                    case "/":
                        c = a / b;
                        temp = c.ToString();
                        break;
                    case "^":
                        c = 1;
                        for (int i = 0; i < b; i++)
                        {
                            c = c * a;
                        }
                        temp = c.ToString();
                        break;
                        case "√":
                            c = Math.Pow(a, 1 / b);
                            temp = c.ToString();
                            break;
                    }
                txtbox.Text = temp;
                ch = "=";
                babala = true;
                pc = false;
                }
            }
            
        }

        private void btPoint_Click(object sender, EventArgs e)//小數點
        {
            if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += btPoint.Text;
                babala = false;
            }
            else
            {
                if (txtbox.Text != "")//前面要有數字才允許輸入
                {
                    if (pc == false)//尚未有小數點
                    {
                        txtbox.Text += btPoint.Text;
                        pc = true;
                    }
                }
                else
                {
                    txtbox.Text += "0.";
                    pc = true;
                }
             }


        }

        private void btSpr_Click(object sender, EventArgs e)//開根號鍵
        {
            calculate(btSpr.Text);
        }

        private void btBack_Click(object sender, EventArgs e)//退回鍵
        {
            if (txtbox.Text != "")
            {
                String newstr = txtbox.Text.Substring(0, txtbox.Text.Length - 1);//倒退
                txtbox.Text = newstr;
                if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
                {
                    temp = txtbox.Text;
                }
            }
        
        }

        private void btPow_Click(object sender, EventArgs e)//次方
        {
            calculate(btPow.Text);
        }
    }
}
