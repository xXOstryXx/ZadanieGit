namespace KalkulatorDLL
{
    public class Matematyka
    {
        public double Dodawanie(double a, double b)
        {
            return a + b;
        }

        public double Odejmowanie(double a, double b)
        {
            return a - b;
        }

        public double Mnozenie(double a, double b)
        {
            return a * b;
        }

        public double Dzielenie(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Nie można dzielić przez zero!");
            return a / b;
        }
    }
}