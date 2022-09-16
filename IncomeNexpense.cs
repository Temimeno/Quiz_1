public class IncomeAndExpenses {

    public void PrintDetail() {

        double income = 17526 + 218628;
        double expense = (15000*3) + (12500*2) + 1873.3 + 1959.025 + 1996.525 + 2677.5 + 2713.2 + (8250*5) + 45000 + 45600;
        double remian = income - expense;

        Console.WriteLine("------ Income and Expenses ------");
        Console.WriteLine("All Income : {0}", income);
        Console.WriteLine("All Expense : {0}", expense);
        Console.WriteLine("Remaining : {0}", remian);
        Console.WriteLine("---------------------------------");
    }
}