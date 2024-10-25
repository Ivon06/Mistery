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
    public partial class Test1 : Form
    {
        private int totalPoints = 0;
        private int easyPoints = 0;
        private int mediumPoints = 0;
        private int hardPoints = 0;

        public Test1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(totalPoints>=6)
            {
                MessageBox.Show($" Поздравление имате {totalPoints} от 12 точки и успяхте да излезете от галерията", "Резултат");
                MessageBox.Show("Това беше края на играта. Вие излезнахте от галерията.");
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Вие имате {totalPoints} от 12 точки, но това не е достатъчно, за да излезете ", "Резултат");
                Map map = new Map();
                map.Show();
                this.Hide();
            }
        }

        private void easy_Click(object sender, EventArgs e)
        {
            q1.Visible = true;
            q2.Visible = true;
            q3.Visible = false;
            q4.Visible = false;
            q5.Visible = false;
            q6.Visible = false;
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void medium_Click(object sender, EventArgs e)
        {
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = true;
            q4.Visible = true;
            q5.Visible = false;
            q6.Visible = false;
            
        }

        private void hard_Click(object sender, EventArgs e)
        {
            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = false;
            q5.Visible = true;
            q6.Visible = true;
            

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.Show();
            this.Hide();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (hardPoints < 4)
            {
                totalPoints += 2;
                hardPoints += 2;
                hardPointsLabel.Text = $"{hardPoints}/4";
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (hardPoints < 4)
            {
                totalPoints += 2;
                hardPoints += 2;
                hardPointsLabel.Text = $"{hardPoints}/4";
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked&&mediumPoints<4)
            {
                totalPoints += 2;
                mediumPoints += 2;
                MedPointsLabel.Text = $"{mediumPoints}/4";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked && mediumPoints < 4)
            {
                totalPoints += 2;
                mediumPoints += 2;
                MedPointsLabel.Text = $"{mediumPoints}/4";
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked && easyPoints < 4)
            {
                totalPoints += 2;
                easyPoints += 2;
                easyPointsLabel.Text = $"{easyPoints}/4";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && easyPoints < 4)
            {
                totalPoints += 2;
                easyPoints += 2;
                easyPointsLabel.Text = $"{easyPoints}/4";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton3.Checked&&easyPoints>0)
            //{
            //    totalPoints -= 2;
            //    easyPoints -= 2;
            //    easyPointsLabel.Text = $"{easyPoints}/4";
            //}
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
