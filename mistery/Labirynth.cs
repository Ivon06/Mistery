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
    public partial class Labirynth : Form
    {
        public Labirynth()
        {
            InitializeComponent();
            Cursor.Position = new Point(87, 47);
        }

        
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Докоснахте стената. Започнете отначало.");
            Cursor.Position = new Point(87, 47);
        }

        private void pictureBox28_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно преминахте през лабиринта.");
            MessageBox.Show("Ключът за следващата стая е 'Караваджо'");
            Renesance rn = new Renesance();
            rn.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renesance rn = new Renesance();
            rn.Show();
            this.Hide();
        }

        private void Labirynth_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Докоснахте стената. Започнете отначало.");
            Cursor.Position = new Point(87, 47);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Докоснахте стената. Започнете отначало.");
            Cursor.Position = new Point(87, 47);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Докоснахте стената. Започнете отначало.");
            Cursor.Position = new Point(87, 47);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Докоснахте стената. Започнете отначало.");
            Cursor.Position = new Point(87,47);
        }

        private void pictureBox36_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Докоснахте стената. Започнете отначало.");
            Cursor.Position = new Point(87, 47);
        }
    }
}
