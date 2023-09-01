using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public class Salary : Employee
    {
        double yearlySalary;

        public Salary(double yearlySalary, int SIN, int phoneNumber, string fullName, string fullAddress, string email, DateTime hireDate, DateTime dateOfBirth, bool status) : base(SIN, phoneNumber, fullName, fullAddress, email, hireDate, dateOfBirth, status)
        {
            this.yearlySalary = yearlySalary;
        }

        public override string ToString()
        {
            return base.ToString() + " Yearly Salary: " + yearlySalary;
        }
        public override double CalculatePay()
        {
            return yearlySalary;
        }
    }
}
