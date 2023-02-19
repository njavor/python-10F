using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris_fak_10F
{
    class Program
    {
        class BinarisFa<T>
        {
            public T gyoker { get; set; }
            public BinarisFa<T> bal { get; set; }
            public BinarisFa<T> jobb { get; set; }
        }
        static void Main(string[] args)
        {
            BinarisFa<int> fa = new BinarisFa<int>();
            fa.gyoker = 3;
            
            BinarisFa<int> fa2 = new BinarisFa<int>();
            fa.gyoker = 10;


            BinarisFa<int> fa3 = new BinarisFa<int>();
            fa.gyoker = 9;
            fa3.bal = fa;
            fa3.jobb = fa2;
        }
    }
}
