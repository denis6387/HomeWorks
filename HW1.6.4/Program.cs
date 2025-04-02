using System.Text;

namespace HW1._6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите ваш город: ");
            string city = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append($"Имя: {name}. ");
            sb.Append($"Возраст: {age}. "); 
            sb.Append($"Город: {city}.");

            Console.WriteLine(sb);
            Console.ReadKey(); 


        }
    }
}
