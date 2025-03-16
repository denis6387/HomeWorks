namespace Task1._5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 51);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            int max = array[0], imax = 0;
            int min = array[0], imin = 0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    imax = i;
                }

                if (array[i] < min)
                {
                    min = array[i]; 
                    imin = i;
                }
            }


            Console.WriteLine("Максимальное число в массиве равно {0} и имеет индекс {1} в массиве", max, imax);
            Console.WriteLine("Минимальное число в массиве равно {0} и имеет индекс {1} в массиве", min, imin);
            Console.ReadKey();
        }
    }
}
