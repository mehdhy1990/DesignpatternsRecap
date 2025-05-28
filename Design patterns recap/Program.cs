using Design_patterns_recap.AbstractFactory;
using Design_patterns_recap.FactoryMethod;
using Design_patterns_recap.Singleton;

namespace Design_patterns_recap;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Abstract Factory Method";
        var belguimShoppingCartPurchase = new BelgiumShoppingCartPurchaseFactory();
        var ShoppingCartForBelgium = new ShoppingCart(belguimShoppingCartPurchase);
        ShoppingCartForBelgium.CalculateCost();
        
        var FranceShoppingCartPurchase = new FranceShoppingCartPurchaseFactory();
        var ShoppingCartForFrance = new ShoppingCart(FranceShoppingCartPurchase);
        ShoppingCartForFrance.CalculateCost();

    }
}