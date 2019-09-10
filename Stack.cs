using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T>
    {
        T [] arr;
        int nextIndex;

        public Stack(int size)
        {
            arr = new T[size];
            nextIndex = 0;
        }

        public void Push(T a)
        {
            if(a==null)
            {
                throw new InvalidOperationException();
            }
            arr[nextIndex] = a;
            nextIndex++;
        }

        public T Pop()
        {
            if(nextIndex==0)
            {
                throw new InvalidOperationException();
            }
            T top = arr[nextIndex - 1];
            nextIndex--;
            return top;
        }

        public void Clear()
        {
            nextIndex = 0;
        }

    }
}
