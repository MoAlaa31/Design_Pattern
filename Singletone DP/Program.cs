namespace Singletone_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GCard gCard01 = GCard.SingletonObj;
            Console.WriteLine(gCard01.Data);
            gCard01.Data = 1000;
            GCard gCard02 = GCard.SingletonObj;
            Console.WriteLine(gCard02.Data);

            Console.WriteLine(gCard01.GetHashCode());
            Console.WriteLine(gCard02.GetHashCode());
        }
    }
}
