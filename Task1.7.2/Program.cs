namespace Task1._7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");
            double a = Convert.ToDouble(Console.ReadLine());

            double volume;
            double square;

            CalcCube(a, out volume, out square);

            Console.WriteLine($"Объем куба равен {volume}.");
            Console.WriteLine($"Площадь поверхности куба равна {square}.");
            Console.ReadKey();
        }

        static void CalcCube(double a, out double volume, out double square)
        {
            volume = a * a * a;
            square = 6 * a * a;
        }
    }
}
