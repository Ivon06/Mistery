using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Reflection;

namespace mistery
{
    public partial class RokokoInfo : Form
    {
        private Rectangle label1OriginalRect;
        private Rectangle label2OriginalRect;
        private Rectangle label3OriginalRect;
        private Rectangle label5OriginalRect;
        private Rectangle label6OriginalRect;
        private Rectangle label7OriginalRect;
        private Rectangle label8OriginalRect;
        private Rectangle pictureBox1OriginalRect;
        private Rectangle pictureBox2OriginalRect;
        private Rectangle pictureBox3OriginalRect;
        private Rectangle pictureBox4OriginalRect;
        private Rectangle pictureBox5OriginalRect;
        private Rectangle pictureBox6OriginalRect;
        private Rectangle pictureBox7OriginalRect;
        private Rectangle pictureBox8OriginalRect;
        private Rectangle pictureBox10OriginalRect;

        private Rectangle button1OriginalRect;

        private Rectangle originalFormSize;
        private int count = 0;
        private void PlaySound(string uriPath)
        {

            Assembly assembly;
            SoundPlayer player;
            assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(uriPath);
            player = new SoundPlayer(stream);
            player.Play();
        }
        public RokokoInfo()
        {
            InitializeComponent();
        }

       

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            PlaySound("mistery.Resources.Рококо.wav");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rokoko F3 = new Rokoko();
            F3.Show();
            this.Hide();
        }

