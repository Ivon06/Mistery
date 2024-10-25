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
    public partial class MainRoom : Form
    {
        private Rectangle pictureBox1OriginalRect;
        private Rectangle pictureBox2OriginalRect;
        private Rectangle label1OriginalRect;
        private Rectangle playOriginalRect;
        private Rectangle notPlayOriginalRect;
        private Rectangle originalFormSize;
        private int count = 0;
        private static bool type;
        public static bool Type
        {
            get { return type; }
             
        }
        
        public MainRoom()
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
            if (Type == true)
            {
                ConnectingGame game = new ConnectingGame();
                game.Show();
                this.Hide();
            }
        }

        private void MainRoom_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
            label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Size.Width, label1.Size.Height);
            playOriginalRect = new Rectangle(play.Location.X, play.Location.Y, play.Size.Width, play.Size.Height);
            notPlayOriginalRect = new Rectangle(notPlay.Location.X, notPlay.Location.Y, notPlay.Size.Width, notPlay.Size.Height);
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

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void MainRoom_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ResizeControl(pictureBox1OriginalRect, pictureBox1);
                ResizeControl(pictureBox2OriginalRect, pictureBox2);
                ResizeControl(label1OriginalRect, label1);
                ResizeControl(playOriginalRect, play);
                ResizeControl(notPlayOriginalRect, notPlay);

                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
                label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Size.Width, label1.Size.Height);
                playOriginalRect = new Rectangle(play.Location.X, play.Location.Y, play.Size.Width, play.Size.Height);
                notPlayOriginalRect = new Rectangle(notPlay.Location.X, notPlay.Location.Y, notPlay.Size.Width, notPlay.Size.Height);
                label1.Font = new Font("Monotype Corsiva", 80, FontStyle.Regular);
                play.Font = new Font("Microsoft Sans Serif",30, FontStyle.Regular);
                notPlay.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Regular);
            }
            else if (WindowState == FormWindowState.Normal && count != 0)
            {
                ResizeControl(pictureBox1OriginalRect, pictureBox1);
                ResizeControl(pictureBox2OriginalRect, pictureBox2);
                ResizeControl(label1OriginalRect, label1);
                ResizeControl(playOriginalRect, play);
                ResizeControl(notPlayOriginalRect, notPlay);

                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                pictureBox1OriginalRect = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox2OriginalRect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Size.Width, pictureBox2.Size.Height);
                label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Size.Width, label1.Size.Height);
                notPlayOriginalRect = new Rectangle(notPlay.Location.X, notPlay.Location.Y, notPlay.Size.Width, notPlay.Size.Height);
                playOriginalRect = new Rectangle(play.Location.X, play.Location.Y, play.Size.Width, play.Size.Height);
                label1.Font = new Font("Monotype Corsiva", 46, FontStyle.Regular);
                play.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Regular);
                notPlay.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Regular);
            }

            count++;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            type = true;
            play.BackColor = Color.LightGreen;
            notPlay.BackColor = Color.Red;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            type= false;
            notPlay.BackColor = Color.PaleGreen;
            play.BackColor = Color.Red;
        }
    }
}
