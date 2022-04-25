using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] pobieranie()
        {
            string[] tablica = (contentTextBox.Text).Split(' ');
            return tablica;
        }

        private void wyswietlenie(string[] tablica)
        {
            finalTextBox.Text = "";
            for (int i = 0; i < tablica.Length - 1; i++)
            {
                finalTextBox.Text += tablica[i] + " ";
            }
            finalTextBox.Text += tablica[tablica.Length - 1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] tablica = pobieranie();
            if (!wielkaLiteraCheckBox.Checked && !parzystaCheckBox.Checked && !dlugoscCheckBox.Checked)
            {
                MessageBox.Show("Wybierz kryteria!");
            }
            else
            {
                if (wielkaLiteraCheckBox.Checked)
                {

                }
                if (dlugoscCheckBox.Checked)
                {
                    tablica = tablica.Where(n => n.Length <= 5).ToArray();
                }
                if (parzystaCheckBox.Checked)
                {
                    tablica = tablica.Where(n => n.Length % 2 == 0).ToArray();
                }
                wyswietlenie(tablica);
            }
        }

        private void sortowanieButton_Click(object sender, EventArgs e)
        {
            string[] tablica = pobieranie();
            if (sortowanieCheckBox.Checked)
            {
                tablica = tablica.OrderBy(n => n.Length).ToArray();
            }
            else
            {
                tablica = tablica.OrderByDescending(n => n.Length).ToArray();
            }
            wyswietlenie(tablica);
        }

        private void maleLiteryButton_Click(object sender, EventArgs e)
        {
            string[] tablica = pobieranie();
            tablica = tablica.Select(n => n.ToLower()).ToArray();
            wyswietlenie(tablica);
        }

        private void wielkieLiteryButton_Click(object sender, EventArgs e)
        {
            string[] tablica = pobieranie();
            tablica = tablica.Select(n => n.ToUpper()).ToArray();
            wyswietlenie(tablica);
        }

        private void UsuwanieButton_Click(object sender, EventArgs e)
        {
            string[] tablica = pobieranie();
            tablica = tablica.Select(n => n.usuwanie_samoglos()).ToArray();
            wyswietlenie(tablica);
        }

        private void zawieraButton_Click(object sender, EventArgs e)
        {
            bool zawiera = false;
            string[] tablica = pobieranie();
            string litery = "eyuioaEYUIOA";
            for (int i = 0; i < litery.Length; i++)
            {
                if (tablica.Where(n => n.Contains(litery[i])).Any())
                {
                    zawiera = true;
                }
            }
            finalTextBox.Text = zawiera.ToString();
        }

        private void spolgloskiButton_Click(object sender, EventArgs e)
        {
            string[] tablica = pobieranie();
            bool zawiera = tablica.Where(n => n.Length > 5).Any();
            finalTextBox.Text = zawiera.ToString();
        }

        private void zawieranapisButton_Click(object sender, EventArgs e)
        {
            string[] tablica = pobieranie();
            bool zawiera = tablica.Where(n => n.StartsWith(napistextBox.Text)).Any();
            finalTextBox.Text = zawiera.ToString();
        }

        private void sredniaButton_Click(object sender, EventArgs e)
        {
            string[] tablica = pobieranie();
            double dlugosc = tablica.Average(n => n.Length);
            finalTextBox.Text = dlugosc.ToString();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            string[] tablica = pobieranie();
            double dlugosc = tablica.Min(n => n.Length);
            finalTextBox.Text = dlugosc.ToString();
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            string[] tablica = pobieranie();
            double dlugosc = tablica.Max(n => n.Length);
            finalTextBox.Text = dlugosc.ToString();
        }

        private void sumaButton_Click(object sender, EventArgs e)
        {
            string[] tablica = pobieranie();
            double dlugosc = tablica.Sum(n => n.Length);
            finalTextBox.Text = dlugosc.ToString();
        }
    }

    public static class Klass
    {
        public static string usuwanie_samoglos(this string slowo)
        {
            string litery = "eyuioaEYUIOA";
            string result = "";
            foreach (var element in slowo)
            {
                if (!litery.Contains(element))
                {
                    result += element;
                }
            }
            return result;
        }
    }
}
