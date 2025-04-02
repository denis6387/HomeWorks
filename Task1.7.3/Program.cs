namespace Task1._7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            PrintNumbers(numbers); 
            PrintNumbers(numbers, true);

            Console.ReadKey();
        }

        static void PrintNumbers(int[] array, bool reverse = false)
        {
            if (reverse)
            {
                for (int i = array.Length - 1; i > 0 || i == 0; i--)
                    Console.Write($"{array[i]} ");
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                    Console.Write($"{array[i]} ");
                Console.WriteLine();
            }
        }
    }
}
