using System;
namespace _10F_Sor
{
    class Sor<T>
    {
        private class Elem<R>
        {
            public Elem<R> bal;
            public R ertek;
            public Elem<R> jobb;
            public Elem(Elem<R> b, R e, Elem<R> j)
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
            public Elem(Elem<R> ezele, R e)
            {
                this.jobb = ezele;
                this.bal = ezele.bal;
                ezele.bal.jobb = this;
                ezele.bal = this;
                this.ertek = e;
            }
            public static Elem<R> operator ++(Elem<R> a) => a.jobb;
            public static Elem<R> operator --(Elem<R> a) => a.bal;
            public void Torolmogule()
            {                
                this.jobb = this.jobb.jobb;
                this.jobb.bal= this;
            }
        }
        Elem<T> fejelem = new Elem<T>();
        private int count = 0;
        public int Count { get { return count; } }
        public void Kiir() { Console.WriteLine(this.ToString()); }
        public override string ToString()
        {
            string str = "";
            Elem<T> aktelem = fejelem.jobb;
            while (aktelem != fejelem)
            {
                str += $"{aktelem.ertek} ";
                aktelem = aktelem.jobb;
            }
            return "[ " + str + "]";
        }
        public bool Empty() => fejelem.jobb == fejelem;

        public void Enqueue(T ertek) => new Elem<T>(fejelem, ertek);
        public T Peek() => fejelem.jobb.ertek;
        public T Dequeue()
        {
            T result = Peek();
            fejelem.Torolmogule();
            if (!Empty()) count--;
            return result;
        }



    }
}
