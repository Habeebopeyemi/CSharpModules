class Program{

    static void checkAge(int age){
        if(age < 18){
            throw new ArithmeticException("Access denied - You must be at least 18 years old.");
        }else{
            Console.WriteLine("Access granted - You are old enough!");
        }
    }
    static void Main(string[] args){
        try
        {
            int[] myNumbers = { 12, 13, 14 };
            Console.WriteLine(myNumbers[10]);

        }
        catch (Exception e)
        {
            
            Console.WriteLine(e.Message);
            Console.WriteLine("Sorry, something went wrong, fixing in progress...");
        }finally{
            Console.WriteLine("The 'try catch is finished'");
        }

        checkAge(33);
    }
}