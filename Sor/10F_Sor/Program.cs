using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _10F_Sor
{
    class Program
    {
        static void Main(string[] args)
        {
            /** /
            Queue<int> sor = new Queue<int>();
            sor.Enqueue(5); // ez a push
            int a = sor.Dequeue();  //ez a pop
            sor.Peek();
            /**/


            Sor<int> sor = new Sor<int>();
            sor.Enqueue(3);
            sor.Enqueue(5);
            sor.Enqueue(2);
            sor.Enqueue(1);
            sor.Enqueue(10);


            Console.WriteLine(sor);
            sor.Dequeue();
            Console.WriteLine(sor);
            sor.Dequeue();
            Console.WriteLine(sor);
            sor.Dequeue();
            Console.WriteLine(sor);
            sor.Dequeue();
            Console.WriteLine(sor);



        }
    }
}
