public class Input {
    public string AskForDetail() {
        Console.WriteLine("Which shop detail do you want to see?");
        Console.WriteLine("(1) Shop Detail.");
        Console.WriteLine("(2) Shop Owner Detail.");
        Console.WriteLine("(3) Employees Detail.");
        Console.WriteLine("(4) Income and Expenses Detail.");
        Console.Write("(Type in number to continue.) : ");
        
        return Console.ReadLine();
    }
    public int NumberChecker(string value) {
        if (int.TryParse(value, out int number)) {
            return number;
        }

        throw new Exception("Please Input Number Only.");
        
    }
    public int OneToFourChecker(int value) {
        int number;
        if (value >0 & value <=4) {
            number = value;
            return number;
        }

        throw new Exception("Please Input Number 1-4 Only.");
    }
}