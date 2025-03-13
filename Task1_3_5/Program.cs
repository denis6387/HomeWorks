namespace Task1_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            string answer = (number % 10 == 0) ? "Да" : "Нет";
            Console.WriteLine("Заканчивается ли введенное число на 0?");
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
