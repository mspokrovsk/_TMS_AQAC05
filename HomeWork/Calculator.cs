namespace HomeWork
{
        public class Calculator
    {
        public int Div(int a, int b) => a / b;


        public double Div(double a, double b) => a / b;
    }

    public class DivideByZeroException : Exception
    {
        public DivideByZeroException(string message) : base(message) { }
    }
}