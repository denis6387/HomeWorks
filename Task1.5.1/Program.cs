namespace Task1._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int chet = 0, nechet = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 101);
                Console.Write("{0} ", array[i]);
                if (array[i] % 2 == 0)
                {
                    chet++;
                }
                else
                {
                    nechet++;
                }
            }
            Console.WriteLine();
            if (chet > nechet)
            {
                Console.WriteLine("В массиве четных чисел больше, чем нечетных");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("В массиве нечетных чисел больше, чем четных");
                Console.ReadKey();
            }
            if (chet == nechet)
            {
                Console.WriteLine("В массиве количество четных чисел равно количеству нечетных чисел");
                Console.ReadKey();
            }

        }
    }
}
