namespace Task1_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы в метрах, l = ");
            double l = Convert.ToDouble(Console.ReadLine());

            int l2 = Convert.ToInt32(Math.Ceiling(l));

            Console.WriteLine("Округлил длину трубы в большую сторону. У меня получилось {0} метров", l2);
            Console.ReadKey(); 
        }
    }
}

