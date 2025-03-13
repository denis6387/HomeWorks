namespace Task1_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }
            Console.WriteLine("Сумма 1 + 1/2 + ... + 1/n  равна {0}", sum);
            Console.ReadKey();
        }
    }
}
