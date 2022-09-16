public class OwnerDetail {

    public void PrintDetail() {

        string[] Owner1 = {"Mr.Thawee", "Chaideedee", "153-698-4561237"};
        string[] Owner2 = {"Mr.Yudthadee", "Tangjairean", "742-112-5687412"};
        string[] Owner3 = {"Mr.James", "Rakrongrean", "541-772-3215689"};

        Console.WriteLine("-------- Owner1 Detail --------");
        Console.WriteLine("Name: {0}",Owner1[0]);
        Console.WriteLine("Surname: {0}",Owner1[1]);
        Console.WriteLine("ID: {0}",Owner1[2]);
        Console.WriteLine("-------------------------------");
        Console.WriteLine();

        Console.WriteLine("-------- Owner2 Detail --------");
        Console.WriteLine("Name: {0}",Owner2[0]);
        Console.WriteLine("Surname: {0}",Owner2[1]);
        Console.WriteLine("ID: {0}",Owner2[2]);
        Console.WriteLine("-------------------------------");
        Console.WriteLine();

        Console.WriteLine("-------- Owner3 Detail --------");
        Console.WriteLine("Name: {0}",Owner3[0]);
        Console.WriteLine("Surname: {0}",Owner3[1]);
        Console.WriteLine("ID: {0}",Owner3[2]);
        Console.WriteLine("-------------------------------");
        Console.WriteLine();
    }
}