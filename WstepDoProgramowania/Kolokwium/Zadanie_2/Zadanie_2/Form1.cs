using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_2
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<char, string> slownikCyfr = new Dictionary<char, string>
        {
            {'0', "zero"}, {'1', "jeden"}, {'2', "dwa"}, {'3', "trzy"}, {'4', "cztery"},
            {'5', "pięć"}, {'6', "sześć"}, {'7', "siedem"}, {'8', "osiem"}, {'9', "dziewięć"}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string wprowadzonyTekst = txtInput.Text;
            txtOutput.Clear();

            if (string.IsNullOrWhiteSpace(wprowadzonyTekst))
            {
                MessageBox.Show("Pole wejściowe nie może być puste. Proszę podać ciąg cyfr.",
                                "Błąd wejścia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> listaSlow = new List<string>();

            try
            {
                foreach (char znak in wprowadzonyTekst)
                {
                    if (slownikCyfr.ContainsKey(znak))
                    {
                        listaSlow.Add(slownikCyfr[znak]);
                    }
                    else
                    {
                        throw new FormatException($"Wprowadzono nieprawidłowy znak: '{znak}'. Akceptowane są wyłącznie cyfry (0-9).");
                    }
                }

                txtOutput.Text = string.Join(" ", listaSlow);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Błąd formatu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOutput.Text = "Błąd: Nieprawidłowe dane wejściowe.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił nieoczekiwany błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
