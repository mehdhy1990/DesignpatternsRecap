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
    public Car Car { get;private set; }

    public CarBuilder(string carType)
    {
        Car = new Car(carType);
    }

    public abstract void BuildEngine();
    public abstract void BuildFrame();
}