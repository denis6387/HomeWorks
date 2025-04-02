namespace Task1._7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber1 = FindMax(10, 3, 23, 0, 32);
            Console.WriteLine($"Max number: {maxNumber1}");

            int maxNumber2 = FindMax(-8, 7, 0, -14, 9);
            Console.WriteLine($"Max number: {maxNumber2}");

            Console.ReadKey();
        }

        static int FindMax(params int[] numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers) 
                if (number > max)
                    max = number;
            return max;
        }

    }
}
