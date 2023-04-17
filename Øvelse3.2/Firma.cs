using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3._2
{
    internal class Firma : IharAdresse
    {
        public Adresse adresse { get; set; }

        public Firma(Adresse adresse) 
        { 
        this.adresse = adresse; 
        }

        public Adresse Adresse()
        {
            return adresse;
        }

        public override string ToString() //Fungerer ikke
        {
            return adresse.ToString();
        }
    }
}
