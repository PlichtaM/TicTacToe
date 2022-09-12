using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kółko_i_x
{
    public partial class Form1 : Form
    {
        bool graczx = true;
        int runda = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Sprawdz()
        {
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                wygrana();
            }
            if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                wygrana();
            }
            if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                wygrana();
            }
            if (button1.Text != "" && button1.Text == button4.Text && button7.Text == button4.Text)
            {
                wygrana();
            }
            if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                wygrana();
            }
            if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                wygrana();
            }
            if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                wygrana();
            }
            if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
            {
                wygrana();
            }
            else if(runda==9) {
                MessageBox.Show("Remis", "Koniec Gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restartuj();   }
        }

        private void Restartuj()
        {
            runda = 0;
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
            foreach(Button b in all)
            {
                b.Enabled = true;
                b.Text="";
            }
        }

        private void wygrana()
        {

            MessageBox.Show("Wygrywa gracz: "+ (graczx? "X":"O"), "Wygrana", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            if (graczx)
                wynikx.Text = ((int.Parse(wynikx.Text)) + 1).ToString();
            else 
                wyniko.Text = ((int.Parse(wyniko.Text)) + 1).ToString();
            Restartuj(); 
        }

        private void restart_Click(object sender, EventArgs e)
        {
            wyniko.Text = "0";
            wynikx.Text = "0";
            graczx = true;
            ruch.Text = "X";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            runda++;
            ((Button)sender).Text = graczx ?   "X": "0";
            ((Button)sender).Enabled = false;
            if (runda>= 5)
            {
                Sprawdz();
            }
            graczx = !graczx;
            ruch.Text = graczx ? "X" : "O";
        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            runda++;
            ((Button)sender).Text = graczx ? "X" : "0";
            ((Button)sender).Enabled = false;
            if (runda >= 5)
            {
                Sprawdz();
            }
            graczx = !graczx;
            ruch.Text = graczx ? "X" : "O";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            runda++;
            ((Button)sender).Text = graczx ? "X" : "0";
            ((Button)sender).Enabled = false;
            if (runda >= 5)
            {
                Sprawdz();
            }
            graczx = !graczx;
            ruch.Text = graczx ? "X" : "O";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            runda++;
            ((Button)sender).Text = graczx ? "X" : "0";
            ((Button)sender).Enabled = false;
            if (runda >= 5)
            {
                Sprawdz();
            }
            graczx = !graczx;
            ruch.Text = graczx ? "X" : "O";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            runda++;
            ((Button)sender).Text = graczx ? "X" : "0";
            ((Button)sender).Enabled = false;
            if (runda >= 5)
            {
                Sprawdz();
            }
            graczx = !graczx;
            ruch.Text = graczx ? "X" : "O";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            runda++;
            ((Button)sender).Text = graczx ? "X" : "0";
            ((Button)sender).Enabled = false;
            if (runda >= 5)
            {
                Sprawdz();
            }
            graczx = !graczx;
            ruch.Text = graczx ? "X" : "O";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            runda++;
            ((Button)sender).Text = graczx ? "X" : "0";
            ((Button)sender).Enabled = false;
            if (runda >= 5)
            {
                Sprawdz();
            }
            graczx = !graczx;
            ruch.Text = graczx ? "X" : "O";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            runda++;
            ((Button)sender).Text = graczx ? "X" : "0";
            ((Button)sender).Enabled = false;
            if (runda >= 5)
            {
                Sprawdz();
            }
            graczx = !graczx;
            ruch.Text = graczx ? "X" : "O";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            runda++;
            ((Button)sender).Text = graczx ? "X" : "0";
            ((Button)sender).Enabled = false;
            if (runda >= 5)
            {
                Sprawdz();
            }
            graczx = !graczx;
            ruch.Text = graczx ? "X" : "O";
        }
    }

       
    }
