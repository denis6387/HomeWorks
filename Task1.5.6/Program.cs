namespace Task1._5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] array = new int[n, n];
            int chet = 0, a = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a = chet % 2;
                    array[i, j] = a == 1 ? 0 : 1;
                    Console.Write("{0} ", array[i, j]);
                    chet++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
