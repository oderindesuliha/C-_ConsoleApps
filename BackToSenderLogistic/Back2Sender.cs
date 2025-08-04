// See https://aka.ms/new-console-template for more information
class Back2Sender {
    static void Main(string[] args) {
        Console.Write("Enter Collection rate: ");
        int rate = int.Parse(Console.ReadLine());

        if (rate <= 0) {
            Console.WriteLine("Invalid rate");
        }

        double result = CalculatePay(rate);
        Console.WriteLine("The total pay for " + rate + " successful delivery is: " + result);
        
    }

    public static double CalculatePay(int rate) {
        if (rate < 50) {
            return rate * 160 + 5000;
        }
        else if (rate <= 59) {
            return rate * 200 + 5000;
        }
        else if (rate <= 69) {
            return rate * 250 + 5000;
        }
        else {
            return rate * 500 + 5000;
        }
    }


}