using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace PripravaNaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TelevizniKanal kanal = new TelevizniKanal(6);
            kanal[0] = new ZpravodajskyPorad(1, 1000.0);
            kanal[2] = new FilmovyPorad(2, 4560.0);
            kanal[3] = new FilmovyPorad(10, 2000.00);
            kanal[5] = new ZpravodajskyPorad(0, 0.0);

            Console.WriteLine(kanal);
            Console.ReadKey();
        }
    }
}
