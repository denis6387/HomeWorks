namespace Task1_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int firstNumder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int secondNumder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int thirdNumder = Convert.ToInt32(Console.ReadLine());
            if ((firstNumder < secondNumder && firstNumder > thirdNumder) || (firstNumder > secondNumder && firstNumder < thirdNumder))
            {
                Console.WriteLine("Среднее по величине число: {0}", firstNumder);
                Console.ReadKey();
            }
            else
            {
                if ((secondNumder < thirdNumder && secondNumder > firstNumder) || (secondNumder > thirdNumder && secondNumder < firstNumder))
                {
                    Console.WriteLine("Среднее по величине число: {0}", secondNumder);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Среднее по величине число: {0}", thirdNumder);
                    Console.ReadKey();
                }
            }
        }
    }
}
