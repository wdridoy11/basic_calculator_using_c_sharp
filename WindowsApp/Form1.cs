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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void myNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Bangladesh!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int a, b, c;
            //a =Convert.ToInt16(firstInput.Text);
            //b =Convert.ToInt16(secoundInput.Text);
            //c = a * b;
            //sumOutpu.Text = c.ToString();
        }

        //sum
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int input1, input2, sum;
                if (!string.IsNullOrEmpty(inputField1.Text)) ;
                input1 = Convert.ToInt16(inputField1.Text);

                if (!string.IsNullOrEmpty(inputField2.Text)) ;
                input2 = Convert.ToInt16(inputField2.Text);

                sum = input1 + input2;
                output.Text = sum.ToString();
            }
            catch
            {
                MessageBox.Show("Please put any number");
            }
        }

        // sub
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int input1, input2, sub;
                if (!string.IsNullOrEmpty(inputField1.Text)) ;
                input1 = Convert.ToInt16(inputField1.Text);

                if (!string.IsNullOrEmpty(inputField2.Text)) ;
                input2 = Convert.ToInt16(inputField2.Text);

                sub = input1 - input2;
                output.Text = sub.ToString();
            }
            catch
            {
                MessageBox.Show("Please put any number");
            }
        }
        //multiplication
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int input1, input2, multiplication;
                if (!string.IsNullOrEmpty(inputField1.Text)) ;
                input1 = Convert.ToInt16(inputField1.Text);

                if (!string.IsNullOrEmpty(inputField2.Text)) ;
                input2 = Convert.ToInt16(inputField2.Text);

                multiplication = input1 * input2;
                output.Text = multiplication.ToString();
            }
            catch
            {
                MessageBox.Show("Please put any number");
            }
        }
        //division
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int input1, input2, division;
                if (!string.IsNullOrEmpty(inputField1.Text)) ;
                input1 = Convert.ToInt16(inputField1.Text);

                if (!string.IsNullOrEmpty(inputField2.Text)) ;
                input2 = Convert.ToInt16(inputField2.Text);

                division = input1 / input2;
                output.Text = division.ToString();
            }
            catch
            {
                MessageBox.Show("Please put any number");
            }
        }
    }
}
