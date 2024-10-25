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
    public partial class RockScissorsPaper : Form
    {
        int rounds = 3;
        int timePerRound = 6;
        bool gameOver = false;
        string[] CPUChoiceLst = {"rock", "scissors","paper","scissors", "paper","rock" };
        int randomNumber = 0;
        Random rnd=new Random();
        string CPUChoice;
        string playerChoice;
        int playerScore;
        int CPUScore;
        public RockScissorsPaper()
        {
            InitializeComponent();
            
            playerChoice = "none";
            txtCountDown.Text = "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.rock;
            playerChoice = "rock";

        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {
            timePerRound -= 1;
            txtCountDown.Text=timePerRound.ToString();
            txtRound.Text = "Имаш " + rounds+" рунда";
            if(timePerRound<1)
            {
                countDownTimer.Enabled = false;
                timePerRound = 6;
                randomNumber=rnd.Next(0,CPUChoiceLst.Length);
                CPUChoice=CPUChoiceLst[randomNumber];
                switch (CPUChoice)
                {
                    case "rock":picCPU.Image = Properties.Resources.rock; break;
                    case "scissors": picCPU.Image=Properties.Resources.scissors; break;
                    case "paper":picCPU.Image= Properties.Resources.paper; break;
                }
                if(rounds>0)
                {
                    CheckGame();
                }
                else
                {
                    if(playerScore>CPUScore)
                    {
                        MessageBox.Show("Ти спечели");
                    }
                    else
                    {
                        MessageBox.Show("Компютърът спечели");
                    }
                    gameOver = true;
                }

            }

        }
        private void CheckGame()
        {
            if(playerChoice=="rock"&&CPUChoice=="paper")
            {
               CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("Компютърът печели. Хартията покрива камъка.");
                
            }
           else if (playerChoice == "scissors" && CPUChoice == "rock")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("Компютърът печели. Камъкът чупи ножицата.");

            }
            else if (playerChoice == "paper" && CPUChoice == "scissors")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("Компютърът печели. Ножицата реже хартията.");

            }
            else if (playerChoice == "rock" && CPUChoice == "scissors")
            {
                playerScore += 1;
                rounds -= 1;
                countDownTimer.Stop();
                MessageBox.Show("Ти печелиш.Камъкът чупи ножицата.");
                groupBox1.Visible = true;
                info1.Visible = true;
                button2.Visible = true;
                
            }
            else if (playerChoice == "paper" && CPUChoice == "rock")
            {
                playerScore += 1;
                rounds -= 1;
                countDownTimer.Stop();
                MessageBox.Show("Ти печелиш.Хартията покрижа камъка.");
                groupBox2.Visible = true;
                label3.Visible = true;
                button3.Visible = true;
               ;
            }
            else if (playerChoice == "scissors" && CPUChoice == "paper")
            {
                playerScore += 1;
                rounds -= 1;
                countDownTimer.Stop();
                MessageBox.Show("Ти печелиш.Ножицата реже хартията");
                groupBox3.Visible = true;
                label4.Visible = true;
                button4.Visible=true;
                
            }
            else if (playerChoice == "none"&&countDownTimer.Enabled==true)
            {
               
                MessageBox.Show("Избери камък, ножица или хартия");

            }
            else if(countDownTimer.Enabled == true)
            {
                MessageBox.Show("Равни!!!");
            }

            StartNextRound();
        }
        private void StartNextRound()
        {
            if (gameOver == true)
            {
                return;
            }
            txtScore.Text = "Играч: " + playerScore + " - " + "Компютър: " + CPUScore;
            playerChoice = "none";
            countDownTimer.Enabled = true;
            picPlayer.Image = Properties.Resources.Question_Mark_PNG_Image_Transparent;
            picCPU.Image=Properties.Resources.Question_Mark_PNG_Image_Transparent;
        }

        private void buttbtnScissorson3_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissors;
            playerChoice = "scissors";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            CPUScore = 0;
            rounds = 3;
            txtScore.Text = "Играч: " + playerScore + " - " + "Компютър: " + CPUScore;
            playerChoice = "none";
            countDownTimer.Enabled = true;
            picPlayer.Image = Properties.Resources.Question_Mark_PNG_Image_Transparent;
            picPlayer.Image = Properties.Resources.Question_Mark_PNG_Image_Transparent;
            gameOver = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Storage st = new Storage();
            countDownTimer.Stop();
            st.Show();
            this.Hide();
        }

        private void RockScissorsPaper_Load(object sender, EventArgs e)
        {
            countDownTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            info1.Visible = false;
            button2.Visible = false;
            groupBox1.Visible = false;
            countDownTimer.Start(); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            label3.Visible = false;
            button3.Visible = false;
            groupBox2.Visible = false;
            countDownTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            label4.Visible = false;
            button4.Visible = false;
            groupBox3.Visible = false;
            countDownTimer.Start();
        }

        
    }
}
