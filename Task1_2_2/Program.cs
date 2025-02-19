namespace Task1_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите количество градусов угла a - ");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите количество минут угла a - ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите количество секунд угла a - ");
            double s = Convert.ToDouble(Console.ReadLine());

            double a = g + (m + (s / 60)) / 60;
            double rad = a * Math.PI / 180;

            Console.WriteLine("Ваш угол в радианах равен {0}", rad);
            Console.ReadKey();
        }
    }
}
