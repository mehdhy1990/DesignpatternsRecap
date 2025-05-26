using Design_patterns_recap.FactoryMethod;
using Design_patterns_recap.Singleton;

namespace Design_patterns_recap;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Factory Method";
        var factories = new List<DiscountFactory>
        {
            new CodeDiscountFactory(Guid.NewGuid()),
            new CountryDiscountFactory("BE")
        };
        foreach (var factory in factories)
        {
           var discountService = factory.CreateDiscountService(); 
           Console.WriteLine($"the percentage {discountService.DiscountPercentage} coming from {discountService}");
        }
        
    }
}