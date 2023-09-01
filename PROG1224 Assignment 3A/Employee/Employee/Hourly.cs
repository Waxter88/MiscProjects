using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public class Hourly : Employee
    {
        double hoursWorked; //for current period
        double hourlyRateOfPay;

        public Hourly(double hoursWorked, double hourlyRateOfPay, int SIN, int phoneNumber, string fullName, string fullAddress, string email, DateTime hireDate, DateTime dateOfBirth, bool status) : base(SIN, phoneNumber, fullName, fullAddress, email, hireDate, dateOfBirth, status)
        {
            this.hoursWorked = hoursWorked;
            this.hourlyRateOfPay = hourlyRateOfPay;
        }
        public override string ToString()
        {
            return base.ToString() + " Hours worked: " + hoursWorked + " Hourly Rate of Pay: " + hourlyRateOfPay;
        }
        override public double CalculatePay()
        {
            return hoursWorked * hourlyRateOfPay;
        }
    }
}
