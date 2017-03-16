using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegat
{
    class Program
    {
        public static int Cena(string title)
        {
            int res = 0;
            res = title.Length * 27;
            return res;
        }
        /*public delegate void MyDelegate(int a, int b);
        public static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Diff(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static int Execute(MyDelegate fn, int a, int b)
        {
            return fn(a, b);
        }*/
        static void Main(string[] args)
        {
            Library library = new Library();
            Librarian pepa = new Librarian("pepa", "chytry", Cena);

            library.BookAdded += pepa.AddedBook;

            library.Add(new Book("Kniha 1"));
            //MyDelegate myFn;
            //myFn = Sum;
            //myFn += Diff;

            //myFn -= Sum;

            //myFn(1, 2);
            Console.ReadKey();
        }
    }
}
