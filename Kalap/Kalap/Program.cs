using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalap
{
    class Program
    {      
        static void Main(string[] args)
        {
            Kalap<string> kalap = new Kalap<string>();
            kalap.Push("Ükös Farkas"); // véletlenszerűen választott elemet eltávolít és megmutat
            kalap.Push("Fodor Dániel"); // véletlenszerűen választott elemet eltávolít és megmutat            
            Console.WriteLine($"Peek: {kalap.Peek()}"); // véletlenszerű elemet megmutat a kalapból
            Console.WriteLine($"Pop: {kalap.Pop()}"); // véletlenszerűen választott elemet eltávolít és megmutat
            Console.WriteLine(kalap); // megmutatja, hogy mi van a kalapban
            Console.WriteLine($"Count: {kalap.Count}"); // megmutatja, hogy hány elem van a kalapban, de a Count után ne kelljen zárójelet írni!
            Console.ReadKey();
        }
    }
}
