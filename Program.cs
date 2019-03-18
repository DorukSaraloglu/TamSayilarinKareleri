using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamSayilarinKareleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Kareler f = new Kareler();
            foreach(int n in f)
            {
                Console.WriteLine(n);
                System.Threading.Thread.Sleep(200);
            }
            Console.ReadKey();
        }
        class Kareler : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                return new KareEnumerator();
            }
        }
        class KareEnumerator : IEnumerator
        {
            private int currentNumber;
            public KareEnumerator()
            {
                Reset();
            }
            public object Current { get { return currentNumber * currentNumber; } }
            public bool MoveNext()
            {
                ++currentNumber;
                return true;
            }
            public void Reset()
            {
                currentNumber = 0;
            }
        }
    }
}
