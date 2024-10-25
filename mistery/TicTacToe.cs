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
    public partial class TicTacToe : Form
    {
        bool turn = true;
        int turnCount = 0;
        List<string> info = new List<string>() { "Леонардо да Винчи е бил левичар, но освен" +"\n"+" това е пишел и от ляво на дясно и е писал"+"\n"+" самите думи наообратно, което кара  много да мислят, че"+"\n"+" е искал да запази идеите си в тайна.", "Ван Гог счита картината си 'Звездна нощ' за провал."+"\n"+" В писмо до брат си той пише: 'Тази картина не ми говори "+"\n"+ "нищо' и не я изпраща в колета заедно с другите картини." + "\n"+" Днес картината се оценява на 100 милиона долара.", "Един от по-малко известните факти за " + "\n"+"Микеланджело е, че той освен художник и скулптор е бил "+"\n"+ "и чудесен поет. Той е написал стотици писма и поеми, 300 " + "\n" + "от които все още съществуват." };
        private Random rnd = new Random();


        public TicTacToe()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
            try
            {
                A1.Text = "";
                A2.Text = ""; A3.Text = "";
                B1.Text = ""; B2.Text = ""; B3.Text = "";
                C1.Text = ""; C2.Text = ""; C3.Text = "";
                A1.Enabled = true; A2.Enabled = true; A3.Enabled = true;
                B1.Enabled = true; B2.Enabled = true; B3.Enabled = true;
                C1.Enabled = true; C2.Enabled = true; C3.Enabled = true;
            }
            catch
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Storage str = new Storage();
            str.Show();
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            CheckForWinner();
        }
        private void CheckForWinner()
        {
            bool thereIsAWinner = false;
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled)
            {
                if (!string.IsNullOrEmpty(A1.Text) && !string.IsNullOrEmpty(A2.Text) && !string.IsNullOrEmpty(A3.Text))
                    thereIsAWinner = true;
            }
            else if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled)
            {
                if (!string.IsNullOrEmpty(B1.Text) && !string.IsNullOrEmpty(B2.Text) && !string.IsNullOrEmpty(B3.Text))
                    thereIsAWinner = true;
            }
            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
            {
                if (!string.IsNullOrEmpty(C1.Text) && !string.IsNullOrEmpty(C2.Text) && !string.IsNullOrEmpty(C3.Text))
                    thereIsAWinner = true;
            }
            else if (A1.Text == B2.Text && B2.Text == C3.Text && (!A1.Enabled))
            {
                if (!string.IsNullOrEmpty(A1.Text) && !string.IsNullOrEmpty(B2.Text) && !string.IsNullOrEmpty(C3.Text))
                    thereIsAWinner = true;
            }
            else if (A3.Text == B2.Text && B2.Text == C1.Text)
            {
                if (!string.IsNullOrEmpty(A3.Text) && !string.IsNullOrEmpty(B2.Text) && !string.IsNullOrEmpty(C1.Text))
                    thereIsAWinner = true;
            }
            else if (C1.Text == B1.Text && B1.Text == A1.Text)
            {
                if (!string.IsNullOrEmpty(A1.Text) && !string.IsNullOrEmpty(B1.Text) && !string.IsNullOrEmpty(C1.Text))
                    thereIsAWinner = true;
            }
            else if (A2.Text == C2.Text && C2.Text == B2.Text)
            {
                if (!string.IsNullOrEmpty(A2.Text) && !string.IsNullOrEmpty(B2.Text) && !string.IsNullOrEmpty(C2.Text))
                    thereIsAWinner = true;
            }
            else if (A3.Text == B3.Text && B3.Text == C3.Text)
            {
                if (!string.IsNullOrEmpty(A3.Text) && !string.IsNullOrEmpty(B3.Text) && !string.IsNullOrEmpty(C3.Text))
                    thereIsAWinner = true;
            }
            if (thereIsAWinner)
            {
                disabledButtond();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                if (winner == "O")
                {
                    MessageBox.Show(winner +" Печели!");
                    label2.Text = info[rnd.Next(0, info.Count )];
                    button1.Visible = true;
                    groupBox1.Visible = true;
                    label2.Visible = true;
                }
                else 
                { 
                    MessageBox.Show(winner + " Печели!");
                    
                }
            }
            else
            {
                if (turnCount == 9)
                    MessageBox.Show("Играта завърши. Никой не печели.");
            }

        }
        private void disabledButtond()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch
            {

            }

        }


        private void button8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            CheckForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            CheckForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            CheckForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            CheckForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            CheckForWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            CheckForWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            CheckForWinner();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            CheckForWinner();
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Visible=false;
            groupBox1.Visible = false;
            label2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
