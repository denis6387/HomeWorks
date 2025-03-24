namespace HW1._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string output = "";

            string[] s = input.Split(new[] { ' ' });

            foreach (string a in s)
            {
                if (a.Length > output.Length)
                {
                    output = a;
                }
            }

            Console.WriteLine($"Самое длинное слово в вашем предложении: {output}");
            Console.ReadKey(); 
        }
    }
}
