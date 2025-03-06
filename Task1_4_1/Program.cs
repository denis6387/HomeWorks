namespace Task1_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
            { 
                fact = fact * i;
            }
            Console.WriteLine("Факториал числа {0} равен {1}", n, fact);
            Console.ReadKey();
        }
    }
}
