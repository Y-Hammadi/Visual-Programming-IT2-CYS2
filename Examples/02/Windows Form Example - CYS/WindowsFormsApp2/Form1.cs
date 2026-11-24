using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            
        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var TBT1 = textBox1.Text;
            var TBT2 = textBox2.Text;
            textBox2.Text = TBT1;
            textBox1.Text = TBT2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Pink)
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Pink;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = !textBox1.Visible;
            textBox2.Visible = !textBox2.Visible;
        }


    }
}
