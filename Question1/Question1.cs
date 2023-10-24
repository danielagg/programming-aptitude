namespace MM_Guide_Programming_Aptitude.Question1;

public static class Question1
{
    public static void Main(string[] args)
    {
        AnimalList listOfAnimals = new AnimalList();
        DoubleList listOfNumbers = new DoubleList();
        
        listOfNumbers.DoSomething(2.5);
        listOfAnimals.DoSomething(new Animal());
    }
    
    public class Animal
    {
        public string Name { get; set; }
        public List<string> Habitats { get; set; }
    }
    
    public class AnimalList
    {
        public void DoSomething(Animal animal)
        {
            Console.WriteLine("Foo Animal");
        }
    }
    public class DoubleList
    {
        public void DoSomething(double number)
        {
            Console.WriteLine("Foo Number");
        }
    }
}