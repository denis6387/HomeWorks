namespace Task1._5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int plus = 0, minus = 0, zero = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-20,21);
                Console.Write("{0} ", array[i]);
                if (array[i] < 0)   minus++;
                if (array[i] > 0)   plus++;
                if (array[i] == 0)  zero++;
            }
            Console.WriteLine();
            Console.WriteLine("Количество положительных чисел рано {0}.", plus);
            Console.WriteLine("Количество отрицательных чисел равно {0}.", minus);
            Console.WriteLine("Количество чисел, равных нулю, равно {0}.", zero);
            Console.ReadKey();
        }
    }
}
