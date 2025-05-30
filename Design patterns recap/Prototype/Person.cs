using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace Design_patterns_recap.Prototype;

public abstract class Person
{
    public abstract string Name { get; set; }
    public abstract Person Clone(bool deepclone);
}

public class Manager : Person
{
    public override string Name { get; set; }

    public Manager(string name)
    {
        Name = name;
    }

    public override Person Clone(bool deepclone = false)
    {
        if (deepclone)
        {
            var objectAsJson = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Manager>(objectAsJson);
        }
        return (Person)MemberwiseClone();
    }
}

public class Eemployee : Person
{
    public Manager Manager { get; set; }
    public override string Name { get; set; }

    public Eemployee(string name, Manager manager)
    {
        Manager = manager;
        Name = name;
    }

    public override Person Clone(bool deepclone = false)
    {
        if (deepclone)
        {
            var objectAsJson = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Manager>(objectAsJson);
        }
        return (Person)MemberwiseClone();
    }
}