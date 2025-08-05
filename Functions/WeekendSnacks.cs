// See https://aka.ms/new-console-template for more information

class WeekendSnacks {
    static void Main(string[] args)
    {
        // int number = 10;
        // bool even = isEven(10);
        // Console.WriteLine("1. " + number + " is even: " + even);
        
        // int prime = 6;
        // bool primeNumber = isPrimeNumber(prime);
        // Console.WriteLine("2. " + prime + " is a prime number: " + primeNumber);
        //
        // int number1 = 7;
        // int number2 = 3;
        // int result = subtract(number1, number2);
        // Console.WriteLine("3. " + "The difference between " + number1 + " and " + number2 + " is: " + result);


        // int num1 = 12;
        // int num2 = 0;
        // float result = divide(num1, num2);
        // Console.WriteLine(result);

        // int number = 25;
        // bool result = isSquare(number);
        // Console.WriteLine(result);
    }
    
    public bool isEven(int number) {
        return number % 2 == 0;
    }

    public bool isPrimeNumber(int primeNumber) {
        if (primeNumber <= 1) return false;

        for (int count = 2; count < primeNumber; count++)
        {
            if (primeNumber % count == 0)
                return false;
        }
        return true;
    }

    public int subtract(int number1, int number2) {
        if (number1 > number2) return number1 - number2;
        else return number2 - number1;
    }
    
    public float divide(int num1, int num2) {
        if (num1 == 0 || num2 == 0) return 0;
        else  return num1 / num2;
    }
    public int factorOf(int number) {
        int counter = 0;
        for (int count = 1; count <= number; count++) {
            if (number % count == 0) {
                counter++;
            }
        }
        return counter;
    }

    public bool isSquare(int number) { 
        int count = 0;
        if (count * count == number)
            count++;
              return true;
    }


    public bool isPalindrome(int number)
    {
        int original = number;
        int reversed = 0;
        while (number != original)
            {
            reversed = number % 10;
            number /= 10;
            }
        return reversed == original;
    }

    public long factorialOf(int number) {
        int factorial = 1;
        for (int count = 1; count <= number; count++)
        {
            factorial *= count;
        }
        return factorial;
    }

    public long squareOf(int number)
    {
        int square = 0;
         square = number * number;
         return square;
        
    }
}
