namespace Task1._5._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            int[,] array = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int max = array[i, 0];
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(0, 11);
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                    Console.Write("{0,-4}", array[i, j]);
                }
                Console.Write("| ");
                Console.WriteLine("{0,-3} - максимальный элемент в строке.", max);
            }

            Console.ReadKey();
        }
    }
}
