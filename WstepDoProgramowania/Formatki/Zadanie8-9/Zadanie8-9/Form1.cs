using System;
using System.Windows.Forms;

namespace KolkoKrzyzyk
{
    public partial class Form1 : Form
    {
        // Globalne zmienne zgodnie z poleceniem
        bool ruch = false;
        int ruchIlosc = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Metoda do obsługi kliknięć w pola siatki
        private void button_Click(object sender, EventArgs e)
        {
            // Zapisanie w pamięci klikniętego przycisku
            Button przycisk = (Button)sender;

            // Ustawienie X lub O
            if (ruch == true)
            {
                przycisk.Text = "X";
            }
            else
            {
                przycisk.Text = "O";
            }

            // Zmiana ruchu na odwrotny, zwiększenie licznika, zablokowanie przycisku
            ruch = !ruch;
            ruchIlosc++;
            przycisk.Enabled = false;
        }
    }
}