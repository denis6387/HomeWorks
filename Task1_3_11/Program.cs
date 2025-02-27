namespace Task1_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры участка, на котором планируется застройка");
            Console.Write("Введита длину 'а' участка: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введита ширину 'b' участка: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите размеры первого дома");
            Console.Write("Введита длину 'p' первого дома: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введита ширину 'q' первого дома: ");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите размеры второго дома");
            Console.Write("Введита длину 'r' второго дома: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введита ширину 's' второго дома: ");
            int s = Convert.ToInt32(Console.ReadLine());

            if ((a >= (p + r) && b >= q && b <= s) || (b >= (q + s) && a >= p && a >= r))
            {
                Console.WriteLine("Дома поместятся на участке");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Дома не поместятся на участке");
                Console.ReadKey();
            }
        }

    }
}
