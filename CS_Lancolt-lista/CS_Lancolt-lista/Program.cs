using System;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lancolt_lista
{
    class Program
    {
        class LancoltLista
        {
            private class Elem
            {
                public Elem bal;
                public int ertek;
                public Elem jobb;

                public Elem(Elem b, int e, Elem j)
                {
                    this.bal = b;
                    this.jobb = j;
                    this.ertek = e;
                }
                public Elem() // hozza létre ez a fejelemet
                {
                    bal = this;
                    jobb = this;
                }

                public Elem(Elem ezele, int e)
                {
                    this.jobb = ezele;
                    this.bal = ezele.bal;
                    ezele.bal.jobb = this;
                    ezele.bal = this;
                    this.ertek = e;
                }
            }
            Elem fejelem = new Elem();
            private int count = 0;


            public int Count { get { return count; } }

            /** /  hosszú
             
            int count;

            int count2 { get; set; }    //auto-implemented property

            Régen használták""
            public int GetCount() => count;

            public void SetCount(int ertek)
            {
                count = ertek;
            }
            /** /
            
            ""

            public int Count    
            {
                get
                {
                    Console.WriteLine("lekérdezték a számosságot");
                    return count;
                }
                /** /
                set
                {
                    Console.WriteLine("átírták a számosságot!!!");
                    count = value;
                }
                /** /
            } 

            /**/

            private Elem Helye(int e)
            {
                Elem aktelem = fejelem.jobb; // "i = 0"
                while (aktelem != fejelem && aktelem.ertek != e) // i < lista.count && feltétel
                {
                    aktelem = aktelem.jobb; // "i++"
                }
                return aktelem;
            }

            private Elem GetElemByIndex(int i)
            {
                if (i < 0)
                {
                    Console.WriteLine("pozitív indexet kérek!");
                    throw new IndexOutOfRangeException();
                }
                if (count < 0)
                {
                    Console.WriteLine("túl nagy index!");
                    throw new IndexOutOfRangeException();
                }
                Elem aktelem = fejelem.jobb;
                for (int j = 0; j < i; j++)
                {
                    aktelem = aktelem.jobb;
                }
                return aktelem;
            }





            public void Add(int szam)
            {
                new Elem(fejelem, szam); // emlékezzünk: a fejelem előtt elem mindig az utolsó elem!
                count++;
            }        
            public bool Empty() => fejelem.jobb == fejelem; 
            
            /// <summary>
            /// Első előfordulást kiszedi
            /// </summary>
            /// <param name="ertek">az eltávolítandó elem</param>
            public void Remove(int e)
            {
                if (!Empty())
                {
                    Elem aktelem = Helye(e);
                    aktelem.bal.jobb = aktelem.jobb;
                    aktelem.jobb.bal = aktelem.bal;
                    count--;
                }
            }
            public bool Contains(int e) => Helye(e) != fejelem;


            public void SetByIndex(int i, int e) => GetElemByIndex(i).ertek = e;
            //public int GetByIndex(int i) => GetElemByIndex(i).ertek;


            public int this[int i]
            {
                get => GetElemByIndex(i).ertek;
                set => GetElemByIndex(i).ertek = value;                
            }


            public void Kiir() { Console.WriteLine(this.ToString()); }
            public override string ToString()
            {
                string str = "";
                Elem aktelem = fejelem.jobb;
                while (aktelem != fejelem)
                {
                    str += $"{aktelem.ertek} ";
                    aktelem = aktelem.jobb;
                }
                return str;
            }



        }


        
        static void Main(string[] args)
        {
            #region Nem kell(?)
            /** /
            Elem f = new Elem();
            Elem e1 = new Elem();
            Elem e2 = new Elem();
            Elem e3 = new Elem();

            f.bal = e3;
            f.jobb = e1;

            e1.bal = f;
            e1.ertek = 2;
            e1.jobb = e2;

            e2.bal = e1;
            e2.ertek = 3;
            e2.jobb = e3;

            e3.bal = e2;
            e3.ertek = 5;
            e3.jobb = f;


            Console.WriteLine(f.jobb.jobb.jobb.ertek);
            Console.WriteLine();

            //----------------------------


            //új elemet adunk hozzá
            Elem e4 = new Elem(e3,8,f);
            /** /
            e4.ertek = 8;
            e4.bal = e3;
            e4.jobb = f;
            e3.jobb = e4;
            f.bal = e4;
            /** /


            Elem e5 = new Elem(e4, 13); // e4 elé szúrjuk be a 13 tartalmú dolgot


            Console.WriteLine(f.ertek);
            Console.WriteLine(f.jobb.ertek);
            Console.WriteLine(f.jobb.jobb.ertek);
            Console.WriteLine(f.jobb.jobb.jobb.ertek);
            Console.WriteLine(f.jobb.jobb.jobb.jobb.ertek);
            Console.WriteLine(f.jobb.jobb.jobb.jobb.jobb.ertek);
            Console.WriteLine(f.jobb.jobb.jobb.jobb.jobb.jobb.ertek);
            /**/
            #endregion

            LancoltLista lista = new LancoltLista();

            lista.Add(5);
            lista.Add(6);
            lista.Add(7);
            lista.Add(1);

            lista.Kiir();

            Console.WriteLine("[ " + lista + "]");


            //lista.Count = 100;
            int valtozo = lista.Count;

            Console.WriteLine(valtozo);

            lista.Remove(5);

            Console.WriteLine(lista);
            Console.WriteLine(lista.Count);

            lista.Remove(6);

            Console.WriteLine(lista);
            Console.WriteLine(lista.Count);

            int ez = 1;
            Console.WriteLine($"A(z) {ez} elem benne van? {lista.Contains(ez)}");

            int i = 2;
            Console.WriteLine($"A lista {i}. eleme {lista.GetByIndex(i)}");

        }

    }
}