        private void RokokoInfo_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Size.Width, label1.Size.Height);
            label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Size.Width, label2.Size.Height);
            label3OriginalRect = new Rectangle(label3.Location.X, label3.Location.Y, label3.Size.Width, label3.Size.Height);
            label5OriginalRect = new Rectangle(label5.Location.X, label5.Location.Y, label5.Size.Width, label5.Size.Height);
            label6OriginalRect = new Rectangle(label6.Location.X, label6.Location.Y, label6.Size.Width, label6.Size.Height);
            label7OriginalRect = new Rectangle(label7.Location.X, label7.Location.Y, label7.Size.Width, label7.Size.Height);
            label8OriginalRect = new Rectangle(label8.Location.X, label8.Location.Y, label8.Size.Width, label8.Size.Height);

            pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
            pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width, pictureBox3.Size.Height);
            pictureBox4OriginalRect = new Rectangle(pictureBox4.Location.X, pictureBox4.Location.Y, pictureBox4.Size.Width, pictureBox4.Size.Height);
            pictureBox5OriginalRect = new Rectangle(pictureBox5.Location.X, pictureBox5.Location.Y, pictureBox5.Size.Width, pictureBox5.Size.Height);
            pictureBox6OriginalRect = new Rectangle(pictureBox6.Location.X, pictureBox6.Location.Y, pictureBox6.Size.Width, pictureBox6.Size.Height);
            pictureBox7OriginalRect = new Rectangle(pictureBox7.Location.X, pictureBox7.Location.Y, pictureBox7.Size.Width, pictureBox7.Size.Height);
            pictureBox8OriginalRect = new Rectangle(pictureBox8.Location.X, pictureBox8.Location.Y, pictureBox8.Size.Width, pictureBox8.Size.Height);
            pictureBox10OriginalRect = new Rectangle(pictureBox10.Location.X, pictureBox10.Location.Y, pictureBox10.Size.Width, pictureBox10.Size.Height);

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

        private void RokokoInfo_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ResizeControl(label1OriginalRect, label1);
                ResizeControl(label2OriginalRect, label2);
                ResizeControl(label3OriginalRect, label3);
                ResizeControl(label5OriginalRect, label5);
                ResizeControl(label6OriginalRect, label6);
                ResizeControl(label7OriginalRect, label7);
                ResizeControl(label8OriginalRect, label8);
                ResizeControl(pictureBox1OriginalRect, pictureBox1);
                ResizeControl(pictureBox2OriginalRect, pictureBox2);
                ResizeControl(pictureBox3OriginalRect, pictureBox3);
                ResizeControl(pictureBox4OriginalRect, pictureBox4);
                ResizeControl(pictureBox5OriginalRect, pictureBox5);
                ResizeControl(pictureBox6OriginalRect, pictureBox6);
                ResizeControl(pictureBox7OriginalRect, pictureBox7);
                ResizeControl(pictureBox8OriginalRect, pictureBox8);
                ResizeControl(pictureBox10OriginalRect, pictureBox10);

                ResizeControl(button1OriginalRect, button1);
                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Size.Width, label1.Size.Height);
                label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Size.Width, label2.Size.Height);
                label3OriginalRect = new Rectangle(label3.Location.X, label3.Location.Y, label3.Size.Width, label3.Size.Height);
                label5OriginalRect = new Rectangle(label5.Location.X, label5.Location.Y, label5.Size.Width, label5.Size.Height);
                label6OriginalRect = new Rectangle(label6.Location.X, label6.Location.Y, label6.Size.Width, label6.Size.Height);
                label7OriginalRect = new Rectangle(label7.Location.X, label7.Location.Y, label7.Size.Width, label7.Size.Height);
                label8OriginalRect = new Rectangle(label8.Location.X, label8.Location.Y , label8.Size.Width, label8.Size.Height);

                pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
                pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width, pictureBox3.Size.Height);
                pictureBox4OriginalRect = new Rectangle(pictureBox4.Location.X, pictureBox4.Location.Y, pictureBox4.Size.Width, pictureBox4.Size.Height);
                pictureBox5OriginalRect = new Rectangle(pictureBox5.Location.X, pictureBox5.Location.Y, pictureBox5.Size.Width, pictureBox5.Size.Height);
                pictureBox6OriginalRect = new Rectangle(pictureBox6.Location.X, pictureBox6.Location.Y, pictureBox6.Size.Width, pictureBox6.Size.Height);
                pictureBox7OriginalRect = new Rectangle(pictureBox7.Location.X, pictureBox7.Location.Y, pictureBox7.Size.Width, pictureBox7.Size.Height);
                pictureBox8OriginalRect = new Rectangle(pictureBox8.Location.X, pictureBox8.Location.Y, pictureBox8.Size.Width, pictureBox8.Size.Height);
                pictureBox10OriginalRect = new Rectangle(pictureBox10.Location.X, pictureBox10.Location.Y, pictureBox10.Size.Width, pictureBox10.Size.Height);

                button1OriginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Size.Width, button1.Size.Height);
                label1.Font = new Font("Georgia", 30, FontStyle.Regular);
                label2.Font = new Font("Georgia", 30, FontStyle.Regular);
                label3.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                label7.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                label5.Font = new Font("Cambria", 18, FontStyle.Regular);
                label6.Font = new Font("Cambria", 18, FontStyle.Regular);
                label8.Font = new Font("Cambria", 18, FontStyle.Regular);

            }
            else if (WindowState == FormWindowState.Normal && count != 0)
            {
                ResizeControl(label1OriginalRect, label1);
                ResizeControl(label2OriginalRect, label2);
                ResizeControl(label3OriginalRect, label3);
                ResizeControl(label5OriginalRect, label5);
                ResizeControl(label6OriginalRect, label6);
                ResizeControl(label7OriginalRect, label7);
                ResizeControl(label8OriginalRect, label8);
                ResizeControl(pictureBox1OriginalRect, pictureBox1);
                ResizeControl(pictureBox2OriginalRect, pictureBox2);
                ResizeControl(pictureBox3OriginalRect, pictureBox3);
                ResizeControl(pictureBox4OriginalRect, pictureBox4);
                ResizeControl(pictureBox5OriginalRect, pictureBox5);
                ResizeControl(pictureBox6OriginalRect, pictureBox6);
                ResizeControl(pictureBox7OriginalRect, pictureBox7);
                ResizeControl(pictureBox8OriginalRect, pictureBox8);
                ResizeControl(pictureBox10OriginalRect, pictureBox10);

                ResizeControl(button1OriginalRect, button1);
                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Size.Width, label1.Size.Height);
                label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Size.Width, label2.Size.Height);
                label3OriginalRect = new Rectangle(label3.Location.X, label3.Location.Y, label3.Size.Width, label3.Size.Height);
                label5OriginalRect = new Rectangle(label5.Location.X, label5.Location.Y, label5.Size.Width, label5.Size.Height);
                label6OriginalRect = new Rectangle(label6.Location.X, label6.Location.Y, label6.Size.Width, label6.Size.Height);
                label7OriginalRect = new Rectangle(label7.Location.X, label7.Location.Y, label7.Size.Width, label7.Size.Height);
                label8OriginalRect = new Rectangle(label8.Location.X, label8.Location.Y, label8.Size.Width, label8.Size.Height);

                pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
                pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width, pictureBox3.Size.Height);
                pictureBox4OriginalRect = new Rectangle(pictureBox4.Location.X, pictureBox4.Location.Y, pictureBox4.Size.Width, pictureBox4.Size.Height);
                pictureBox5OriginalRect = new Rectangle(pictureBox5.Location.X, pictureBox5.Location.Y, pictureBox5.Size.Width, pictureBox5.Size.Height);
                pictureBox6OriginalRect = new Rectangle(pictureBox6.Location.X, pictureBox6.Location.Y, pictureBox6.Size.Width, pictureBox6.Size.Height);
                pictureBox7OriginalRect = new Rectangle(pictureBox7.Location.X, pictureBox7.Location.Y, pictureBox7.Size.Width, pictureBox7.Size.Height);
                pictureBox8OriginalRect = new Rectangle(pictureBox8.Location.X, pictureBox8.Location.Y, pictureBox8.Size.Width, pictureBox8.Size.Height);
                pictureBox10OriginalRect = new Rectangle(pictureBox10.Location.X, pictureBox10.Location.Y, pictureBox10.Size.Width, pictureBox10.Size.Height);

                button1OriginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Size.Width, button1.Size.Height);
                label1.Font = new Font("Georgia", 20, FontStyle.Regular);
                label2.Font = new Font("Georgia", 15, FontStyle.Regular);
                label3.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                label7.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                label5.Font = new Font("Cambria", 12, FontStyle.Regular);
                label6.Font = new Font("Cambria", 12, FontStyle.Regular);
                label8.Font = new Font("Cambria", 12, FontStyle.Regular);
            }

            count++;
        }
    }
}
