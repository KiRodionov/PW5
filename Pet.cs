using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW5
{
    internal class Pet : Animal
    {
        // Свойства
        public string Owner { get; set; }
        public int HappinesLevel { get; private set; }
        
        public Pet(string species, string name, int age, string owner = "Kirill")
        {
            Species = species;
            Name = name;
            Age = age;
            Owner = owner;
            HappinesLevel = 0;
        }
        //Методы
        public void Feed()
        {
            if (Status == AnimalStatus.Active) { 
                HappinesLevel++;
                Console.WriteLine("{0} was feed, happiness level:{1}", Name, HappinesLevel);
            }
            else
            {
                Console.WriteLine("{0} is sleeping now", Name);
            }
        }

        public void Play()
        {
            if (Status == AnimalStatus.Active)
            {
                HappinesLevel += 2;
                Console.WriteLine("{0} played, happiness level:{1}", Name, HappinesLevel);
            }
            else
            {
                Console.WriteLine("{0} is sleeping now", Name);
            }
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Owner: {0}", Owner);
            Console.WriteLine("Happiness level: {0}", HappinesLevel);
        }
    }
}
