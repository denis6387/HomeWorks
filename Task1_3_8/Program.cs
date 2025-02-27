namespace Task1_3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            string answer = (number >= -10 && number <= 10) ? "Да" : "Нет";
            Console.WriteLine("Введенное число попадает в диапазон [-10;10] ?");
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
