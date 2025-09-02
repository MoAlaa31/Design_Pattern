namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball() { Id = 1 };

            Console.WriteLine(ball.BallLocation);

            ball.BallLocation = new Location(1,2,3);

            Player p11 = new Player() { Name = "Messi", Team = "PSG" };
            Player p12 = new Player() { Name = "Neymar", Team = "PSG" };

            Player p21 = new Player() { Name = "Salah", Team = "Liverpool" };
            Player p22 = new Player() { Name = "Van Dijk", Team = "Liverpool"};

            Refree refree = new Refree() { Name = "Gresha" };

            ball.BallLocationChanged += p11.Run;
            ball.BallLocationChanged += p12.Run;
            ball.BallLocationChanged += p21.Run;
            ball.BallLocationChanged += p22.Run;
            ball.BallLocationChanged += refree.Look;

            ball.BallLocationChanged += (newLocation) => Console.WriteLine("Extra Method");

            ball.BallLocation = new Location(10, 29, 8);

            ball.BallLocationChanged -= p21.Run;

            ball.BallLocation = new Location(10, 80, 8);
        }
    }
}
