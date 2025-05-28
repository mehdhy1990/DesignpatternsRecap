namespace Design_patterns_recap.AbstractFactory;

public interface IShoppingCartService
{
    IDiscountService CreateDiscountService();
    IShippingCostService CreateShippingCostService();
}

public interface IShippingCostService
{
    int DiscountPercentage { get; }
}

public interface IDiscountService
{
    decimal ShippingCost { get; }
}
public class BelgiumDiscountService : IDiscountService
{
    public decimal ShippingCost => 20;
}
public class FranceDiscountService : IDiscountService
{
    public decimal ShippingCost => 10;
}