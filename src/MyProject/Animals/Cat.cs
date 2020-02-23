namespace MyProject.Animals
{
    public class Cat : Pet
    {
        public bool AllowedOutside { get; set; }
        
        public override string Speak()
        {
            return "Meow";
        }
    }
}