using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        object [] arr;
        int nextIndex;

        public Stack(int size)
        {
            arr = new object[size];
            nextIndex = 0;
        }

        public void Push(object a)
        {
            if(a==null)
            {
                throw new InvalidOperationException();
            }
            arr[nextIndex] = a;
            nextIndex++;
        }

        public object Pop()
        {
            if(nextIndex==0)
            {
                throw new InvalidOperationException();
            }
            object top = arr[nextIndex - 1];
            nextIndex--;
            return top;
        }

        public void Clear()
        {
            nextIndex = 0;
        }

    }
}
