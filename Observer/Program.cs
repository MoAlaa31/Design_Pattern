namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football ball = new Football(new Location(1,2,3));

            Player p11 = new Player() { Name = "Messi", Team = "PSG" };
            Player p12 = new Player() { Name = "Neymar", Team = "PSG" };

            Player p21 = new Player() { Name = "Salah", Team = "Liverpool" };
            Player p22 = new Player() { Name = "Van Dijk", Team = "Liverpool" };

            Refree refree = new Refree() { Name = "Gresha" };

            ball.Subscribe(p11);
            ball.Subscribe(p12);
            ball.Subscribe(p21);
            ball.Subscribe(p22);

            ball.Subscribe(refree);

            Console.WriteLine("After Subscribtion");

            ball.ChangeLocation = new Location(4,5,6);
        }
    }
}
