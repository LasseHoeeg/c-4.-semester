using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Øvelse3._2
{
    internal class MedarbejderList<TKey, MKey>
    {
        private readonly Dictionary<TKey, MKey> collection = new Dictionary<TKey,
MKey>();


        
        public void AddElement(TKey k, MKey p) //Sætter en medarbejder ind på en specifik plads.
        {
            if (!collection.ContainsKey(k))
            {
                collection[k] = p;
            }
            else
            {
                //throw new Exception("Plads er optaget");
                Console.WriteLine("Plads er optaget");
            }
        }
        public MKey GetElement(TKey k)
        {
            return collection[k];
        }

        public int Size()
        {
            return collection.Count; //Auto-genereret
        }

    }
}
