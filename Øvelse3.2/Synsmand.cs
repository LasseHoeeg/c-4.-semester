using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3._2
{
    internal class Synsmand : Mekaniker
    {
        public int antalSyn { get; set; }

        public Synsmand(int medarbejderNummer, CprNr cprNr, string navn, Adresse adresse, int aarstal, int timeloen, int antalSyn)
            : base(medarbejderNummer, cprNr, navn, adresse, aarstal, timeloen)
        {
        this.antalSyn = antalSyn;
        }

        public override double BeregnUgeLøn()
        {
            return timeloen * TimerPrUge + antalSyn * 290;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
