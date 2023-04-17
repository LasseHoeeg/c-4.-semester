using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4._2
{

    public delegate void Warning();
    internal class Powerplant
    {
       private Warning warning;
     

        public void SetWarning(Warning wa) {
            warning = wa;
        }

        public void addWarning(Warning wa)
        {
            warning += wa;
        }

        public void heatUp()
        {
            Random random = new Random();
            int tal = random.Next(100);
            if (tal > 50)
            {
                Console.WriteLine(tal);
                warning.Invoke();

            }
        }

        public void CoolDown()
        {
            Random random = new Random();
            int tal = random.Next(100);
            if (tal < 50)
            {
                Console.WriteLine(tal);
                warning.Invoke();

            }
        }








    }
}
