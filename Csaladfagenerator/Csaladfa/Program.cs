using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Kalap;

namespace Csaladfa
{
    class Program
    {       
        public static void Beolvasas(string input, Kalap<string> kalap)
        {
            StreamReader r = new StreamReader(input, Encoding.UTF8);
            while (!r.EndOfStream) { kalap.Push(r.ReadLine()); }
            r.Close();
        }

        static void Main(string[] args)
        {
            #region Kalapok feltöltése
            Kalap<string> lanynevek = new Kalap<string>();
            Beolvasas("soklanynev.txt", lanynevek);
            Kalap<string> fiunevek = new Kalap<string>();
            Beolvasas("sokfiunev.txt", fiunevek);
            Kalap<string> vezeteknevek = new Kalap<string>();
            Beolvasas("veznev.txt", vezeteknevek);
            #endregion

            Csalad aCsalad = new Csalad(lanynevek, fiunevek, vezeteknevek, 3);
                       
            Ember Adam = aCsalad.UjEmber(true);
            aCsalad.gyerektelenek.Add(Adam);

            Console.Write(aCsalad);

            Console.ReadKey();
        }
    }
}