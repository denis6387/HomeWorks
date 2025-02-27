namespace Task1_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int firstNumder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int secondNumder = Convert.ToInt32(Console.ReadLine());
            if (firstNumder > secondNumder)
            {
                Console.WriteLine("{0} > {1}", firstNumder, secondNumder);
                Console.ReadKey();
            }
            else
            {
                if (firstNumder < secondNumder)
                {
                    Console.WriteLine("{0} < {1}", firstNumder, secondNumder);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("{0} = {1}", firstNumder, secondNumder);
                    Console.ReadKey();
                }
            }
        }
    }
}
