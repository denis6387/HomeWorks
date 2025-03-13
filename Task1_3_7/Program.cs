namespace Task1_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            string answer = (number > 9 && number < 100) ? "Да" : "Нет";
            Console.WriteLine("Введенное число двухзначное?");
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
