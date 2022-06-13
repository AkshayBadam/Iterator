using System;
namespace Iterate
{
    public class Program
    {
        static void Main()
        {
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Student("Anurag", 100));
            Iterator iterator = collection.CreateIterator();     
            Console.WriteLine("Iterating over collection:");
            for (Elempoyee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
        }
    }
}