using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        double val1, val2;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            display.Text += btn1.Text;
            val1 = double.Parse(display.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            display.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            display.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display.Text += btn0.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(display.Text);
            op = '+';
            display.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(display.Text);
            op = '-';    
            display.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(display.Text);
            op = '/';
            display.Text = "";
           
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(display.Text);
            op = '*';            
            display.Text = "";            
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(display.Text);

            if (op=='+')
            {             
               display.Text = (val1 + val2).ToString();                
            }
            else if (op == '-')
            {
                display.Text = (val1 - val2).ToString();

            }else if (op == '*')
            {
                display.Text = (val1 * val2).ToString();

            }else if (op == '/')
            {
                display.Text = (val1 / val2).ToString();
            }
        }
    }
}
