using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3._2
{
    internal class CprNr
    {
        private string birthDate { get; set; }
        private string sequenceNumber { get; set; }



        public CprNr(string bDate, string sNumber) 
        {
            birthDate = bDate;
            sequenceNumber = sNumber;
        }
    }
}
