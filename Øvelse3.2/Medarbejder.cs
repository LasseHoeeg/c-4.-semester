using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3._2
{
    internal abstract class Medarbejder : IharAdresse
    {
        public string navn { get; set; }
        public Adresse adresse { get; set; }
        public CprNr cprNr { get; set; }

        public int medarbejderNummer { get; set; }

        private int timerPrUge = 37;
        
        public Medarbejder(int medarbejderNummer, CprNr cprNr, string navn, Adresse adresse) 
        {
            this.medarbejderNummer= medarbejderNummer;
            this.cprNr = cprNr;
            this.navn = navn;
            this.adresse = adresse;
        }

        public virtual double BeregnUgeLøn()
        {
            return 0.0;
        }
        public int TimerPrUge 
        {
            get { return timerPrUge; }
        }


        public override string ToString()
        {
            return navn + ", " + medarbejderNummer;
        }

        public Adresse Adresse()
        {
            return adresse;
        }
    }
}
