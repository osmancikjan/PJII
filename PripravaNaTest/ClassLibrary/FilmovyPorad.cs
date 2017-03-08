using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FilmovyPorad : IPorad
    {
        double c;
        int r;

        public FilmovyPorad(int reklamy, double cena)
        {
            Cena = cena;
            Reklamy = reklamy;
        }
        public double Cena
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public int Reklamy
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
            }
        }
        public override string ToString()
        {
            return ("Film, rekalamy: " + r + ", cena: " + c);
        }
    }
}
