namespace Task1_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число, а = ");
            int a = Convert.ToInt32(Console.ReadLine());

            int a1 = a / 1000;
            int a2 = (a % 1000) / 100;
            int a3 = (a % 100) / 10;
            int a4 = a % 10;

            Console.WriteLine("Поменял местами в вашем числе 2 и 4 цифры и вот, что получилось: {0}{1}{2}{3}", a1, a4, a3, a2);
            Console.ReadKey(); 
        }
    }
}
