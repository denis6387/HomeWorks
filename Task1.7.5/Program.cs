namespace Task1._7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Multiply(2.5, 3.5));

            Console.ReadKey();
        }

        static int Multiply(int num1, int num2)
        { 
            return num1 * num2;
        }

        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
