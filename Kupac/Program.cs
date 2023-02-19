using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10F_kupac
{
    class Program
    {
        static void Main(string[] args)
        {
            Kupac<int> qpac = new Kupac<int>((x, y) => x.CompareTo(y));

            
            foreach(var item in new List<int> {1,5,2,3,7,1,6 })
            {
                qpac.Push(item);
                Console.WriteLine(qpac);
            }

            while (!qpac.Empty())
            {
                Console.WriteLine($"Kiveszem a legnagyobb elemet,ez az: {qpac.Pop()}");
                Console.WriteLine(qpac);
            }



            Console.ReadKey();

        }
    }
}
