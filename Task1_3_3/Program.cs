namespace Task1_3_3
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
            Console.WriteLine("Введите четвертое число");
            int fourthNumder = Convert.ToInt32(Console.ReadLine());
            if (firstNumder > secondNumder && firstNumder > thirdNumder && firstNumder > fourthNumder)
            {
                Console.WriteLine("Наибольшее из чисел: {0}", firstNumder);
                Console.ReadKey();
            }
            else
            {
                if (secondNumder > thirdNumder && secondNumder > fourthNumder && secondNumder > firstNumder)
                {
                    Console.WriteLine("Наибольшее из чисел: {0}", secondNumder);
                    Console.ReadKey();
                }
                else
                {
                    if (thirdNumder > fourthNumder && thirdNumder > firstNumder && thirdNumder > secondNumder)
                    {
                        Console.WriteLine("Наибольшее из чисел: {0}", thirdNumder);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Наибольшее из чисел: {0}", fourthNumder);
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
