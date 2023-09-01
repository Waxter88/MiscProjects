//Budgeting Program

using BudgetingApp;

class Program
{
    //Create a new instance of the Budget and date
    Budget budget = new Budget(100, new DateTime(2018, 1, 1), new DateTime(2018, 1, 31));
    Date date = new Date(new DateTime(2018, 1, 1), "Test Date");
    ConsoleHelper console = new ConsoleHelper();
    static void Main(string[] args)
    {
        // Create a new instance of the BudgetingApp class.
        Program budgetingApp = new Program();
        // Call the Run method on the budgetingApp object.
        budgetingApp.Run();
    }

    //Primary logic method
    private void Run()
    {
        //Program run test message
        Console.WriteLine("Budgeting Program");

        
        
        Console.WriteLine("budget.endDate: ", budget.endDate);
        Console.WriteLine("budget.startDate: ", budget.startDate);

        //Create a new instance of Date
        

        
        budget.PrintBudget();
        budget.PrintTimePeriod();

        string fileLoc = "dates";

        Console.WriteLine("\nPrintDate()");
        //Date class used for inputting date values and saving them to file
        date.PrintDate();
        date.SaveDate(date.date, fileLoc);
        DateTime[] dates = Date.ReadDate(fileLoc);

        Console.WriteLine("\nPrintDate(dates)");
        Date.PrintDate(dates);

        string[] menu_items = { "first", "second" };
        ConsoleHelper.ConsoleMenu(menu_items);

    }
}