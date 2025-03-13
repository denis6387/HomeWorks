namespace Task1_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в диапазоне от 20 до 60 включительно: ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a < 20 || a > 60)
            {
                while (a < 20 || a > 60)
                {
                    Console.Write("Не пытайтесь меня обмануть! Введите число в диапазоне от 20 до 60 включительно: ");
                    a = Convert.ToDouble(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Спасибо!");
                Console.ReadKey();
            }
        }
    }
}
