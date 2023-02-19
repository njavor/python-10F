using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalap
{
    class Kalap<T>
    {
        private List<T> list = new List<T>();
        private Random rnd = new Random();

        public Kalap() { }
        
        public int Count => list.Count();
        public void Push(T item) => list.Add(item);
        public T Pop()
        {
            int adott = rnd.Next(0, list.Count());
            T elem = list[adott];
            list.RemoveAt(adott);
            return elem;
        }
        public T Peek() => list[rnd.Next(0, list.Count())];

        public override string ToString()
        {
            Console.WriteLine("\nKalap elemei:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            return "";
        }
    }
}
