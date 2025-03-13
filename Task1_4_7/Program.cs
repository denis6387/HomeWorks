namespace Task1_4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int k = 1;
            while ((n / 10) != 0)
            {
                k += 1;
                n /= 10;
            }
            
            Console.WriteLine("Количество цифр в введенном числе - {0}.", k);
            Console.ReadKey();

        }
    }
}
