using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3._2
{
    internal class Adresse
    {

        public string vejNavn { get; set; }
        public int nummer { get; set; } 

        public Adresse(string vejNavn, int nummer)
        { 
            this.vejNavn = vejNavn;
            this.nummer = nummer;
        }

        public override string ToString()
        {
            return vejNavn + ", "+ nummer;
        }
    }
}
