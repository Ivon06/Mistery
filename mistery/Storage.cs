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
    public partial class Storage : Form
    {
        private Rectangle pictureBox1OriginalRect;
        private Rectangle pictureBox2OriginalRect;
        private Rectangle pictureBox3OriginalRect;
        private Rectangle originalFormSize;
        private int count = 0;
        public Storage()
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
            TicTacToe tct = new TicTacToe();
            tct.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RockScissorsPaper r = new RockScissorsPaper();
            r.Show();
            this.Hide();
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
            pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width, pictureBox3.Size.Height);
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

        private void Storage_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ResizeControl(pictureBox1OriginalRect, pictureBox1);
                ResizeControl(pictureBox2OriginalRect, pictureBox2);
                ResizeControl(pictureBox3OriginalRect, pictureBox3);

                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
                pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width, pictureBox3.Size.Height);
            }
            else if (WindowState == FormWindowState.Normal && count != 0)
            {
                ResizeControl(pictureBox1OriginalRect, pictureBox1);
                ResizeControl(pictureBox2OriginalRect, pictureBox2);
                ResizeControl(pictureBox3OriginalRect, pictureBox3);

                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
                pictureBox3OriginalRect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Size.Width, pictureBox3.Size.Height);

            }

            count++;

        }
    }
}
