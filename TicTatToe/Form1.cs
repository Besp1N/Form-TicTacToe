using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTatToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gracz1 = true;
        int ruch = 0;

        private void restartuj()
        {
            Button[] all = new Button[9];
            all[0] = button1;
            all[1] = button2;
            all[2] = button3;
            all[3] = button4;
            all[4] = button5;
            all[5] = button6;
            all[6] = button7;
            all[7] = button8;
            all[8] = button9;

            foreach (Button b in all)
            {
                b.Enabled = true;
                b.Text = string.Empty;
                b.BackColor = Color.White;
            }
            ruch = 0;
        }

        private void wygrana()
        {
           MessageBox.Show("Wygrywa gracz: " + (gracz1 ? "O" : "X"), "Wygrana:)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (gracz1)
            {
                lblWynikO.Text = (int.Parse(lblWynikO.Text) + 1).ToString();
            }
            else
            {
                lblWynikX.Text = (int.Parse(lblWynikX.Text) + 1).ToString();
            }
            restartuj();

        }

        private void zmienKolor(Button button1, Button button2, Button button3)
        {
            button1.BackColor = Color.LightGreen;
            button2.BackColor = Color.LightGreen;
            button3.BackColor = Color.LightGreen;
        }

        private void sprawdz()
        {
            //w poziomie
            if(button1.Text != string.Empty && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                zmienKolor(button1, button2, button3);
                wygrana();           
            }
            else if (button4.Text != string.Empty && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                zmienKolor(button4, button5, button6);
                wygrana();
            }
            else if (button7.Text != string.Empty && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                zmienKolor(button7, button8, button9);
                wygrana();
            }

            //w pionie
            else if (button1.Text != string.Empty && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                zmienKolor(button1, button4, button7);
                wygrana();
            }
            else if (button2.Text != string.Empty && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                zmienKolor(button2, button5, button8);
                wygrana();
            }
            else if (button3.Text != string.Empty && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                zmienKolor(button3, button6, button9);
                wygrana();
            }

            //po skosie
            if (button1.Text != string.Empty && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                zmienKolor(button1, button5, button9);
                wygrana();
            }
            if (button3.Text != string.Empty && button3.Text == button5.Text && button5.Text == button7.Text)
            {
                zmienKolor(button3, button5, button7);
                wygrana();
            }

            //remis
            if (ruch == 9)
            {
                MessageBox.Show("remis","koniec gry",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                restartuj();
            }
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            lblWynikO.Text = "0";
            lblWynikX.Text = "0";
            lblRuch.Text = "O";
            restartuj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ruch++;
            var button = sender as Button;
            button.Text = gracz1 ? "O" : "X";
            button.Enabled = false;
            if(ruch >=5)
            {
                sprawdz();
            }
            gracz1 = !gracz1;
            lblRuch.Text = gracz1 ? "O" : "X";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ruch++;
            var button = sender as Button;
            button.Text = gracz1 ? "O" : "X";
            button.Enabled = false;
            if (ruch >= 5)
            {
                sprawdz();
            }
            gracz1 = !gracz1;
            lblRuch.Text = gracz1 ? "O" : "X";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ruch++;
            var button = sender as Button;
            button.Text = gracz1 ? "O" : "X";
            button.Enabled = false;
            if (ruch >= 5)
            {
                sprawdz();
            }
            gracz1 = !gracz1;
            lblRuch.Text = gracz1 ? "O" : "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruch++;
            var button = sender as Button;
            button.Text = gracz1 ? "O" : "X";
            button.Enabled = false;
            if (ruch >= 5)
            {
                sprawdz();
            }
            gracz1 = !gracz1;
            lblRuch.Text = gracz1 ? "O" : "X";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ruch++;
            var button = sender as Button;
            button.Text = gracz1 ? "O" : "X";
            button.Enabled = false;
            if (ruch >= 5)
            {
                sprawdz();
            }
            gracz1 = !gracz1;
            lblRuch.Text = gracz1 ? "O" : "X";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ruch++;
            var button = sender as Button;
            button.Text = gracz1 ? "O" : "X";
            button.Enabled = false;
            if (ruch >= 5)
            {
                sprawdz();
            }
            gracz1 = !gracz1;
            lblRuch.Text = gracz1 ? "O" : "X";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ruch++;
            var button = sender as Button;
            button.Text = gracz1 ? "O" : "X";
            button.Enabled = false;
            if (ruch >= 5)
            {
                sprawdz();
            }
            gracz1 = !gracz1;
            lblRuch.Text = gracz1 ? "O" : "X";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ruch++;
            var button = sender as Button;
            button.Text = gracz1 ? "O" : "X";
            button.Enabled = false;
            if (ruch >= 5)
            {
                sprawdz();
            }
            gracz1 = !gracz1;
            lblRuch.Text = gracz1 ? "O" : "X";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ruch++;
            var button = sender as Button;
            button.Text = gracz1 ? "O" : "X";
            button.Enabled = false;
            if (ruch >= 5)
            {
                sprawdz();
            }
            gracz1 = !gracz1;
            lblRuch.Text = gracz1 ? "O" : "X";
        }
    }
}
