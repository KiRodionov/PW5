using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW5
{
    public enum AnimalStatus
    {
        Active,
        Sleep
    }
    internal class Animal
    {
       //Свойства
        public string Species { get; set; } = "Cat";
        public string Name { get; set; } = "Bobik";
        public int Age { get; set; } = 0;
        public AnimalStatus Status { get; protected set; } = AnimalStatus.Active;

        //Конструкторы
        public Animal() { }
        public Animal(string species, string name, int age)
        {
            Species = species;
            Name = name;
            Age = age;
            Status = AnimalStatus.Active;
        }
        //Методы
        public void WakeUp()
        {
            Status = AnimalStatus.Active;
        }
        public void GoToSleep()
        {
            Status |= AnimalStatus.Sleep;
        }

        public void MakeSound()
        {
            Console.WriteLine("Some Sound");
        }
        public void PrintInfo()
        {
            Console.WriteLine("Species: {0}", Species);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Status: {0}",Status);
        }
    }
}
