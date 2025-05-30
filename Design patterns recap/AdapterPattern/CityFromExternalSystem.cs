namespace Design_patterns_recap.AdapterPattern;

public class CityFromExternalSystem
{
    public string Name { get; set; }
    public string NickName { get; set; }
    public int Inhabitants { get; set; }

    public CityFromExternalSystem(string name, string nickname, int inhabitants)
    {
        Name = name;
        NickName = nickname;
        Inhabitants = inhabitants;
    }
}

public class ExternalSystem
{
    public CityFromExternalSystem getCity()
    {
        return new CityFromExternalSystem("Antwep", "t stad", 50000);
    }
}

public class City
{
    public string FullName { get; set; }
    public long Inhabitants { get; set; }

    public City(string fullName, long inhabitants)
    {
        FullName = fullName;
        Inhabitants = inhabitants;
    }
}

public interface ICityAdapter
{
    City GetCity();
}
public class CityAdapter : ICityAdapter
{
    public ExternalSystem ExternalSystem { get;private set; }= new ();
    public City GetCity()
    {
        var cityFromExternalSystem = ExternalSystem.getCity();
        return new City($"{cityFromExternalSystem.Name}-{cityFromExternalSystem.NickName}",cityFromExternalSystem.Inhabitants);
    }
}