using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ZpravodajskyPorad : IPorad
    {
        int r = 0;
        public double c = 0;
        public ZpravodajskyPorad(int reklamy, double cena)
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
            return ("Zpravodajstvi, rekalamy: " + r + ", cena: " + c);
        }
    }
}
