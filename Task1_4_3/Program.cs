namespace Task1_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число 'а', больше нуля: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число 'b', больше нуля: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int s = a;
            for (int i = 2; i <= b; i++)
            {
                s *= a;
            }

            Console.WriteLine("'a' в степени 'b' равно {0}", s);
            Console.ReadKey();
        }
    }
}
