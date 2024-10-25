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
    public delegate void CheckLetter(string letter);
    public partial class TestWords : Form
    {
        bool isGuessed = false;
        int count = 0;
        const int MAX_NUMBER_OF_CHANCE = 5;
        event CheckLetter ChkLtr;

        string input;
        string missedLetters = "";

        string wordToFind = "";

        string wordToDisplay = "";

        char[] wordToFindArray;
        int[] wordToFindLettersPosition;
        bool IsLetterFound = false;

        Random rndm = new Random(0);

        List<string> wordList = new List<string>();

        List<int> wordsIndexAlreadyPlayed = new List<int>();

        int missedLetterCount = 0;
        public TestWords()
        {
            InitializeComponent();
        }
        private void CreateWordList()
        {
            
            wordList.Add("Рококо");
            wordList.Add("Барок");
            wordList.Add("Импресионизъм");
            wordList.Add("Ренесанс");

        }
        private void RestartTheGame()
        {
            try
            {
                wordToFind = GetNewWordFromPool();
                wordToFind = wordToFind.ToUpper();
                wordToFindArray = wordToFind.ToCharArray();

                wordToFindLettersPosition = new int[wordToFind.Length];

                
                input = "";
                wordToDisplay = "";
                for (int i = 0; i < wordToFind.Length; i++)
                {
                    wordToDisplay += "-";
                }

                missedLetters = "";
                missedLetterCount = 0;

                label_Word.Text = wordToDisplay.ToUpper();
                label_MissedLetters.Text = missedLetters;
                label_MissedLtrCnt.Text = MAX_NUMBER_OF_CHANCE.ToString();
                Application.DoEvents();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private string GetNewWordFromPool()
        {
            bool IsNewWord = false;
            string temp = "Изкуство";

            try
            {
                while (IsNewWord == false)
                {
                    
                    int index = rndm.Next();

                    
                    index = index % wordList.Count;

                          if (!wordsIndexAlreadyPlayed.Exists(e => e == index))
                    {
                        temp = wordList[index];
                        wordsIndexAlreadyPlayed.Add(index);
                        IsNewWord = true;
                        break;
                    }
                    else
                    {
                        IsNewWord = false;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return temp.ToUpper();
        }
        private void Testimg_ChkLtr(string currentInputletter)
        {
            try
            {
                if (missedLetterCount < MAX_NUMBER_OF_CHANCE)
                {

                    IsLetterFound = false;
                    for (int i = 0; i < wordToFindArray.Length; i++)
                    {
                        if (currentInputletter[0] == wordToFindArray[i])
                        {
                            wordToFindLettersPosition[i] = 1;
                            IsLetterFound = true;
                        }
                    }

                    if (IsLetterFound == false)
                    {
                        missedLetters += currentInputletter + ", ";
                        missedLetterCount++;
                        label_MissedLtrCnt.Text = (MAX_NUMBER_OF_CHANCE - missedLetterCount).ToString();
                    }

                    wordToDisplay = "";
                    for (int i = 0; i < wordToFindArray.Length; i++)
                    {
                        if (wordToFindLettersPosition[i] == 1)
                        {
                            wordToDisplay += wordToFindArray[i].ToString();
                        }
                        else
                        {
                            wordToDisplay += "-";
                        }
                    }

                    label_Word.Text = wordToDisplay.ToUpper();
                    label_MissedLetters.Text = missedLetters;

                    if (wordToFindLettersPosition.All(e => e == 1))
                    {
                        MessageBox.Show("Браво позна думата.", "Резултат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isGuessed = true;
                        count++;
                        if (count < 4)
                            RestartTheGame();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Ти загуби" + "\n Правилната дума беше: " + wordToFind, "Резултат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Map map = new Map();
                    map.Show();
                    this.Hide();
                }
                Application.DoEvents();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void TestWords_Load(object sender, EventArgs e)
        {
            this.ChkLtr += new CheckLetter(Testimg_ChkLtr);

            
            CreateWordList();

            
            RestartTheGame();
        }

        private void button_A_Click(object sender, EventArgs e)
        {
            input = "А";

            ChkLtr(input);
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            input = "Б";

            ChkLtr(input);
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            input = "В";

            ChkLtr(input);
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            input = "Г";

            ChkLtr(input);
        }

        private void button_E_Click(object sender, EventArgs e)
        {
            input = "Д";

            ChkLtr(input);
        }

        private void button_F_Click(object sender, EventArgs e)
        {
            input = "Е";

            ChkLtr(input);
        }

        private void button_G_Click(object sender, EventArgs e)
        {
            input = "Ж";

            ChkLtr(input);
        }

        private void button_H_Click(object sender, EventArgs e)
        {
            input = "З";

            ChkLtr(input);
        }

        private void button_I_Click(object sender, EventArgs e)
        {
            input = "И";

            ChkLtr(input);
        }

        private void button_J_Click(object sender, EventArgs e)
        {
            input = "Й";

            ChkLtr(input);
        }

        private void button_K_Click(object sender, EventArgs e)
        {
            input = "К";

            ChkLtr(input);
        }

        private void button_L_Click(object sender, EventArgs e)
        {
            input = "Л";

            ChkLtr(input);
        }

        private void button_M_Click(object sender, EventArgs e)
        {
            input = "М";

            ChkLtr(input);
        }

        private void button_N_Click(object sender, EventArgs e)
        {
            input = "Н";

            ChkLtr(input);
        }

        private void button_O_Click(object sender, EventArgs e)
        {
            input = "О";

            ChkLtr(input);
        }

        private void button_P_Click(object sender, EventArgs e)
        {
            input = "П";

            ChkLtr(input);
        }

        private void button_Q_Click(object sender, EventArgs e)
        {
            input = "Р";

            ChkLtr(input);
        }

        private void button_R_Click(object sender, EventArgs e)
        {
            input = "С";

            ChkLtr(input);
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            input = "Т";

            ChkLtr(input);
        }

        private void button_T_Click(object sender, EventArgs e)
        {
            input = "У";

            ChkLtr(input);
        }

        private void button_U_Click(object sender, EventArgs e)
        {
            input = "Ф";

            ChkLtr(input);
        }

        private void button_V_Click(object sender, EventArgs e)
        {
            input = "Х";

            ChkLtr(input);
        }

        private void button_W_Click(object sender, EventArgs e)
        {
            input = "Ц";

            ChkLtr(input);
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            input = "Ч";

            ChkLtr(input);
        }

        private void button_Y_Click(object sender, EventArgs e)
        {
            input = "Ш";

            ChkLtr(input);
        }

        private void button_Z_Click(object sender, EventArgs e)
        {
            input = "Щ";

            ChkLtr(input);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input = "Ъ";

            ChkLtr(input);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input = "Ю";

            ChkLtr(input);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input = "Я";

            ChkLtr(input);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count == 4)
            {
                Test1 test = new Test1();
                test.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не сте познали всички думи");
                Map map = new Map();
                map.Show();
                this.Hide();
            }
        }

        
    }
}
