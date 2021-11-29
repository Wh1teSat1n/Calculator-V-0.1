using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int answer = 0;
        string SNumber = "";
        int number;
        delegate void Click(object sender, EventArgs e);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += button1.Text;
            SNumber += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += button2.Text;
            SNumber += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += button3.Text;
            SNumber += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += button4.Text;
            SNumber += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += button5.Text;
            SNumber += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += button6.Text;
            SNumber += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += button7.Text;
            SNumber += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += button8.Text;
            SNumber += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += button9.Text;
            SNumber += button9.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            answer = 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            answer += Convert.ToInt32(SNumber);
            SNumber = "";
            label1.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

            answer += Convert.ToInt32(SNumber);
            SNumber = "-";
            label1.Text += "-";
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            answer += Convert.ToInt32(SNumber);
            label1.Text = Convert.ToString(answer);
            SNumber = "";
        }
    }
}
