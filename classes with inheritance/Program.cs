using classes_with_inheritance;
using static System.Runtime.InteropServices.JavaScript.JSType;

Animal animal1 = new Animal();
animal1.Name = "Simba";

Dog dog1 = new Dog();
dog1.Name = "Tomy";
dog1.Eat();

Cat cat1 = new Cat();
cat1.Name = "Kimmy";
cat1.Eat();