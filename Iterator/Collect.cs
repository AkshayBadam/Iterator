using System.Collections.Generic;
namespace Iterate
{
    class ConcreteCollection : AbstractCollection
    {
        private List<Student> lists = new List<Student>();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get { return lists.Count; }
        }
        public void AddStudent(Student s)      
        {
            lists.Add(s);
        }
        public Student GetStudent(int IndexPosition)
        {
            return lists[IndexPosition];
        }
    }
}