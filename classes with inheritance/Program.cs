using classes_with_inheritance;
using static System.Runtime.InteropServices.JavaScript.JSType;

Animal animal1 = new Animal();
animal1.Name = "Simba";
Console.WriteLine(animal1.Name+" "+animal1.Eat());

Dog dog1 = new Dog();
dog1.Name = "Tomy";
Console.WriteLine(dog1.Name + " " + dog1.Eat());

Cat cat1 = new Cat();
cat1.Name = "Kimmy";
Console.WriteLine(cat1.Name + " " + cat1.Eat());
