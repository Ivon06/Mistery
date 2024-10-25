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
    public partial class ConnectingGame : Form
    {
        string text = "";
        public ConnectingGame()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Hide();
            button1.Hide();
            impres.Show();
            rokoko.Show();
            barok.Show();
            mone.Show();
            vato.Show();
            karavajo.Show();
            end.Show();
        }

        private void rokoko_Click_1(object sender, EventArgs e)
        {
            text = rokoko.Text;
        }

        private void barok_Click_1(object sender, EventArgs e)
        {
            text = barok.Text;

        }

        private void impres_Click_1(object sender, EventArgs e)
        {
            text = impres.Text;
        }

        private void karavajo_Click_1(object sender, EventArgs e)
        {
            if (text == "Барок")
            {
                barok.BackColor = Color.DarkSeaGreen;
                karavajo.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                MessageBox.Show("Грешка.Опитай отново");
            }
        }

        private void mone_Click_1(object sender, EventArgs e)
        {
            if (text == "Импресионизъм")
            {
                impres.BackColor = Color.DarkSeaGreen;
                mone.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                MessageBox.Show("Грешка.Опитай отново");
            }
        }

        private void vato_Click_1(object sender, EventArgs e)
        {
            if (text == "Рококо")
            {
                vato.BackColor = Color.DarkSeaGreen;
                rokoko.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                MessageBox.Show("Грешка.Опитай отново");
            }
        }

        private void end_Click_1(object sender, EventArgs e)
        {
            if (vato.BackColor == Color.DarkSeaGreen && rokoko.BackColor == Color.DarkSeaGreen && impres.BackColor == Color.DarkSeaGreen && barok.BackColor == Color.DarkSeaGreen && mone.BackColor == Color.DarkSeaGreen && karavajo.BackColor == Color.DarkSeaGreen)
            {

                MessageBox.Show("Ключът за първата стая е 'Да Винчи'");
                this.Hide();
                Map map = new Map();
                map.Show();

            }
            else
            {
                MessageBox.Show("Неправилно свързване. Опитай отново.");
            }
        }
    }
}
