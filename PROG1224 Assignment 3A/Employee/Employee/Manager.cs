using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public class Manager : Salary
    {
        double totalSales; //in a year

        public Manager(double totalSales, double yearlySalary, int SIN, int phoneNumber, string fullName, string fullAddress, string email, DateTime hireDate, DateTime dateOfBirth, bool status) : base(yearlySalary, SIN, phoneNumber, fullName, fullAddress, email, hireDate, dateOfBirth, status)
        {
            this.totalSales = totalSales;
        }

        public override string ToString()
        {
            return base.ToString() + " Total Sales: " + totalSales;
        }
        public override double CalculatePay()
        {
            return base.CalculatePay();
        }
        new public double Bonus()
        {
            TimeSpan lengthOfService = DateTime.Today - (DateTime)getHireDate();
            if(lengthOfService.Days > 365) //if length of service is more than a year
            {
                return 5; //5% bonus
            }else if(lengthOfService.Days > (365 * 5)) //if length of service is more than five years
            {
                return 15; //15% bonus
            }else if(lengthOfService.Days > (365 * 15)) //if length of service is more than fifteen years
            { 
                return 25; //25% bonus
            }
            else if(lengthOfService.Days > (365*25)) //if length of service is more than twenty five years
            {
                return 35; //35% bonus
            }
            else
            {
                return 0; //otherwise no bonuses
            }
        }
    }
}
