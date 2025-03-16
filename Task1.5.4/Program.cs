namespace Task1._5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            int[] arrayDouble = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 11);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                arrayDouble[n-(i+1)] = array[i];
            }

            array = arrayDouble;

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.ReadKey();
        }
    }
}
