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
    public partial class Map : Form
    {
        private Rectangle label9OriginalRect;
        private Rectangle label10OriginalRect;
        private Rectangle label11OriginalRect;
        private Rectangle label12OriginalRect;
        private Rectangle label13OriginalRect;
        private Rectangle label14OriginalRect;
        private Rectangle label15OriginalRect;
        private Rectangle label16OriginalRect;
        private Rectangle label17OriginalRect;
        private Rectangle label18OriginalRect;
        private Rectangle label19OriginalRect;
        private Rectangle label20OriginalRect;
        private Rectangle choiceOriginalRect;
        private Rectangle contOriginalRect;
        private Rectangle exitOriginalRect;

        private Rectangle button3OriginalRect;
        private Rectangle button4OriginalRect;
        private Rectangle button5OriginalRect;
        private Rectangle button6OriginalRect;
        private Rectangle button7OriginalRect;
        private Rectangle button8OriginalRect;

        private Rectangle textBox5OriginalRect;
        private Rectangle textBox6OriginalRect;
        private Rectangle textBox7OriginalRect;
        private Rectangle textBox8OriginalRect;

        private Rectangle originalFormSize;
        private int count = 0;
        public Map()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
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
           MainRoom F1 = new MainRoom();
            F1.Show();
            this.Hide();
        }

        

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            textBox2.Visible = true;
            textBox1.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MainRoom F1 = new MainRoom();
            F1.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
            if (MainRoom.Type == false)
            {
                Renesance ren = new Renesance();
                ren.Show();
                this.Hide();
            }
            else
            {
                button3.Visible = true;
                label16.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string code = textBox5.Text;
            if (code == "Да Винчи")
            {
                Renesance F6 = new Renesance();
                F6.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Грешен код");
                textBox5.Text = "";
                button3.Visible = false;
                label16.Visible = false;
                textBox5.Visible = false;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
           
            if (MainRoom.Type == true)
            {
                Storage F5 = new Storage();
                F5.Show();
                this.Hide();
            }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
            if (MainRoom.Type == false)
            {
                Barock br = new Barock();
                br.Show();
                this.Hide();
            }
            else
            {
                button4.Visible = true;
                label17.Visible = true;
                textBox6.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string code = textBox6.Text;
            if (code == "Караваджо")
            {
                Barock F7 = new Barock();
                F7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Грешен код");
                textBox6.Text = "";
                button4.Visible = false;
                textBox6.Visible = false;
                label17.Visible = false;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
           
            if (MainRoom.Type == false)
            {
                Rokoko r = new Rokoko();
                r.Show();
                this.Hide();
            }
            else
            {
                button5.Visible = true;
                label18.Visible = true;
                textBox7.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string code = textBox7.Text;
            if (code == "Вато")
            {
                Rokoko F3 = new Rokoko();
                F3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Грешен код");
                textBox7.Text = "";
                button5.Visible = false;
                textBox7.Visible = false;
                label18.Visible = false;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            MainRoom room = new MainRoom();
            if (MainRoom.Type == false)
            {
                Impresionisum impr = new Impresionisum();
                impr.Show();
                this.Hide();
            }
            else
            {
                button6.Visible = true;
                label19.Visible = true;
                textBox8.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string code = textBox8.Text;
            if (code == "Моне")
            {
                Impresionisum F4 = new Impresionisum();
                F4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Грешен код");
                textBox8.Text = "";
                button6.Visible = false;
                textBox8.Visible = false;
                label19.Visible = false;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
           
            if (MainRoom.Type == true)
            {
                label20.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
            }
            else 
            {
                cont.Visible = true;
                exit.Visible = true;
                choice.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label20.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TestWords test= new TestWords();
            test.Show();
            this.Hide();
        }

        private void Map_Load(object sender, EventArgs e)
        {
           
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            label9OriginalRect = new Rectangle(label9.Location.X, label9.Location.Y, label9.Size.Width, label9.Size.Height);
            label10OriginalRect = new Rectangle(label10.Location.X, label10.Location.Y, label10.Size.Width, label10.Size.Height);
            label11OriginalRect = new Rectangle(label11.Location.X, label11.Location.Y, label11.Size.Width, label11.Size.Height);
            label12OriginalRect = new Rectangle(label12.Location.X, label12.Location.Y, label12.Size.Width, label12.Size.Height);
            label13OriginalRect = new Rectangle(label13.Location.X, label13.Location.Y, label13.Size.Width, label13.Size.Height);
            label14OriginalRect = new Rectangle(label14.Location.X, label14.Location.Y, label14.Size.Width, label14.Size.Height);
            label15OriginalRect = new Rectangle(label15.Location.X, label15.Location.Y, label15.Size.Width, label15.Size.Height);
            label16OriginalRect = new Rectangle(label16.Location.X, label16.Location.Y, label16.Size.Width, label16.Size.Height);
            label17OriginalRect = new Rectangle(label17.Location.X, label17.Location.Y, label17.Size.Width, label17.Size.Height);
            label18OriginalRect = new Rectangle(label18.Location.X, label18.Location.Y, label18.Size.Width, label18.Size.Height);
            label19OriginalRect = new Rectangle(label19.Location.X, label19.Location.Y, label19.Size.Width, label19.Size.Height);
            label20OriginalRect = new Rectangle(label20.Location.X, label20.Location.Y, label20.Size.Width, label20.Size.Height);
            choiceOriginalRect = new Rectangle(choice.Location.X, choice.Location.Y, choice.Size.Width, choice.Size.Height);
            contOriginalRect = new Rectangle(cont.Location.X, cont.Location.Y, cont.Size.Width, cont.Size.Height);
            exitOriginalRect = new Rectangle(exit.Location.X, exit.Location.Y, exit.Size.Width, exit.Size.Height);

            button3OriginalRect = new Rectangle(button3.Location.X, button3.Location.Y, button3.Size.Width, button3.Size.Height);
            button4OriginalRect = new Rectangle(button4.Location.X, button4.Location.Y, button4.Size.Width, button4.Size.Height);
            button5OriginalRect = new Rectangle(button5.Location.X, button5.Location.Y, button5.Size.Width, button5.Size.Height);
            button6OriginalRect = new Rectangle(button6.Location.X, button6.Location.Y, button6.Size.Width, button6.Size.Height);
            button7OriginalRect = new Rectangle(button7.Location.X, button7.Location.Y, button7.Size.Width, button7.Size.Height);
            button8OriginalRect = new Rectangle(button8.Location.X, button8.Location.Y, button8.Size.Width, button8.Size.Height);

            textBox5OriginalRect = new Rectangle(textBox5.Location.X, textBox5.Location.Y, textBox5.Size.Width, textBox5.Size.Height);
            textBox6OriginalRect = new Rectangle(textBox6.Location.X, textBox6.Location.Y, textBox6.Size.Width, textBox6.Size.Height);
            textBox7OriginalRect = new Rectangle(textBox7.Location.X, textBox7.Location.Y, textBox7.Size.Width, textBox7.Size.Height);
            textBox8OriginalRect = new Rectangle(textBox8.Location.X, textBox8.Location.Y, textBox8.Size.Width, textBox8.Size.Height);
            WindowState = FormWindowState.Maximized;
        }

        private void Map_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ResizeControl(label9OriginalRect, label9);
                ResizeControl(label10OriginalRect, label10);
                ResizeControl(label11OriginalRect, label11);
                ResizeControl(label12OriginalRect, label12);
                ResizeControl(label13OriginalRect, label13);
                ResizeControl(label14OriginalRect, label14);
                ResizeControl(label15OriginalRect, label15);
                ResizeControl(label16OriginalRect, label16);
                ResizeControl(label17OriginalRect, label17);
                ResizeControl(label18OriginalRect, label18);
                ResizeControl(label19OriginalRect, label19);
                ResizeControl(label20OriginalRect, label20);

                ResizeControl(button3OriginalRect, button3);
                ResizeControl(button4OriginalRect, button4);
                ResizeControl(button5OriginalRect, button5);
                ResizeControl(button6OriginalRect, button6);
                ResizeControl(button7OriginalRect, button7);
                ResizeControl(button8OriginalRect, button8);

                ResizeControl(textBox5OriginalRect, textBox5);
                ResizeControl(textBox6OriginalRect, textBox6);
                ResizeControl(textBox7OriginalRect, textBox7);
                ResizeControl(textBox8OriginalRect, textBox8);
                ResizeControl(choiceOriginalRect, choice);
                ResizeControl(contOriginalRect, cont);
                ResizeControl(exitOriginalRect, exit);

                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                label9OriginalRect = new Rectangle(label9.Location.X, label9.Location.Y, label9.Size.Width, label9.Size.Height);
                label10OriginalRect = new Rectangle(label10.Location.X, label10.Location.Y, label10.Size.Width, label10.Size.Height);
                label11OriginalRect = new Rectangle(label11.Location.X, label11.Location.Y, label11.Size.Width, label11.Size.Height);
                label12OriginalRect = new Rectangle(label12.Location.X, label12.Location.Y, label12.Size.Width, label12.Size.Height);
                label13OriginalRect = new Rectangle(label13.Location.X, label13.Location.Y, label13.Size.Width, label13.Size.Height);
                label14OriginalRect = new Rectangle(label14.Location.X, label14.Location.Y, label14.Size.Width, label14.Size.Height);
                label15OriginalRect = new Rectangle(label15.Location.X, label15.Location.Y, label15.Size.Width, label15.Size.Height);
                label16OriginalRect = new Rectangle(label16.Location.X, label16.Location.Y, label16.Size.Width, label16.Size.Height);
                label17OriginalRect = new Rectangle(label17.Location.X, label17.Location.Y, label17.Size.Width, label17.Size.Height);
                label18OriginalRect = new Rectangle(label18.Location.X, label18.Location.Y, label18.Size.Width, label18.Size.Height);
                label19OriginalRect = new Rectangle(label19.Location.X, label19.Location.Y, label19.Size.Width, label19.Size.Height);
                label20OriginalRect = new Rectangle(label20.Location.X, label20.Location.Y, label20.Size.Width, label20.Size.Height);

                button3OriginalRect = new Rectangle(button3.Location.X, button3.Location.Y, button3.Size.Width, button3.Size.Height);
                button4OriginalRect = new Rectangle(button4.Location.X, button4.Location.Y, button4.Size.Width, button4.Size.Height);
                button5OriginalRect = new Rectangle(button5.Location.X, button5.Location.Y, button5.Size.Width, button5.Size.Height);
                button6OriginalRect = new Rectangle(button6.Location.X, button6.Location.Y, button6.Size.Width, button6.Size.Height);
                button7OriginalRect = new Rectangle(button7.Location.X, button7.Location.Y, button7.Size.Width, button7.Size.Height);
                button8OriginalRect = new Rectangle(button8.Location.X, button8.Location.Y, button8.Size.Width, button8.Size.Height);

                textBox5OriginalRect = new Rectangle(textBox5.Location.X, textBox5.Location.Y, textBox5.Size.Width, textBox5.Size.Height);
                textBox6OriginalRect = new Rectangle(textBox6.Location.X, textBox6.Location.Y, textBox6.Size.Width, textBox6.Size.Height);
                textBox7OriginalRect = new Rectangle(textBox7.Location.X, textBox7.Location.Y, textBox7.Size.Width, textBox7.Size.Height);
                textBox8OriginalRect = new Rectangle(textBox8.Location.X, textBox8.Location.Y, textBox8.Size.Width, textBox8.Size.Height);
                choiceOriginalRect = new Rectangle(choice.Location.X, choice.Location.Y, choice.Size.Width, choice.Size.Height);
                contOriginalRect = new Rectangle(cont.Location.X, cont.Location.Y, cont.Size.Width, cont.Size.Height);
                exitOriginalRect = new Rectangle(exit.Location.X, exit.Location.Y, exit.Size.Width, exit.Size.Height);

                foreach (Control contr in this.Controls)
                {
                    if (contr is Label)
                    {
                        

                        if (contr==label20)
                        {
                            contr.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Regular);
                        }
                        else if(contr == choice)
                        {
                            contr.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Regular);
                           
                        }
                        else
                        {
                            contr.Font = new Font("Microsoft Sans Serif", 38, FontStyle.Regular);
                        }

                        
                    }
                    else if (contr is Button)
                    {
                        contr.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Regular);
                    }
                    else if (contr is TextBox)
                    {
                        contr.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Regular);
                    }
                }
                label14.Top += 3;
            }
            else if (WindowState == FormWindowState.Normal && count != 0)
            {
                ResizeControl(label9OriginalRect, label9);
                ResizeControl(label10OriginalRect, label10);
                ResizeControl(label11OriginalRect, label11);
                ResizeControl(label12OriginalRect, label12);
                ResizeControl(label13OriginalRect, label13);
                ResizeControl(label14OriginalRect, label14);
                ResizeControl(label15OriginalRect, label15);
                ResizeControl(label16OriginalRect, label16);
                ResizeControl(label17OriginalRect, label17);
                ResizeControl(label18OriginalRect, label18);
                ResizeControl(label19OriginalRect, label19);
                ResizeControl(label20OriginalRect, label20);

                ResizeControl(button3OriginalRect, button3);
                ResizeControl(button4OriginalRect, button4);
                ResizeControl(button5OriginalRect, button5);
                ResizeControl(button6OriginalRect, button6);
                ResizeControl(button7OriginalRect, button7);
                ResizeControl(button8OriginalRect, button8);

                ResizeControl(textBox5OriginalRect, textBox5);
                ResizeControl(textBox6OriginalRect, textBox6);
                ResizeControl(textBox7OriginalRect, textBox7);
                ResizeControl(textBox8OriginalRect, textBox8);
                ResizeControl(choiceOriginalRect, choice);
                ResizeControl(contOriginalRect, cont);
                ResizeControl(exitOriginalRect, exit);

                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                choiceOriginalRect = new Rectangle(choice.Location.X, choice.Location.Y, choice.Size.Width, choice.Size.Height);
                contOriginalRect = new Rectangle(cont.Location.X, cont.Location.Y, cont.Size.Width, cont.Size.Height);
                exitOriginalRect = new Rectangle(exit.Location.X, exit.Location.Y, exit.Size.Width, exit.Size.Height);
                label9OriginalRect = new Rectangle(label9.Location.X, label9.Location.Y, label9.Size.Width, label9.Size.Height);
                label10OriginalRect = new Rectangle(label10.Location.X, label10.Location.Y, label10.Size.Width, label10.Size.Height);
                label11OriginalRect = new Rectangle(label11.Location.X, label11.Location.Y, label11.Size.Width, label11.Size.Height);
                label12OriginalRect = new Rectangle(label12.Location.X, label12.Location.Y, label12.Size.Width, label12.Size.Height);
                label13OriginalRect = new Rectangle(label13.Location.X, label13.Location.Y, label13.Size.Width, label13.Size.Height);
                label14OriginalRect = new Rectangle(label14.Location.X, label14.Location.Y, label14.Size.Width, label14.Size.Height);
                label15OriginalRect = new Rectangle(label15.Location.X, label15.Location.Y, label15.Size.Width, label15.Size.Height);
                label16OriginalRect = new Rectangle(label16.Location.X, label16.Location.Y, label16.Size.Width, label16.Size.Height);
                label17OriginalRect = new Rectangle(label17.Location.X, label17.Location.Y, label17.Size.Width, label17.Size.Height);
                label18OriginalRect = new Rectangle(label18.Location.X, label18.Location.Y, label18.Size.Width, label18.Size.Height);
                label19OriginalRect = new Rectangle(label19.Location.X, label19.Location.Y, label19.Size.Width, label19.Size.Height);
                label20OriginalRect = new Rectangle(label20.Location.X, label20.Location.Y, label20.Size.Width, label20.Size.Height);

                button3OriginalRect = new Rectangle(button3.Location.X, button3.Location.Y, button3.Size.Width, button3.Size.Height);
                button4OriginalRect = new Rectangle(button4.Location.X, button4.Location.Y, button4.Size.Width, button4.Size.Height);
                button5OriginalRect = new Rectangle(button5.Location.X, button5.Location.Y, button5.Size.Width, button5.Size.Height);
                button6OriginalRect = new Rectangle(button6.Location.X, button6.Location.Y, button6.Size.Width, button6.Size.Height);
                button7OriginalRect = new Rectangle(button7.Location.X, button7.Location.Y, button7.Size.Width, button7.Size.Height);
                button8OriginalRect = new Rectangle(button8.Location.X, button8.Location.Y, button8.Size.Width, button8.Size.Height);

                textBox5OriginalRect = new Rectangle(textBox5.Location.X, textBox5.Location.Y, textBox5.Size.Width, textBox5.Size.Height);
                textBox6OriginalRect = new Rectangle(textBox6.Location.X, textBox6.Location.Y, textBox6.Size.Width, textBox6.Size.Height);
                textBox7OriginalRect = new Rectangle(textBox7.Location.X, textBox7.Location.Y, textBox7.Size.Width, textBox7.Size.Height);
                textBox8OriginalRect = new Rectangle(textBox8.Location.X, textBox8.Location.Y, textBox8.Size.Width, textBox8.Size.Height);

                foreach (Control contr in this.Controls)
                {
                    if (contr is Label)
                    { 
                        if(contr.Name == "choice")
                            contr.Font =  new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
                        else
                            contr.Font = new Font("Microsoft Sans Serif", 19, FontStyle.Regular);
                    }
                    else if (contr is Button)
                    {
                        contr.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                    }
                    else if (contr is TextBox)
                    {
                        contr.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    }
                }
                
            }

            count++;

        }

        private void exit_Click(object sender, EventArgs e)
        {
          this.Hide();  
        }

        private void cont_Click(object sender, EventArgs e)
        {
            MainRoom room = new MainRoom();
            room.Show();
            this.Hide();
        }
    }
}
