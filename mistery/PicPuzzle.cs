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
    public partial class PicPuzzle : Form
    {
        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> OriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        private void PicPuzzle_Load(object sender, EventArgs e)
        {
            Shuffle();
        }
        void Shuffle()
        {
            do
            {
                int j;
                List<int> Index = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Index.Remove((j = Index[r.Next(0, Index.Count)]));
                    ((PictureBox)groupBox1.Controls[i]).Image = OriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;
                }
            }
            while (CheckWin());
        }
        bool CheckWin()
        {
            int i;
            int j = 8;
            for (i = 0; i < 8; i++)
            {
                if ((groupBox1.Controls[j] as PictureBox).Image != OriginalPictureList[i]) break;
                j--;
            }
            if (i == 8) return true;
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Shuffle();
                timer.Reset();
                label2.Text = "00:00:00";
                inmoves = 0;
                label1.Text = "Номер находове : 0";
        

        }
       
        private void SwitchPictureBox(object sender, EventArgs e)
        {
            if (label2.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = groupBox1.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> br = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (br.Contains(inNullSliceIndex))
                {
                    ((PictureBox)groupBox1.Controls[inNullSliceIndex]).Image = ((PictureBox)groupBox1.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)groupBox1.Controls[inPictureBoxIndex]).Image = OriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    label1.Text = "Номер на ходове: " + (++inmoves);
                    if (CheckWin())
                    {
                        timer.Stop();
                        (groupBox1.Controls[0] as PictureBox).Image = OriginalPictureList[8];
                        MessageBox.Show("Браво! Наредихте пъзела.\nУспешно преминахте през всички стаи!");
                        MessageBox.Show("Може да преминете към теста.");
                        this.Hide();
                        Map map = new Map();
                        map.Show();

                    }
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer.Elapsed.ToString()!="00:00:00")
                label2.Text=timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString()=="00:00:00")
                button2.Enabled = false;
            else
              button2.Enabled = true;
            if(timer.Elapsed.Minutes.ToString()=="2")
            {
                timer.Reset();
                label1.Text = "Номер на ходове: 0";
                label2.Text = "00:00:00";
                inmoves = 0;
                button2.Enabled=false;
                MessageBox.Show("Времето ти изтече");
                Shuffle();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Пауза")
            {
                timer.Stop();
                groupBox1.Visible = false;
                button2.Text = "Продължи";
            }
            else
            {
                timer.Start();
                groupBox1.Visible = true;
                button2.Text = "Пауза";
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Impresionisum F4 = new Impresionisum();
            F4.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer.Stop();
            int j = 8;
            for (int i = 0; i < 9; i++)
            {
                ((PictureBox)groupBox1.Controls[i]).Image = OriginalPictureList[j];
                j--;
            }
            (groupBox1.Controls[0] as PictureBox).Image = OriginalPictureList[8];
            MessageBox.Show("Браво! Наредихте пъзела.\nУспешно преминахте през всички стаи!");
            MessageBox.Show("Може да преминете към теста.");
            this.Hide();
            Map map = new Map();
            map.Show();
        }

        public PicPuzzle()
        {
            InitializeComponent();
            OriginalPictureList.AddRange(new Bitmap[] {Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null} );
            label1.Text += inmoves;
            label2.Text = "00:00:00";
        }

    }
}
