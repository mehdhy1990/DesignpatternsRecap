namespace Design_patterns_recap.AbstractFactory;

public interface IShoppingCartPurachaseFactory
{
    IDiscountService CreateDiscountService();
    IShippingCostService CreateShippingCostService();
}

public interface IShippingCostService
{
    int ShippingCost { get; }
}

public interface IDiscountService
{
    decimal DiscountPercentage { get; }
}
public class BelgiumDiscountService : IDiscountService
{
    public decimal DiscountPercentage => 20;
}
public class FranceDiscountService : IDiscountService
{
    public decimal DiscountPercentage => 10;
}
public class BelgiumShippingCostService : IShippingCostService
{
    public int ShippingCost => 20;
}
public class FranceShippingCostService : IShippingCostService
{
    public int ShippingCost => 25;
}
public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurachaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new BelgiumDiscountService();
    }

    public IShippingCostService CreateShippingCostService()
    {
       return new BelgiumShippingCostService();
    }
}
public class FranceShoppingCartPurchaseFactory : IShoppingCartPurachaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new FranceDiscountService();
    }

    public IShippingCostService CreateShippingCostService()
    {
        return new FranceShippingCostService();
    }
}

public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostService _shippingCostService;
    private int _orderCost;
    public ShoppingCart(IShoppingCartPurachaseFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostService = factory.CreateShippingCostService();
        _orderCost = 200;
    }

    public void CalculateCost()
    {
        Console.WriteLine($"Total cost: {_orderCost -(_orderCost * _discountService.DiscountPercentage/100)+_shippingCostService.ShippingCost}");
    }
}