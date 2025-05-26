using Design_patterns_recap.Singleton;

namespace Design_patterns_recap;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Design patterns recap";
        var instance1 = Logger.Instance;
        var instance2 = Logger.Instance;

        if (instance1 == instance2 && instance2 == Logger.Instance)
        {
            Console.WriteLine("instances are the same");
        }
        instance1?.Log($"message from {nameof(instance1)}");
        instance2?.Log($"message from {nameof(instance2)}");
        Logger.Instance?.Log($"message from {nameof(Logger)}");
    }
}