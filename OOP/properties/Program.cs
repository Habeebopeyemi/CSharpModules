class Person{
    private string name;
    public string Name { get => name; set => name = value; }//property
}

class Program{
    static void Main(string[] args){
        Person personObj = new Person
        {
            Name = "habeeb"
        };
        Console.WriteLine(personObj.Name);
    }
}