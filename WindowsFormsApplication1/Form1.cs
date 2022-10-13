using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //var input1;
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (rad_0.Checked)
            {
             textBox1.Text = textBox1.Text + (int.Parse(num1.Text)).ToString();
            }
            else if (rad_1.Checked)
                textBox2.Text = textBox2.Text + (int.Parse(num1.Text)).ToString();
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (rad_0.Checked)
            {
                textBox1.Text = textBox1.Text + (int.Parse(num2.Text)).ToString();
            }
            else if (rad_1.Checked)
                textBox2.Text = textBox2.Text + (int.Parse(num2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rad_0.Checked)
            {
                textBox1.Text = textBox1.Text + (int.Parse(num1.Text)).ToString();
            }
            else if (rad_1.Checked)
                textBox2.Text = textBox2.Text + (int.Parse(num1.Text)).ToString();

        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (rad_0.Checked)
            {
                textBox1.Text = textBox1.Text + (int.Parse(num1.Text)).ToString();
            }
            else if (rad_1.Checked)
                textBox2.Text = textBox2.Text + (int.Parse(num1.Text)).ToString();
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (rad_0.Checked)
            {
                textBox1.Text = textBox1.Text + (int.Parse(num1.Text)).ToString();
            }
            else if (rad_1.Checked)
                textBox2.Text = textBox2.Text + (int.Parse(num1.Text)).ToString(); 
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (rad_0.Checked)
            {
                textBox1.Text = textBox1.Text + (int.Parse(num1.Text)).ToString();
            }
            else if (rad_1.Checked)
                textBox2.Text = textBox2.Text + (int.Parse(num1.Text)).ToString();
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (rad_0.Checked)
            {
                textBox1.Text = textBox1.Text + (int.Parse(num1.Text)).ToString();
            }
            else if (rad_1.Checked)
                textBox2.Text = textBox2.Text + (int.Parse(num1.Text)).ToString();
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (rad_0.Checked)
            {
             textBox1.Text = textBox1.Text + (int.Parse(num1.Text)).ToString();
            }
            else if (rad_1.Checked)
                textBox2.Text = textBox2.Text + (int.Parse(num1.Text)).ToString();
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (rad_0.Checked)
            {
             textBox1.Text = textBox1.Text + (int.Parse(num1.Text)).ToString();
            }
            else if (rad_1.Checked)
                textBox2.Text = textBox2.Text + (int.Parse(num1.Text)).ToString();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (rad_0.Checked)
            {
             textBox1.Text = textBox1.Text + (int.Parse(num1.Text)).ToString();
            }
            else if (rad_1.Checked)
                textBox2.Text = textBox2.Text + (int.Parse(num1.Text)).ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var input_0 = int.Parse(textBox1.Text);
            var input_1 = int.Parse(textBox2.Text);
            textBox3.Text = (input_0 + input_1).ToString();
        }

        private void Float_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + (Float.Text).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
