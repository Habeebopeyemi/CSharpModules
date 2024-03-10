class Vehicle //base class (parent)
{
    public string brand = "Ford"; //vehicle field
    public void honk(){
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle // derived class(child)
{
    public string modelName = "Mustang"; //car field
}

class Program{
    static void Main(string[] args) {
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk(); 
        
        // Access the brand field from the Vehicle class using an instance of
        // the Car class:
        Console.WriteLine("This car is a "+myCar.brand + $" with model name: {myCar.modelName}");
    }
}