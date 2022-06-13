using System.Collections.Generic;
namespace Iterate
{
    class ConcreteCollection : AbstractCollection
    {
        private List<Es> lists = new List<Elempoyee>();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get { return lists.Count; }
        }
        public void AddEmployee(Student s)      
        {
            listEs.Add(s);
        }
        public Elempoyee GetStudent(int IndexPosition)
        {
            return listes[IndexPosition];
        }
    }
}