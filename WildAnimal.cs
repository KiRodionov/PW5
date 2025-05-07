using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW5
{
    internal class WildAnimal : Animal
    {
        //Свойства
        public string Habitat { get; set; }
        public int DangerLevel { get; set; }

        public WildAnimal(string species, string name, int age, string habitat, int dangerLevel)
        {
            Species = species;
            Name = name;
            Age = age;
            Habitat = habitat;
            DangerLevel = dangerLevel;
        }
        //Методы
        public void Attack()
        {
            if (Status == AnimalStatus.Active && DangerLevel >= 5)
            {
                Console.WriteLine("Animal attacks!!!");
            }
            else
            {
                Console.WriteLine("Safety");
            }
        }

        public void Hide()
        {
            Status = AnimalStatus.Sleep;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Habitat: {0}", Habitat);
            Console.WriteLine("Dangerous Level: {0}", DangerLevel);
        } 
    }
}
