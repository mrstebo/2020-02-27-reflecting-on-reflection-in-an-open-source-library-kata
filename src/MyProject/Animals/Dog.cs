namespace MyProject.Animals
{
    public class Dog : Pet
    {
        public int AgeInDogYears => Age * 7;
        
        public override string Speak()
        {
            return "Woof";
        }
    }
}