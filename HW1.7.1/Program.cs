namespace HW1._7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника:");
            Console.Write("a1 = ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1 = ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c1 = ");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите стороны второго треугольника:");
            Console.Write("a2 = ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2 = ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c2 = ");
            double c2 = Convert.ToDouble(Console.ReadLine());

            double S1 = Square(a1, b1, c1);
            double S2 = Square(a2, b2, c2);

            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго треугольника");
            }
            else
            {
                Console.WriteLine("Площадь второго треугольника больше площади первого треугольника");
            }

            Console.ReadKey();
        }

        static double Square (double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}
