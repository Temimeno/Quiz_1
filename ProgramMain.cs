public class ProgramMain {

    public static void Main(string[] agrs) {

        //Input
        Input inputPart = new Input();
        string askDetail = inputPart.AskForDetail();
        int checkIfNum = inputPart.NumberChecker(askDetail);
        int checkIfOneToFour = inputPart.OneToFourChecker(checkIfNum);

        switch (checkIfOneToFour)
        {
            case 1:
            ShopDetail shop = new ShopDetail();
            shop.PrintShopDetail();
            break;

            case 2:
            OwnerDetail owners = new OwnerDetail();
            owners.PrintDetail();
            break;

            case 3:
            Employees employees = new Employees();
            employees.PrintDetail();
            break;

            case 4:
            IncomeAndExpenses incomeAndExpenses = new IncomeAndExpenses();
            incomeAndExpenses.PrintDetail();
            break;
        }
    }
}
