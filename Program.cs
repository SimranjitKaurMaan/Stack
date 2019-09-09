using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack(5);
            s.Push(10);
            s.Push(20);
            s.Push(30);
            Console.WriteLine(s.Pop());

            Console.WriteLine(s.Pop());
            s.Clear();
            Console.WriteLine(s.Pop());
            

        }
    }
}
