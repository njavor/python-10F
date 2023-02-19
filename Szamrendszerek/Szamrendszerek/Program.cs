using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszerek
{
    class Program
    {
        static void Main(string[] args)
        {
            Termeszetes sz1 = new Termeszetes(5,new sbyte[5]{0,0,3,4,5},10);
            Termeszetes sz2 = new Termeszetes(65432);
            Termeszetes sz3 = new Termeszetes("65432");
            
            
            Termeszetes sz4 = new Termeszetes("A", 16);
            Termeszetes sz5 = new Termeszetes(65432, 12);



            Console.WriteLine(sz4);
        }
    }
}
