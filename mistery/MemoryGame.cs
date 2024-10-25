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
    public partial class MemoryGame : Form
    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer =new Timer();
        int time = 60;
        Timer timer = new Timer { Interval=1000};
        public MemoryGame()
        {
            InitializeComponent();
        }
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.pic1,
                    Properties.Resources.pic2,
                    Properties.Resources.pic3,
                    Properties.Resources.pic4,
                    Properties.Resources.pic5,
                    Properties.Resources.pic6,
                    Properties.Resources.pic7,
                    Properties.Resources.pic8,
                };
            }
        }
        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("Времето ви свърши!");
                    ResetImages();
                }
                var ssTime = TimeSpan.FromSeconds(time);
                label1.Text = "00: " + time.ToString();
            };
        }
        private void ResetImages()
        {
            foreach(var pic in pictureBoxes)
            {
                pic.Tag=null;
                pic.Visible = true;
            }
            HideImages();
            setRandomImages();
            time = 60;
            timer.Start();
        }
        private void HideImages()
        {
            foreach(var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.bpic;
            }
        }
        private PictureBox getFreeSlot()
        {
            int num;
            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }
        private void setRandomImages()
        {
            foreach(var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;

            }
        }
        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();
            allowClick = true;
            clickTimer.Stop();
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;
            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image= (Image)pic.Tag;
            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            timer.Enabled = false;
            MessageBox.Show("Кодовата дума за следващата стая е 'Вато'");
            
            Barock F7 = new Barock();
            F7.Show();
            this.Hide();
            clickTimer.Stop();  
        }

        private void startGame(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Barock F7 = new Barock();
            timer.Enabled = false;
            F7.Show();
            this.Hide();
            clickTimer.Stop();
        }
    }
}
