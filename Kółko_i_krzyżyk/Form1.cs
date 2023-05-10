using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {

        bool czyj_ruch = true; // true to X, false to O

        public Form1()
        {
            InitializeComponent();
        }

        private void WstawZnak(object przycik)
        {
            Button wciesnietyPrzycisk = (Button)przycik;


            if (czyj_ruch)
            {
                wciesnietyPrzycisk.Text = "X";
            }
            else
            {
                wciesnietyPrzycisk.Text = "O";
            }

            wciesnietyPrzycisk.Enabled = false;


            czyj_ruch = !czyj_ruch;
            if(czyj_ruch)
            {
                label1.Text = "Aktualnie gra: X";
            }
            else
            {
                label1.Text = "Aktualnie gra: O";
            }


            bool wynik = SpradzCzyKtosWygral();

            if (wynik)
            {
                string tekstWygranej;
                if (czyj_ruch)
                {
                    tekstWygranej = "Wygrał gracz O! Rozpocząć jeszcze raz?";
                }
                else
                {
                    tekstWygranej = "Wygrał gracz X! Rozpocząć jeszcze raz?";
                }
                //przechwytywanie naciśniętego przycisku z MessageBox
                DialogResult odpowiedz = MessageBox.Show(tekstWygranej, "Wygrana", MessageBoxButtons.YesNo);

                if(odpowiedz == DialogResult.Yes) 
                {
                    WlaczWszystkiePrzyciskiIResetuj();
                    return;
                }
                else
                {
                    Close();
                }
            }

        }
        // funkcja odpowiedzialna za restart gry
        private void WlaczWszystkiePrzyciskiIResetuj()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            czyj_ruch = true;
            label1.Text = "Aktualnie gra: X";
        }
        private bool SpradzCzyKtosWygral()
        {
            //wiersz 1
            if(btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "")
            {
                return true;
            }
            //wiersz 2
            else if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "")
            {
                return true;
            }
            //wiersz 3
            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "")
            {
                return true;
            }
            //kolumna 1
            if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "")
            {
                return true;
            }
            //kolumna 2
            if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "")
            {
                return true;
            }
            //kolumna 3
            if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "")
            {
                return true;
            }
            //przekątna 1
            if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "")
            {
                return true;
            }
            //przekątna 2
            if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "")
            {
                return true;
            }

            return false;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
    }
}
