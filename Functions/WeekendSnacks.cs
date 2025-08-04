// See https://aka.ms/new-console-template for more information

class WeekendSnacks {
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        
        bool even = isEven(number);
        Console.Write(even);

    }

    public static bool isEven(int number) {
        if (number % 2 == 0)
        {
            return true;
        }

        return false;

    }
    
}