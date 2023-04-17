using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse7._4
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private string age;
        private string weight;
        private string score;
        private bool accepted;
        public string Name
        {
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
            get { return name; }
        }
        public string Age {
            set
            {
                age = value;
                NotifyPropertyChanged("Age");
            }
            get { return age; }
        }
        public string Weight {
            set
            {
                weight = value;
                NotifyPropertyChanged("Weight");
            }
            get { return weight; }
        }
        public string Score
        {
            set
            {
                score = value;
                NotifyPropertyChanged("Score");
            }
            get { return score; }
        }
        public bool Accepted
        {
            set
            {
                accepted = value;
                NotifyPropertyChanged("Accepted");
            }
            get { return accepted; }
        }

        public Person(string name, string age, string weight, string score, bool accepted)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Score = score;
            this.Accepted = accepted;

        }

        public override string  ToString()
        {
            return "Navn: " + Name +", Score: " + Score;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)  //er vist ikke nødvendigt
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
