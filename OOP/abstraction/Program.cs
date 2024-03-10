
abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void AnimalSound();

    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

class Pig : Animal{
    public override void AnimalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program{
    static void Main(string[] args){
        Pig nPig = new Pig();
        nPig.AnimalSound();
        nPig.sleep();
    }
}