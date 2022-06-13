using System;
namespace Iterate
{
	public class Iterator : AbstractIterator
	{
		private ConcreteCollection coll;
		int current = 0;
		int step = 1;
		Iterator(ConcreteCollection coll)
		{
			coll = this.coll;
		}
        public Student First()
		{
			current = 0;
			return coll.GetStudent(current);
		}
		public Student Next()
		{
			current += step;
			if (!IsCompleted)
			{
				return coll.GetStudent(current);
			}
			else
			{
				return null;
			}
		}
		public bool IsCompleted
		{
			get { return current >= coll.Count; }

		}
	}
}