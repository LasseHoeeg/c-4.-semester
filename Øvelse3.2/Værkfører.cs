using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3._2
{
    internal class Værkfører : Mekaniker
    {
        public int aar { get; set; }
        public int tillaeg { get; set; }

        public Værkfører(int medarbejderNummer, CprNr cprNr, string navn, Adresse adresse, int aarstal, int timeloen, int aar, int tillaeg) 
            : base(medarbejderNummer, cprNr, navn, adresse, aarstal, timeloen)
        {
            this.aar = aar;
            this.tillaeg = tillaeg;
        }

        public override double BeregnUgeLøn()
        {
            return timeloen * TimerPrUge + tillaeg;
        }

        public override string ToString()
        {
            return base.ToString();
        }




    }
}
