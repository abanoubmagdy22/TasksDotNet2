namespace SolveChallengeDayOop
{
    class Player
    {
        //first require: convert Properties
        public string Name { get; set; }
        public int Health { get; set; }
        public double Experience { get; set; }

        public Player(string name = "Abanoub", int health = 80, double experience = 0.0)
        {
            Name = name;
            Health = health;
            Experience = experience;
        }

        //2  Methods
        public string Shoot()
        {
            return $"{Name} is shooting..";
        }

        public string Trow()
        {
            return $"{Name} is throwing..";
        }

        public string Pass(Player otherPlayer)
        {
            return $"{Name} is passing the ball to {otherPlayer.Name}.";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create players
            Player player1 = new Player("Pop", 100, 49.5);
            Player player2 = new Player();

            // Display player names
            Console.WriteLine(player1.Name);
            Console.WriteLine(player2.Name);

            // Perform actions
            Console.WriteLine(player1.Shoot());
            Console.WriteLine(player1.Trow());
            Console.WriteLine(player1.Pass(player2));
        }
    }
}
