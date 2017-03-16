using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegat
{
    
    
    class Librarian
    {
        public delegate int myFn(string title);
        string fname;
        string lname;
        myFn cena;
        public Librarian(string fname, string lname, myFn cena)
        {
            this.cena = cena;
            this.Fname = fname;
            this.Lname = lname;
        }
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                this.fname = value;
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                this.lname = value;
            }
        }
        public void AddedBook(string title)
        {
            Console.WriteLine(fname + " " + lname + ", pridana kniha: " + title + " - " + cena(title) + " ,-");
        }
       
    }
}
