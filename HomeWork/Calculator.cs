namespace HomeWork
{
        public class Calculator
    {
        public int Div(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно");
            }
            return a / b;
        }

        public double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно");
            }
            return a / b;
        }
    }

    public class DivideByZeroException : Exception
    {
        public DivideByZeroException(string message) : base(message) { }
    }
}