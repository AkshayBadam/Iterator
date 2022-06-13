using System;
namespace Iterate
{
    interface AbstractIterator
    {
        public Student First();
        public Student Next();
        bool IsCompleted { get; }
    }
}