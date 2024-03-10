interface IAnimal{
    void AnimalSound();
    void run();
}

interface IFirstInterface{
    void MyMethod();
}

interface ISecondInterface{
    void MyOtherMethod();
}

class Pig : IAnimal{
    public void AnimalSound(){
        Console.WriteLine("The pig says: wee wee");
    }

    public void run(){
        Console.WriteLine("I am running, yahh!!!");
    }
}

class MultipleInterface : IFirstInterface, ISecondInterface{
    public void MyMethod(){
        Console.WriteLine("Basking in Allah's Noor and Rohma");
    }

    public void MyOtherMethod(){
        Console.WriteLine("Always ready to appreciate Allah for his favors");
    }
}

class Program{
    static void Main(string[] args){
       Pig newPig = new Pig();
        newPig.AnimalSound();

        MultipleInterface interfaceUsage = new MultipleInterface();
        interfaceUsage.MyMethod();
        interfaceUsage.MyOtherMethod();
    }
}

/*
It is considered good practice to start with the letter "I" 
at the beginning of an interface, as it makes it easier for 
yourself and others to remember that it is an interface and not a class.
By default, members of an interface are abstract and public.
Note: Interfaces can contain properties and methods, but not fields.
*/

/*
Notes on Interfaces:
Like abstract classes, interfaces cannot be used to create objects (in the example above, 
it is not possible to create an "IAnimal" object in the Program class)
Interface methods do not have a body - the body is provided by the "implement" class
On implementation of an interface, you must override all of its methods
Interfaces can contain properties and methods, but not fields/variables
Interface members are by default abstract and public
An interface cannot contain a constructor (as it cannot be used to create objects)

Why And When To Use Interfaces?
1) To achieve security - hide certain details and only show the important details of an object (interface).

2) C# does not support "multiple inheritance" (a class can only inherit from one base class). However, 
it can be achieved with interfaces, because the class can implement multiple interfaces. Note: 
To implement multiple interfaces, separate them with a comma (see example below).
*/