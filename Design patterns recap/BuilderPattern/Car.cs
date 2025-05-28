using System.Text;

namespace Design_patterns_recap.BuilderPattern;

public class Car
{
    private readonly List<string> _parts = new();
    private readonly string _carType;


    public Car(string carType)
    {
        _carType = carType;
    }

    public void AddPart(string part)
    {
        _parts.Add(part);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var part in _parts)
        {
            sb.AppendLine($"Car Type {_carType}: has parts {part}");
        }

        return sb.ToString();
    }
}

public abstract class CarBuilder
{
    public Car Car { get; private set; }

    public CarBuilder(string carType)
    {
        Car = new Car(carType);
    }

    public abstract void BuildEngine();
    public abstract void BuildFrame();
}

public class MiniBuilder : CarBuilder
{
    public MiniBuilder() : base("Mini")
    {
    }

    public override void BuildEngine()
    {
        Car.AddPart("not a a V8");
    }

    public override void BuildFrame()
    {
        Car.AddPart("3-door with stripes");
    }
}

public class BMWBuilder : CarBuilder
{
    public BMWBuilder() : base("BMW")
    {
    }

    public override void BuildEngine()
    {
        Car.AddPart("'a fancy V8 Engine'");
    }

    public override void BuildFrame()
    {
        Car.AddPart("'5-door with metallic finish'");
    }
}

public class Garage
{
    private CarBuilder? _builder;

    public Garage()
    {
    }

    public void Construct(CarBuilder carBuilder)
    {
        _builder = carBuilder;
        _builder.BuildEngine();
        _builder.BuildFrame();
    }
}