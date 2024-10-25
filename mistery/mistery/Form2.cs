using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mistery
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            textBox2.Visible = true;
            textBox1.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            label16.Visible = true;
            textBox5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string code = textBox5.Text;
            if (code == "ДаВинчи")
            {
                Form6 F6 = new Form6();
                F6.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Грешен код");
                textBox5.Text = "";
                button3.Visible = false;
                label16.Visible = false;
                textBox5.Visible = false;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            button4.Visible= true;
            label17.Visible= true;
            textBox6.Visible= true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string code = textBox6.Text;
            if (code == "Караваджо")
            {
                Form7 F7 = new Form7();
                F7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Грешен код");
                textBox6.Text = "";
                button4.Visible = false;
                textBox6.Visible = false;
                label17.Visible = false;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            label18.Visible = true;
            textBox7.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string code = textBox7.Text;
            if (code == "Вето")
            {
                Form3 F3 = new Form3();
                F3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Грешен код");
                textBox7.Text = "";
                button5.Visible = false;
                textBox7.Visible = false;
                label18.Visible = false;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            label19.Visible = true;
            textBox8.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string code = textBox8.Text;
            if (code == "Моне")
            {
                Form4 F4 = new Form4();
                F4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Грешен код");
                textBox8.Text = "";
                button6.Visible = false;
                textBox8.Visible = false;
                label19.Visible = false;
            }
        }
    }
}
