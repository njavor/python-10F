using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszerek
{
    struct Termeszetes
    {
        static readonly byte p = 5; //pontosság
        static readonly Dictionary<char, sbyte> keydictionary = new Dictionary<char, sbyte>
        {
            {'1' , 1 },
            {'2' , 2 },
            {'3' , 3 },
            {'4' , 4 },
            {'5' , 5 },
            {'6' , 6 },
            {'7' , 7 },
            {'8' , 8 },
            {'9' , 9 },
            {'A' , 10 },
            {'B' , 11 },
            {'C' , 12 },
            {'D' , 13 },
            {'E' , 14 },
            {'F' , 15 },
        };
        static readonly string inverzjelszotar = "0123456789AB";

        public sbyte[] t; //számjelek tömbje
        public byte h; // ált hossz;
        public byte sz; //számrendszer

        public Termeszetes(byte h_in, sbyte[] t_in, byte sz_in)
        {
            t = t_in;
            h = h_in;
            sz = sz_in;
        }
        public Termeszetes(string input, byte numsystem = 10) : this((byte)input.Length, new sbyte[p], numsystem)
        {
            for (int i = input.Length - 1; i >= 0; i--) { t[input.Length - 1] = keydictionary[input[i]]; }
        }

        public Termeszetes(int i, byte numsystem = 10)
        {

        }     



        public override string ToString()
        {
            string sum = "";
            for (int i = p-1; i >= 0; i--) { sum += inverzjelszotar[t[i]].ToString(); }
            return sum;
        }
    }
}