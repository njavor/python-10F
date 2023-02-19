using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10F_kupac
{
    class Kupac<T>
    {
        class Lista<R>
        {
            List<R> list = new List<R>();

            public void Add(R elem) => list.Add(elem);
            public void RemoveLast() => list.RemoveAt(list.Count - 1);
            public R this[int i]
            {
                get => list[i - 1];
                set => list[i - 1] = value;
            }
            public override string ToString()
            {
                string sum = "[";
                foreach (R item in list)
                {
                    sum += " " + item;
                }
                return sum + "]";
            }
            public int Count { get => list.Count;}
        }


        Lista<T> lista = new Lista<T>();
        
        Func<T, T, int> relacio;
        public Kupac(Func<T,T,int> r) {this.relacio = r;}


        #region Private methods
        private int Szülő(int i) => i / 2;        
        private int Gyerekek(int parent, out int gyerek1, out int gyerek2)
        {
            gyerek1 = 0;
            gyerek2 = 0;
            int gyerekszám = 0;
            if(2*parent <= lista.Count)
            {
                gyerek1 = 2 * parent;
                gyerekszám = 1;
                if(2*parent+1 <= lista.Count)
                {
                    gyerek1 = 2 * parent+1;
                    gyerekszám = 2;
                }
            }
            return gyerekszám;
        }
        private void Csere(int i, int j) => (lista[i], lista[j]) = (lista[j], lista[i]);
        private bool Gyökér(int i) => i == 0;
        private void MOLBubi(int gyerek)
        {
            while (!Gyökér(gyerek) && relacio(lista[gyerek],lista[Szülő(gyerek)])==1)
            {
                Csere(gyerek, Szülő(gyerek));
                gyerek = Szülő(gyerek);
            }
        }
        private bool Idősebb_gyerek(int parent, out int idősebb_gyerek)
        {
            int gyerek1;
            int gyerek2;
            int gyerekszám = Gyerekek(parent, out gyerek1, out gyerek2);

            switch (gyerekszám)
            {
                case 0:
                    idősebb_gyerek = 0;
                    return false;
                case 1:
                    idősebb_gyerek = gyerek1;
                    return true;
                case 2:
                    idősebb_gyerek = relacio(lista[gyerek1], lista[gyerek2]) == -1 ? gyerek2 : gyerek1;
                    return true;
                default:
                    idősebb_gyerek = 0;
                    return true;
            }

        }
        private void Süllyesztés()
        {
            int parent = 1;
            bool vanegyerek = Idősebb_gyerek(parent, out int idősebb_gyerek);            
            if (vanegyerek)
            {
                while (vanegyerek && relacio(lista[parent], lista[idősebb_gyerek]) == -1)
                {
                    Csere(parent, idősebb_gyerek);
                    parent = idősebb_gyerek;
                    vanegyerek = Idősebb_gyerek(parent, out idősebb_gyerek);
                }
            }
            int i = 1;
        }
        #endregion

        #region Public methods
        public void Push(T elem)
        {
            lista.Add(elem);
            MOLBubi(lista.Count);
        }
        public T Pop()
        {
            Csere(1, lista.Count);
            T result = lista[lista.Count];
            lista.RemoveLast();
            Süllyesztés();
            return result;
        }
        public bool Empty() => lista.Count == 0;

        public override string ToString() => lista.ToString();

        #endregion
    }
}
