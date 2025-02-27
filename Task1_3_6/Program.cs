namespace Task1_3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            string answer = (number % 2 == 0) ? "Да" : "Нет";
            Console.WriteLine("Введенное число четное?");
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
