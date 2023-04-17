using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3._2
{
    internal class Mekaniker : Medarbejder
    {
        public int aarstal { get; set; }
        public int timeloen { get; set; }

        public Mekaniker(int medarbejderNummer, CprNr cprNr, string navn, Adresse adresse, int aarstal, int timeloen) 
            : base(medarbejderNummer, cprNr, navn, adresse)
        {
            this.aarstal= aarstal;
            this.timeloen= timeloen;
        }

        public override double BeregnUgeLøn()
        {
            return timeloen * TimerPrUge;
        }
        public override string ToString()
        {
            return  base.ToString();
        }

    }
}
