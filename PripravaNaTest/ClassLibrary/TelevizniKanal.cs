using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TelevizniKanal
    {
        public IPorad[] plan;
        public TelevizniKanal(int n = 10)
        {
            this.plan = new IPorad[n];
        }

        public IPorad this[int n]
        {
            get
            {
                return this.plan[n];
            }
            set
            {
                if ((n >= this.plan.Length))
                {
                    throw new IndexOutOfRangeException();
                }
                else this.plan[n] = value;
            }
        }

        public double Zisk()
        {
            double z = 0.0;
            for (int i = 0; i < plan.Length; i++)
            {
                if (plan[i]!=null)
                {
                    z = z + (plan[i].Cena * plan[i].Reklamy);
                }
            }
            return z;
        }

        public override string ToString()
        {
            for (int i = 0; i < plan.Length; i++)
            {
                if (plan[i]==null)
                {
                    Console.WriteLine("Nenastaveno");
                }
                else
                {
                    Console.WriteLine(plan[i].ToString());
                }
            }
            return "Celkovy zisk: " + Zisk();
        }
    }
}
