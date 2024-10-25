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
    public partial class Renesance : Form
    {
        private Rectangle pictureBox1OriginalRect;
        private Rectangle pictureBox2OriginalRect;
        private Rectangle pictureBox3OriginalRect;
        private Rectangle groupBox1OriginalRect;
        private Rectangle label2OriginalRect;
        private Rectangle textBox1OriginalRect;
        private Rectangle button1OriginalRect;

        private Rectangle originalFormSize;
        private int count = 0;
        public Renesance()
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
            
            if (MainRoom.Type == true)
            {
                Labirynth lb = new Labirynth();
                lb.Show();
                this.Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            if (MainRoom.Type == true)
            {
                label2.Visible = true;
                button1.Visible = true;
                textBox1.Visible = true;
                groupBox1.Visible = true;
            }
            else
            {
                ReneInfo rn = new ReneInfo();
                rn.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;
            if (code == "Мона Лиза")
            {
                ReneInfo rnf = new ReneInfo();  
                rnf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Грешен отговор");
                textBox1.Text = "";
                button1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void Renesance_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width+20, pictureBox2.Size.Height+20);
            pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width+20, pictureBox3.Size.Height+20);
            groupBox1OriginalRect = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Size.Width, groupBox1.Size.Height);
            label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Size.Width, label2.Size.Height);
            textBox1OriginalRect = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Size.Width, textBox1.Size.Height);
            button1OriginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Size.Width, button1.Size.Height);
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

        private void Renesance_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ResizeControl(pictureBox1OriginalRect, pictureBox1);
                ResizeControl(pictureBox2OriginalRect, pictureBox2);
                ResizeControl(pictureBox3OriginalRect, pictureBox3);
                ResizeControl(groupBox1OriginalRect, groupBox1);
                ResizeControl(label2OriginalRect, label2);
                ResizeControl(textBox1OriginalRect, textBox1);
                ResizeControl(button1OriginalRect, button1);

                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
                pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width, pictureBox3.Size.Height);
                groupBox1OriginalRect = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Size.Width, groupBox1.Size.Height);
                label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Size.Width, label2.Size.Height);
                textBox1OriginalRect = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Size.Width, textBox1.Size.Height);
                button1OriginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Size.Width, button1.Size.Height);
                label2.Font = new Font("Cambria", 30, FontStyle.Bold);
                textBox1.Font = new Font("Cambria", 30, FontStyle.Regular);
            }
            else if (WindowState == FormWindowState.Normal && count != 0)
            {
                ResizeControl(pictureBox1OriginalRect, pictureBox1);
                ResizeControl(pictureBox2OriginalRect, pictureBox2);
                ResizeControl(pictureBox3OriginalRect, pictureBox3);
                ResizeControl(groupBox1OriginalRect, groupBox1);
                ResizeControl(label2OriginalRect, label2);
                ResizeControl(textBox1OriginalRect, textBox1);
                ResizeControl(button1OriginalRect, button1);

                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
                pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width, pictureBox3.Size.Height);
                groupBox1OriginalRect = new Rectangle(groupBox1.Location.X, groupBox1.Location.Y, groupBox1.Size.Width, groupBox1.Size.Height);
                label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Size.Width, label2.Size.Height);
                textBox1OriginalRect = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Size.Width, textBox1.Size.Height);
                button1OriginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Size.Width, button1.Size.Height);
                label2.Font = new Font("Cambria", 16, FontStyle.Bold);
            }

            count++;

        }
    }
}
