using PW5;

Animal animal = new Animal();
animal.PrintInfo();
Console.WriteLine();

animal.Name = "Greg";
animal.Age = 3;
animal.GoToSleep();
animal.PrintInfo();

Console.WriteLine("--------------------");

Pet pet = new Pet("Dog", "Bobby", 0);
pet.PrintInfo();
Console.WriteLine();

pet.Play();
pet.Feed();
pet.PrintInfo();
Console.WriteLine();

pet.GoToSleep();
pet.Play();
pet.Feed();

Console.WriteLine("--------------------");

WildAnimal wildAnimal = new WildAnimal("Tiger", "Scher Khan", 8, "Jungle", 8);
wildAnimal.PrintInfo();
Console.WriteLine();

wildAnimal.Attack();
wildAnimal.Hide();
Console.WriteLine();

wildAnimal.PrintInfo();
wildAnimal.Attack();
