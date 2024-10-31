using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalap;
using System.IO;

namespace Csaladfa
{
    class Csalad
    {
        Kalap<string> lanynevek = new Kalap<string>();
        Kalap<string> fiunevek = new Kalap<string>();
        Kalap<string> vezeteknevek = new Kalap<string>();
        protected int hanygyerek;

        public List<Ember> gyerektelenek = new List<Ember>();

        Random rnd = new Random();

        public Csalad(Kalap<string> lnevek, Kalap<string> fnevek, Kalap<string> vnevek, int hgyerek = 3)
        {
            lanynevek = lnevek;
            fiunevek = fnevek;
            vezeteknevek = vnevek;
            hanygyerek = hgyerek+1;
        }
        
        protected void Tschalad()
        {
            int gyerekszam;
            Ember gyerek;
            Ember hazastars;

            Console.WriteLine("digraph G {");
            while (vezeteknevek.Count > 0 && gyerektelenek.Count > 0)
            {
                gyerekszam = rnd.Next(0, hanygyerek);
                hazastars = UjEmber(!gyerektelenek[0].fiue);                
                for (int i = 0; i < gyerekszam; i++)
                {
                    if (hazastars.fiue) { gyerek = Gyerek(hazastars.vezeteknev); }
                    else { gyerek = Gyerek(gyerektelenek[0].vezeteknev); }
                    Console.WriteLine($"{gyerektelenek[0]} -> {gyerek}");
                    Console.WriteLine($"{hazastars} -> {gyerek}");
                    gyerektelenek.Add(gyerek);
                }
                gyerektelenek.RemoveAt(0);
            }
            Console.Write("}");
        }

        #region Új emberek
        public Ember UjEmber(bool fiue)
        {
            Ember emb;
            if (fiue) { emb = new Ember(fiunevek.Pop(), vezeteknevek.Pop(), true); }
            else { emb = new Ember(lanynevek.Pop(), vezeteknevek.Pop(), false); }
            return emb;
        }
        protected Ember Gyerek(string veznev)
        {
            Ember emb;
            if (rnd.Next(0, 4) == 0) { emb = new Ember(fiunevek.Pop(), veznev, true); }
            else { emb = new Ember(lanynevek.Pop(), veznev, false); }
            return emb;
        }
        #endregion

        public override string ToString()
        {            
            Tschalad();
            return "";
        }
    }
}