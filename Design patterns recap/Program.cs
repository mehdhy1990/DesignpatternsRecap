using Design_patterns_recap.AbstractFactory;
using Design_patterns_recap.AdapterPattern;
using Design_patterns_recap.BridgePattern;
using Design_patterns_recap.BuilderPattern;
using Design_patterns_recap.DecoratorPattern;
using Design_patterns_recap.FactoryMethod;
using Design_patterns_recap.Prototype;
using Design_patterns_recap.Singleton;

namespace Design_patterns_recap;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Decorator";
        var cloudMailService = new CloudMainService();
        cloudMailService.SendMail("Hi there");

        var onPremiseCloudService = new OnPremiseMainService();
        onPremiseCloudService.SendMail("Hi there");
        
        var statisticsMailService = new StaticMailService(cloudMailService);
        statisticsMailService.SendMail($"Hi there from the {statisticsMailService.GetType().Name}");
        
        var messageDatabase = new MessageDatabaseDecorator(onPremiseCloudService);
        messageDatabase.SendMail($"Hi there via {messageDatabase.GetType().Name} message 1");
        messageDatabase.SendMail($"Hi there via {nameof(messageDatabase)} message 2");

        foreach (var message in messageDatabase.SentMessages)
        {
            Console.WriteLine($"stored Message: {message}");
        }
    }
}