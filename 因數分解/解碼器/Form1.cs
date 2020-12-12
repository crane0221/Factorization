using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 解碼器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 .Text == "")
            {
                richTextBox1.Text = "尚未輸入數值 !";
                return;
            }
            int num = Convert.ToInt32(textBox1.Text);            
            if (num < 2 || num > 1000000)
            {
                richTextBox1.Text = "請輸入大於1且小於等於1000000的數值";
                return;
            }
            int temp = num;           
            if (temp % 2 != 0 && temp < 10)
            {
                richTextBox1.Text = textBox1.Text;
            }
            if (num == 2)
            {
                richTextBox1.Text = textBox1 .Text;
            }
            if (num < 0)
            {
                richTextBox1.Text = "請輸入正整數 !";
            }            
            string str = "";
            for (int i = 2; i < num; i++)
            {                
                if (temp  % i == 0)
                {
                    temp = temp / i;
                    str = str + i.ToString() + "*";
                    i--;
                    richTextBox1.Text = str.Substring(0, str.Length - 1);
                }            
            }
        }
    }
}
