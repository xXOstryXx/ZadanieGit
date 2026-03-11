using System;
using System.Windows.Forms;
using KalkulatorDLL;

namespace AplikacjaKalkulator
{
    public partial class Form1 : Form
    {
        Matematyka kalkulator = new Matematyka();

        public Form1()
        {
            InitializeComponent();

            buttonDodaj.Click += ButtonDodaj_Click;
            buttonOdejmij.Click += ButtonOdejmij_Click;
            buttonMnoz.Click += ButtonMnoz_Click;
            buttonDziel.Click += ButtonDziel_Click;
        }

        private void ButtonDodaj_Click(object sender, EventArgs e)
        {
            Oblicz("dodawanie");
        }

        private void ButtonOdejmij_Click(object sender, EventArgs e)
        {
            Oblicz("odejmowanie");
        }

        private void ButtonMnoz_Click(object sender, EventArgs e)
        {
            Oblicz("mnozenie");
        }

        private void ButtonDziel_Click(object sender, EventArgs e)
        {
            Oblicz("dzielenie");
        }

        private void Oblicz(string operacja)
        {
            try
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double wynik = 0;

                switch (operacja)
                {
                    case "dodawanie":
                        wynik = kalkulator.Dodawanie(a, b);
                        break;
                    case "odejmowanie":
                        wynik = kalkulator.Odejmowanie(a, b);
                        break;
                    case "mnozenie":
                        wynik = kalkulator.Mnozenie(a, b);
                        break;
                    case "dzielenie":
                        wynik = kalkulator.Dzielenie(a, b);
                        break;
                }

                labelWynik.Text = "Wynik: " + wynik.ToString();
            }
            catch (FormatException)
            {
                Console.WriteLine("B³¹d: Proszê wpisaæ poprawne liczby, a nie litery!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}