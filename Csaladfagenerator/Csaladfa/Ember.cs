using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csaladfa
{
    class Ember
    {
        public string keresztnev;
        public string vezeteknev;
        public bool fiue; //nem

        public Ember(string knev, string vnev, bool fiu)
        {
            keresztnev = knev;
            vezeteknev = vnev;
            fiue = fiu;
        }

        public override string ToString()
        {
            return $"\"{vezeteknev} {keresztnev}\"";
        }
    }
}