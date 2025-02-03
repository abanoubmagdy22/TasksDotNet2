namespace ChallengePolymorphism
{
    internal class Program
    {
        class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public virtual string AnimalSound()
            {
                return "The animal makes a sound";
            }
        }
        //class pig child
        class Pig : Animal
        {
            public string Size { get; set; }

            public override string AnimalSound()
            {
                return "The pig says: wee wee";
            }
        }

        //  class Dog child
        class Dog : Animal
        {
            public override string AnimalSound()
            {
                return "The dog says: bow wow";
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Animal myAnimal = new Animal();     
            Animal myPig = new Pig();           
            Animal myDog = new Dog();        

            Console.WriteLine(myAnimal.AnimalSound()); 
            Console.WriteLine(myPig.AnimalSound());    
            Console.WriteLine(myDog.AnimalSound());
        }
    }
}
