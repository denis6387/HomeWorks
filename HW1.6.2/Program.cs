namespace HW1._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку и я определю является ли она палиндромом: ");
            string input = Console.ReadLine();
            string temp = input.Replace(" ", "").ToLower();
            string answer = "Введенная строка является палиндромом.";
            int lengthTemp = temp.Length;

            for (int i = 0; i < lengthTemp / 2; i++)
            {
                if (temp[i] != temp[lengthTemp - 1 - i])
                {
                    answer = "Веденная строка не является палиндромом.";
                    break;
                }
            }
                     
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
