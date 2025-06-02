using Design_patterns_recap.AbstractFactory;
using Design_patterns_recap.AdapterPattern;
using Design_patterns_recap.BridgePattern;
using Design_patterns_recap.BuilderPattern;
using Design_patterns_recap.FactoryMethod;
using Design_patterns_recap.Prototype;
using Design_patterns_recap.Singleton;

namespace Design_patterns_recap;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Bridge";
        var noCoupon = new NoCoupon();
        var oneEuroCoupon = new OneEuroDiscount();
        var twoEuroCoupon = new TwoEuroDiscount();

        var meatBasedMenu = new MeatBaesedMenu(noCoupon);
        Console.WriteLine($"Meat based menu: {meatBasedMenu.CalculatePrice()} euro");
        
        
        var vegetarionMenu = new VegetarianMenu(oneEuroCoupon);
         Console.WriteLine($"Vegetarian menu: {vegetarionMenu.CalculatePrice()} euro");
    }
}