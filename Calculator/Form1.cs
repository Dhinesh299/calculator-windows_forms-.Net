using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //sum textbox1
        string a;
        char [] b=new char[10000];
        long total=0, n1, n2=0,v=0,i=0;

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = 1;
            v = (v * 10) + n1;
            result.Text = v.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = 2;
            v = (v * 10) + n1;
            result.Text = v.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            n1 = 3;
            v = (v * 10) + n1;
            result.Text = v.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            n1 = 4;
            v = (v * 10) + n1;
            result.Text = v.ToString();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            n1 = 5;
            v = (v * 10) + n1;
            result.Text = v.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            n1 = 6;
            v = (v * 10) + n1;
            result.Text = v.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            n1 = 7;
            v = (v * 10) + n1;
            result.Text = v.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            n1 = 8;
            v = (v * 10) + n1;
            result.Text = v.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            n1 = 9;
            v = (v * 10) + n1;
            result.Text = v.ToString();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            n1 = 0;
            v = (v * 10) + n1;
            result.Text = v.ToString();
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(result.Text);
            total = total + n2;
            textBox1.Text = total.ToString();
            result.Clear();
            v = 0;
            a = "+";
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(result.Text);
            total = total - n2;
            textBox1.Text = total.ToString();
            result.Clear();
            v = 0;
            a = "-";
        }

        private void buttonmulti_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(result.Text);
            total = total * n2;
            textBox1.Text = total.ToString();
            result.Clear();
            v = 0;
            a = "*";
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(result.Text);
            total = total / n2;
            textBox1.Text = total.ToString();
            result.Clear();
            v = 0;
            a = "/";
        }

        private void buttoneql_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(result.Text);
            if (a.Equals("+"))
                total = total + n2;
            if (a.Equals("-"))
                total = total - n2;
            if (a.Equals("*"))
                total = total * n2;
            if (a.Equals("/"))
                total = total / n2;
            textBox1.Text = total.ToString();
            v = 0;
            a = "";
            result.Clear();
        }

        private void buttonclr_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            total = 0;
            v = 0;
            a = "";
        }

       
    }
}
