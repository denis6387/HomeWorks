namespace Task1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите длину отрезка в дюймах, l = ");
            double l = Convert.ToDouble(Console.ReadLine());

            double lmm = l * 25.4;
            int lm = Convert.ToInt32(lmm / 1000);
            int lsm = Convert.ToInt32((lmm % 1000) / 10);
            lmm = Convert.ToInt32(lmm % 10);

            Console.WriteLine("Длина вашего отрезка составляет {0} метров, {1} сантиметров и {2} миллиметров", lm, lsm, lmm);
            Console.ReadKey();
        }
    }
}
