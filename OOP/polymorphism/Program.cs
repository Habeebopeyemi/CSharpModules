class Animal{
    public virtual void AnimalSound(){ Console.WriteLine("The animal makes a sound"); }
}

class Pig : Animal{
    public override void AnimalSound(){ Console.WriteLine("The pig says: wee wee"); }
}

class Dog : Animal{
    public override void AnimalSound(){ Console.WriteLine("The dog says: bow bow"); }
}

public class Program{
    private static void Main(string[] args){
        Animal smallAnimal = new Animal();
        Dog smallDog = new Dog();
        Pig smallPig = new Pig();

        smallAnimal.AnimalSound();
        smallPig.AnimalSound();
        smallDog.AnimalSound();
    }
}