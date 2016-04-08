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
        String temp="";
        String ch="";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt0_Click(object sender, EventArgs e)//按鍵0
        {
            if(babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += bt0.Text;
                babala = false;
            }
            else
            {
                if (txtbox.Text != "")//前面要有數字才允許輸入
                txtbox.Text += bt0.Text;
            }

        }

        private void bt1_Click(object sender, EventArgs e)//按鍵1
        {
            if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += bt1.Text;
                babala = false;
            }
            else { txtbox.Text += bt1.Text; }
        }

        private void bt2_Click(object sender, EventArgs e)//按鍵2
        {
            if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += bt2.Text;
                babala = false;
            }
            else { txtbox.Text += bt2.Text; }
        }

        private void bt3_Click(object sender, EventArgs e)//按鍵3
        {
            if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += bt3.Text;
                babala = false;
            }
            else { txtbox.Text += bt3.Text; }
        }

        private void bt4_Click(object sender, EventArgs e)//按鍵4
        {
            if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += bt4.Text;
                babala = false;
            }
            else { txtbox.Text += bt4.Text; }
        }

        private void bt5_Click(object sender, EventArgs e)//按鍵5
        {
            if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += bt5.Text;
                babala = false;
            }
            else { txtbox.Text += bt5.Text; }
        }

        private void bt6_Click(object sender, EventArgs e)//按鍵6
        {
            if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += bt6.Text;
                babala = false;
            }
            else { txtbox.Text += bt6.Text; }
        }

        private void bt7_Click(object sender, EventArgs e)//按鍵7
        {
            if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += bt7.Text;
                babala = false;
            }
            else { txtbox.Text += bt7.Text; }
        }

        private void bt8_Click(object sender, EventArgs e)//按鍵8
        {
            if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += bt8.Text;
                babala = false;
            }
            else { txtbox.Text += bt8.Text; }
        }

        private void bt9_Click(object sender, EventArgs e)//按鍵9
        {
            if (babala == true)//代表目前顯示的是上一次計算剩下來的答案
            {
                txtbox.Text = "";
                txtbox.Text += bt9.Text;
                babala = false;
            }
            else { txtbox.Text += bt9.Text; }
        }

        private void btClear_Click(object sender, EventArgs e)//清除鍵
        {
            txtbox.Text = "";
            temp = "";
            ch = "";
        }

        private void btPlus_Click(object sender, EventArgs e)//加法鍵
        {

            if (babala == false || ch == "=")//沒有連續運算元或是前面是 =
            {
                if (ch=="")//代表前面沒有運算元或是剛算完=
                {
                temp = txtbox.Text;
                ch = btPlus.Text;
                }
                else
                {
                double a, b,c;
                a=Double.Parse(temp);
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
                    }
                txtbox.Text = temp;
                ch = btPlus.Text;
                }
                babala = true;
            }
         
        }

        private void btMinus_Click(object sender, EventArgs e)//減法鍵
        {
            if (babala == false || ch == "=")//沒有連續運算元或是前面是 =
            {
                if (ch == "")
                {
                temp = txtbox.Text;
                ch = btMinus.Text;
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
                    }
                txtbox.Text = temp;
                ch = btMinus.Text;
                }
                babala = true;
            }
                
           
        }

        private void btMulti_Click(object sender, EventArgs e)//乘法鍵
        {
            if (babala == false || ch == "=")//沒有連續運算元或是前面是 =
            {
                if (ch == "")//代表前面沒有運算元或是剛算完=
                {
                    temp = txtbox.Text;
                    ch = btMulti.Text;
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
                    }
                    txtbox.Text = temp;
                    ch = btMulti.Text;
                }
                babala = true;
            }
        }

        private void btDiv_Click(object sender, EventArgs e)//除法鍵
        {
            if (babala == false || ch == "=")
            {
                if (ch == "")
                {
                temp = txtbox.Text;
                ch = btDiv.Text;
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
                    }
                txtbox.Text = temp;
                ch = btDiv.Text;
                }
            babala = true;
            }
            
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
                     }
                txtbox.Text = temp;
                ch = "=";
                babala = true;
                }
            }
            
        }
    }
}
