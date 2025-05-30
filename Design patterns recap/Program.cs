using Design_patterns_recap.AbstractFactory;
using Design_patterns_recap.BuilderPattern;
using Design_patterns_recap.FactoryMethod;
using Design_patterns_recap.Prototype;
using Design_patterns_recap.Singleton;

namespace Design_patterns_recap;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Design patterns Prototype";
        var manager = new Manager("Cindy");
        var managerClone = (Manager)manager.Clone(true);
        Console.WriteLine($"Manager was cloned: {managerClone.Name}");
        
        var employee = new Eemployee("Kevin",manager);
        var employeeClone = (Eemployee)employee.Clone();
        Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager: {employeeClone.Manager.Name}");

        managerClone.Name = "Karen";
        Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");
    }
}