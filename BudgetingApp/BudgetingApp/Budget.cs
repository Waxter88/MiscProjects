using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BudgetingApp
{
    internal class Budget
    {
        //object containing information about user's budget
        //1. Money available
        //2. Time period (2 DateTime values)

        //Methods for:
        //1. Printing budget information (formatted nicely)
        //2. Get the time period between startDate and endDate, return value in days

            public double money { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }

            public Budget(double money, DateTime startDate, DateTime endDate)
            {
                this.money = money;
                this.startDate = startDate;
                this.endDate = endDate;
            }

            public void PrintBudget()
            {
                Console.WriteLine("Budget: {0}", money);
                Console.WriteLine("Start Date: {0}", startDate);
                Console.WriteLine("End Date: {0}", endDate);
            }

        //Return integer value representing time period between startDate and endDate. 
            public void PrintTimePeriod()
            {
                TimeSpan timePeriod = endDate - startDate;
                int days = timePeriod.Days;
                Console.WriteLine("Time Period: {0}", days);
            
            }



    }
}

