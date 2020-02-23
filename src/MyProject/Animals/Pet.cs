namespace MyProject.Animals
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public abstract string Speak();
    }
}