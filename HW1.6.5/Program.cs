using System.Text.RegularExpressions;

namespace HW1._6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер телефона в соответствии с образцом: +7(000)000-00-00");
            string number = Console.ReadLine();

            Regex regex = new Regex(@"^\+7\(\d{3}\)\d{3}-\d{2}-\d{2}$");

            if (regex.IsMatch(number))
            {
                Console.WriteLine("Номер телефона корректен.");
            }
            else
            {
                Console.WriteLine("Номер телефона некорректен.");
            }

            Console.ReadKey(); 
        }
    }
}
