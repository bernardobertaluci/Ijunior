namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pathfinder consolePathfinder = new Pathfinder(new ConsoleLogger());
            Pathfinder filePathFinder = new Pathfinder(new FileLogger());
            Pathfinder filePathFinderToDay = new Pathfinder(new DependentLogger(new FileLogger()));
            Pathfinder consolePathFinderToDay = new Pathfinder(new DependentLogger(new ConsoleLogger()));
            Pathfinder MultiLogger = new Pathfinder(new MultiLogger(new ConsoleLogger(), new DependentLogger(new FileLogger())));
            consolePathFinderToDay.Find();
        }
    }
}