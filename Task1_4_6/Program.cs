namespace Task1_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double ost = n;
            while (ost >= 1)
            {
                if (ost == 1)
                {
                    Console.WriteLine("Введеное число является степенью 2-ки");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    ost /= 2;
                }
            }
            if (ost != 1)
            {
                Console.WriteLine("Введеное число не является степенью 2-ки");
                Console.ReadKey();
            }
        }
    }
}
