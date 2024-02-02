using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //=== variable declared
        int number1, number2, result;
        string mathOperator;

        //=== When users click number key, saw this number in input field
        private void button9_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text + "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text + "8";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text + "7";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text + "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text + "0";
        }

        //=== All number clear from input field
        private void button20_Click(object sender, EventArgs e)
        {
            inputField.Clear();
        }


        //=== When user click math operator, they store value in number1 variable, and clear input field
        private void button18_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(inputField.Text);
            mathOperator = "+";
            inputField.Clear();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(inputField.Text);
            mathOperator = "-";
            inputField.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(inputField.Text);
            mathOperator = "*";
            inputField.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(inputField.Text);
            mathOperator = "/";
            inputField.Clear();
        }

        //=== All mathematics works
        private void button19_Click(object sender, EventArgs e)
        {
            number2 = int.Parse(inputField.Text);
            if (mathOperator == "+") 
            result = number1 + number2;

            else if (mathOperator == "-") 
            result = number1 - number2;

            else if (mathOperator == "*") 
            result = number1 * number2;

            else if (mathOperator == "/") 
            result = number1 / number2;

            inputField.Text = result.ToString();
        }

        
    }
}
