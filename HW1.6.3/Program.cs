namespace HW1._6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год, за который нужен отчет: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц, за который нужен отчет: ");
            string month = Console.ReadLine();
            Console.Write("Укажите общую сумму продаж за указаный месяц: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите количество проданных товаров в указанном месяце: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.WriteLine($"Отчет о продажах за {month} {year} года.");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.WriteLine($"Общая сумма продаж за {month} {year} года составляет: {sum:N2} р.");
            Console.WriteLine();
            Console.WriteLine($"Количество проданных товаров: {quantity:0,0} шт.");
            Console.WriteLine();
            Console.WriteLine($"Средняя стоимость товара: {sum / quantity:N2} р.");
            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
