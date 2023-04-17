using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse8._1
{
    [Table("Person")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public string LastName { get; set; } //opg 8.2

        public Klasse Klasse { get; set; }

        public int Fk { get; set; }

        public Person()
        {
        }

        public Person(string name, string age, Klasse klasse)
        {
            Name = name;
            Age = age;
            LastName = "Jensen";
            Klasse = klasse;
        }

        public override string ToString()
        {
            return Name + " " + LastName + " " + Age + " " + Klasse.KlasseNavn;
        }


    }
}
