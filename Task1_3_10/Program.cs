namespace Task1_3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько домов вы построили?");
            Console.Write("Введите количество построенных застройщиком домов: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 5 && number <= 20)
            {
                Console.WriteLine("Мы построили {0} домов", number);
                Console.ReadKey();
            }
            else
            {
                int n = number % 10;
                switch (n)
                {
                    case 0:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("Мы построили {0} домов", number);
                        Console.ReadKey();
                        break;

                    case 1:
                        Console.WriteLine("Мы построили {0} дом", number);
                        Console.ReadKey();
                        break;

                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Мы построили {0} дома", number);
                        Console.ReadKey();
                        break;


                }
            }
        }
    }
}
