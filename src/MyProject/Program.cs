using System;
using MyProject.Animals;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectCat();
            ReflectDog();
        }

        private static void ReflectCat()
        {
            var cat = new Cat {Name = "Purdy", Age = 3, AllowedOutside = true};
            
            Console.WriteLine("Reflecting the Cat");
            Console.WriteLine("Name: {0}", Reflector.GetPropertyValue<string>(cat, "Name"));
            Console.WriteLine("Age: {0}", Reflector.GetPropertyValue<int>(cat, "Age"));
            Console.WriteLine("AllowedOutside: {0}", Reflector.GetPropertyValue<bool>(cat, "AllowedOutside"));
            Console.WriteLine("{0} says '{1}'", cat.Name, Reflector.InvokeMethod<string>(cat, "Speak"));
        }

        private static void ReflectDog()
        {
            var dog = new Dog {Name = "Patches", Age = 7};
            
            Console.WriteLine("Reflecting the Dog");
            Console.WriteLine("Name: {0}", Reflector.GetPropertyValue<string>(dog, "Name"));
            Console.WriteLine("Age: {0}", Reflector.GetPropertyValue<int>(dog, "Age"));
            Console.WriteLine("AgeInDogYears: {0}", Reflector.GetPropertyValue<int>(dog, "AgeInDogYears"));
            Console.WriteLine("{0} says '{1}'", dog.Name, Reflector.InvokeMethod<string>(dog, "Speak"));
        }
    }
}