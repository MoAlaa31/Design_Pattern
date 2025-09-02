namespace Decorator_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage esspresso = new Espresso();
            Console.WriteLine(esspresso);
            Milk espressoWithMilk = new Milk(esspresso);
            Console.WriteLine(espressoWithMilk);
            Mocha espWithMilkAndMocha = new Mocha(espressoWithMilk);
            Console.WriteLine(espWithMilkAndMocha);
        }
    }
}
