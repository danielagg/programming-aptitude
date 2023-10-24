namespace Programming_Aptitude.Question1;

public static class Question1
{
    public static void Main(string[] args)
    {
        var listOfAnimals = new GenericList<Animal>();
        var listOfNumbers = new GenericList<double>();
        
        listOfNumbers.DoSomething(2.5);
        listOfAnimals.DoSomething(new Animal());
    }
    
    public class Animal
    {
        public string Name { get; set; }
        public GenericList<string> Habitats { get; set; }
    }
    
    public class GenericList<T>
    {
        public void DoSomething(T item) => Console.WriteLine($"Foo {GetToPrint(item)}");
        
        // in the example, when called from DoubleList, even though 25 was passed along, DoSomething() printed "Number"
        // so, I've assumed that the type of the item is what matters, not the value
        // todo? or we should have just returned item.GetType().Name?
        private static string GetToPrint(T item) => item switch
        {
            double => "Number",
            Animal => "Animal",
            _ => item?.GetType().Name ?? "Unknown"
        };
    }
}