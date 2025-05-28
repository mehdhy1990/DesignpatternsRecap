using Design_patterns_recap.AbstractFactory;
using Design_patterns_recap.BuilderPattern;
using Design_patterns_recap.FactoryMethod;
using Design_patterns_recap.Singleton;

namespace Design_patterns_recap;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Design patterns Builder";
        var garage = new Garage();
        var miniBuilder = new MiniBuilder();
        var bmwBuilder = new BMWBuilder();
        garage.Construct(miniBuilder);
        Console.Write(miniBuilder.Car.ToString());
        
        garage.Construct(bmwBuilder);
        Console.Write(bmwBuilder.Car.ToString());
    }
}