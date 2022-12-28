namespace hw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, hasil, i, count, a, b, c, d;
            Console.WriteLine("eded daxil edin:");
            num = int.Parse(Console.ReadLine());
            a = num / 1000;
            b = (num / 100) % 10;
            c = (num / 10) % 10;
            d = num % 10;
            hasil = 1 * a + 2 * b + 3 * c + 4 * d;
            Console.WriteLine(hasil);

        }
    }
}