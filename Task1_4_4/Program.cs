namespace Task1_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число 'а', больше нуля: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число 'b', меньше нуля: ");
            double b = Convert.ToInt32(Console.ReadLine());
            if (b >= 0)
            {
                while (b >= 0)
                {
                    Console.Write("Введите целое число 'b', меньше нуля: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    
                }
            }

            double b2 = -b, s = a;
            for (int i = 2; i <= b2; i++)
            {
                s *= a;
            }
            
            Console.WriteLine("'a' в степени 'b' равно {0}", 1 / s);
            Console.ReadKey();
        }
    }
}
