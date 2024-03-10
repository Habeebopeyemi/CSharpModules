
class Program{
enum Level{
    Low, Medium, High
}

enum Months{
    January , //0
    February, //1
    March, //2
    April, //3
    May, //4
    June, //5
    July = 8, //8 instead of 6
    August, //9
    September, //10
    October, //11
    November, //12
    December //13
}
    static void Main(string[] args){
        Level curLevel = Level.Medium;
        Console.WriteLine($"The current value is {curLevel}, and the data type is: {curLevel.GetType()}");

        int myNum = (int)Months.May;
        Console.WriteLine(myNum);

        switch(curLevel){
            case Level.High:
                Console.WriteLine("High level");
                break;
            case Level.Medium:
                Console.WriteLine("Medium Level");
                break;
            case Level.Low:
                Console.WriteLine("Low level");
                break;
            default:
                Console.WriteLine("This is free zone");
                break;
        }
    }
}