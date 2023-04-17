using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion01Intro
{
    internal class Person
    {

        private string fornavn;

        public Person(string fornavn) {
        this.fornavn = fornavn;
       
        }

        public string Navn
        {
            get
            {
                return fornavn;
            }
            set
            {
                fornavn = value;
            }
        }

        public override string ToString()
        {
            return this.fornavn;
        }

    }
}
