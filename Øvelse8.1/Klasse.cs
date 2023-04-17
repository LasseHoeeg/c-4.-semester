using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse8._1
{
    [Table("Klasse")]
    public class Klasse
    {

        public int KlasseId { get; set; }
        public string Aargang { get; set; }
        public string KlasseNavn { get; set; }  

        public Klasse(string aargang, string KlasseNavn) { 
            this.Aargang = aargang;
            this.KlasseNavn = KlasseNavn;
        
        }

        public Klasse() 
        {
        }

        public override string ToString()
        {
            return KlasseNavn;
        }



    }
}
