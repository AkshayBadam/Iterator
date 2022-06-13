using System;
namespace Iterate
{
    public class Program
    {
        static void Main()
        {
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddStudent(new Student(100, "Akshay"));
            Iterator iterator = collection.CreateIterator();     
            Console.WriteLine("Iterating over collection:");
            for (Student emp = ((AbstractIterator)iterator).First(); !iterator.IsCompleted; emp = ((AbstractIterator)iterator).Next())
            {
                Console.WriteLine($"ID : {emp.Id} & Name : {emp.Name}");
            }
        }
    }
}