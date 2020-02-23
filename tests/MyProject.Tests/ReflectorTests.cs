using MyProject.Animals;
using NUnit.Framework;

namespace MyProject.Tests
{
    public class ReflectorTests
    {
        [Test]
        public void GetPropertyValue_can_return_Cat_Name()
        {
            var cat = new Cat {Name = "Purdy"};

            var result = Reflector.GetPropertyValue<string>(cat, "Name");
            
            Assert.AreEqual(cat.Name, result);
        }
        
        [Test]
        public void GetPropertyValue_can_return_Cat_Age()
        {
            var cat = new Cat {Age = 3};

            var result = Reflector.GetPropertyValue<int>(cat, "Age");
            
            Assert.AreEqual(cat.Age, result);
        }
        
        [Test]
        public void GetPropertyValue_can_return_Cat_AllowedOutside()
        {
            var cat = new Cat {AllowedOutside = true};

            var result = Reflector.GetPropertyValue<bool>(cat, "AllowedOutside");
            
            Assert.AreEqual(cat.AllowedOutside, result);
        }
        
        [Test]
        public void GetPropertyValue_can_return_Dog_Name()
        {
            var dog = new Dog {Name = "Patches"};

            var result = Reflector.GetPropertyValue<string>(dog, "Name");
            
            Assert.AreEqual(dog.Name, result);
        }
        
        [Test]
        public void GetPropertyValue_can_return_Dog_Age()
        {
            var dog = new Dog {Age = 7};

            var result = Reflector.GetPropertyValue<int>(dog, "Age");
            
            Assert.AreEqual(dog.Age, result);
        }
        
        [Test]
        public void GetPropertyValue_can_return_Dog_AgeInDogYears()
        {
            var dog = new Dog {Age = 7};

            var result = Reflector.GetPropertyValue<int>(dog, "AgeInDogYears");
            
            Assert.AreEqual(49, result);
        }

        [Test]
        public void InvokeMethod_can_return_Cat_Speak()
        {
            var cat = new Cat();

            var result = Reflector.InvokeMethod<string>(cat, "Speak");
            
            Assert.AreEqual("Meow", result);
        }

        [Test]
        public void InvokeMethod_can_return_Dog_Speak()
        {
            var dog = new Dog();

            var result = Reflector.InvokeMethod<string>(dog, "Speak");
            
            Assert.AreEqual("Woof", result);
        }

        [Test]
        public void GetBaseClassName_returns_base_class_for_Cat()
        {
            var cat = new Cat();

            var result = Reflector.GetBaseClassName(cat);
            
            Assert.AreEqual("Pet", result);
        }
        
        [Test]
        public void GetBaseClassName_returns_base_class_for_Dog()
        {
            var dog = new Dog();

            var result = Reflector.GetBaseClassName(dog);
            
            Assert.AreEqual("Pet", result);
        }
    }
}