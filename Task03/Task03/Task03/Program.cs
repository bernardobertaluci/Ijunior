namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pathfinder filePathfinder = new Pathfinder(new FileLogger());
            Pathfinder consolePathfinder = new Pathfinder(new ConsoleLogger());
            Pathfinder filePathfinderOfDay = new Pathfinder(new DependentLogger(new FileLogger(), new FridayLogger()));
            Pathfinder consolePathfinderOfDay = new Pathfinder(new DependentLogger(new ConsoleLogger(), new FridayLogger()));
            Pathfinder multiLogger = new Pathfinder(new MultiLogger(new ConsoleLogger(), new DependentLogger(new FileLogger(), new FridayLogger())));

            filePathfinder.Find();
        }
    }
}
