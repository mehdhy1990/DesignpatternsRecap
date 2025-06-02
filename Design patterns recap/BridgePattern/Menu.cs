namespace Design_patterns_recap.BridgePattern;

public abstract class Menu
{
    public readonly ICoupon _coupon = null!;


    public abstract int CalculatePrice();

    protected Menu(ICoupon coupon)
    {
        _coupon = coupon;
    }
   
}

public interface ICoupon
{
    int CouponValue { get; }
}

public class NoCoupon : ICoupon
{
    public int CouponValue => 0;
}
public class OneEuroDiscount : ICoupon
{
    public int CouponValue => 1;
}
public class TwoEuroDiscount : ICoupon
{
    public int CouponValue => 2;
}

public class VegetarianMenu : Menu
{
    public VegetarianMenu(ICoupon coupon) : base(coupon)
    {
    }

    public override int CalculatePrice()
    {
       return 20 - _coupon.CouponValue;
    }
}
public class MeatBaesedMenu : Menu
{
    public MeatBaesedMenu(ICoupon coupon) : base(coupon)
    {
    }

    public override int CalculatePrice()
    {
        return 30 - _coupon.CouponValue;
    }
}