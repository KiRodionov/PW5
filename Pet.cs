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
        public string Owner { get; set; } = "Kirill";
        public int HappinessLevel { get; private set; }
        
        public Pet(string species, string name, int age, string owner )
            :base(species, name, age)
        {
            Owner = owner;
            HappinessLevel = 0;
        }
        //Методы
        public void Feed()
        {
            if (Status == AnimalStatus.Active) { 
                HappinessLevel++;
                Console.WriteLine("{0} was feed, happiness level:{1}", Name, HappinessLevel);
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
                HappinessLevel += 2;
                Console.WriteLine("{0} played, happiness level:{1}", Name, HappinessLevel);
            }
            else
            {
                Console.WriteLine("{0} is sleeping now", Name);
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Owner: {0}", Owner);
            Console.WriteLine("Happiness level: {0}", HappinessLevel);
        }
    }
}
