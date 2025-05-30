using Design_patterns_recap.AbstractFactory;
using Design_patterns_recap.AdapterPattern;
using Design_patterns_recap.BuilderPattern;
using Design_patterns_recap.FactoryMethod;
using Design_patterns_recap.Prototype;
using Design_patterns_recap.Singleton;

namespace Design_patterns_recap;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Adapter";
        ICityAdapter adapter = new CityAdapter();
        var city = adapter.GetCity();
        
        Console.WriteLine($"city name is: {city.FullName}, and population is {city.Inhabitants}");
    }
}