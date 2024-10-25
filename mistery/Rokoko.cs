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
    public partial class Rokoko : Form
    {
        private Rectangle pictureBox1OriginalRect;
        private Rectangle pictureBox2OriginalRect;
        private Rectangle pictureBox3OriginalRect;
        private Rectangle pictureBox4OriginalRect;
        private Rectangle groupBox1OriginalRect;
        private Rectangle label1OriginalRect;
        private Rectangle button1OriginalRect;
        private Rectangle button2OriginalRect;

        private Rectangle originalFormSize;
        private int count = 0;
        public Rokoko()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Map F2 = new Map();
            F2.Show();
            this.Hide();
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainRoom room = new MainRoom();
            if (MainRoom.Type == true)
            {
                this.Hide();
                NumberShuffle nsh = new NumberShuffle();
                nsh.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainRoom room = new MainRoom();
            if (MainRoom.Type == true)
            {
                groupBox1.Visible = true;
                label1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                RokokoInfo rk = new RokokoInfo();
                rk.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Грешен отговор!");
            groupBox1.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RokokoInfo rofo = new RokokoInfo();
            rofo.Show();
            this.Hide();
        }

        private void Rokoko_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width + 20, pictureBox2.Size.Height + 20);
            pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width + 20, pictureBox3.Size.Height + 20);
            pictureBox4OriginalRect = new Rectangle(pictureBox4.Location.X, pictureBox4.Location.Y, pictureBox4.Size.Width , pictureBox4.Size.Height);
            groupBox1OriginalRect = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Size.Width, groupBox1.Size.Height);
            label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Size.Width, label1.Size.Height);
            button1OriginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Size.Width, button1.Size.Height);
            button2OriginalRect = new Rectangle(button2.Location.X, button2.Location.Y, button2.Size.Width, button2.Size.Height);
            WindowState = FormWindowState.Maximized;
        }

        private void ResizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            float newX = (r.X * xRatio);
            float newY = (r.Y * yRatio);

            float newWidth = (r.Width * xRatio);
            float newHeight = (r.Height * yRatio);

            c.Location = new Point((int)newX, (int)newY);
            c.Size = new Size((int)newWidth, (int)newHeight);
        }

        private void Rokoko_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ResizeControl(pictureBox1OriginalRect, pictureBox1);
                ResizeControl(pictureBox2OriginalRect, pictureBox2);
                ResizeControl(pictureBox3OriginalRect, pictureBox3);
                ResizeControl(pictureBox4OriginalRect, pictureBox4);
                ResizeControl(groupBox1OriginalRect, groupBox1);
                ResizeControl(label1OriginalRect, label1);
                ResizeControl(button1OriginalRect, button1);
                ResizeControl(button2OriginalRect, button2);

                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
                pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width, pictureBox3.Size.Height);
                pictureBox4OriginalRect = new Rectangle(pictureBox4.Location.X, pictureBox4.Location.Y, pictureBox4.Size.Width, pictureBox4.Size.Height);
                groupBox1OriginalRect = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Size.Width, groupBox1.Size.Height);
                label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Size.Width, label1.Size.Height);
                button1OriginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Size.Width, button1.Size.Height);
                button2OriginalRect = new Rectangle(button2.Location.X, button2.Location.Y, button2.Size.Width, button2.Size.Height);
                label1.Font = new Font("Cambria", 24, FontStyle.Bold);

            }
            else if (WindowState == FormWindowState.Normal && count != 0)
            {
                ResizeControl(pictureBox1OriginalRect, pictureBox1);
                ResizeControl(pictureBox2OriginalRect, pictureBox2);
                ResizeControl(pictureBox3OriginalRect, pictureBox3);
                ResizeControl(pictureBox4OriginalRect, pictureBox4);
                ResizeControl(groupBox1OriginalRect, groupBox1);
                ResizeControl(label1OriginalRect, label1);
                ResizeControl(button1OriginalRect, button1);
                ResizeControl(button2OriginalRect, button2);

                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
                pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width, pictureBox3.Size.Height);
                pictureBox4OriginalRect = new Rectangle(pictureBox4.Location.X, pictureBox4.Location.Y, pictureBox4.Size.Width, pictureBox4.Size.Height);
                groupBox1OriginalRect = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Size.Width, groupBox1.Size.Height);
                label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Size.Width, label1.Size.Height);
                button1OriginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Size.Width, button1.Size.Height);
                button2OriginalRect = new Rectangle(button2.Location.X, button2.Location.Y, button2.Size.Width, button2.Size.Height);
                label1.Font = new Font("Cambria", 16, FontStyle.Bold);
            }

            count++;
        }
    }
}
