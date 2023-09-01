using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public class CEO : Employee
    {
        double companyGrowthRate; //in percentage per year by revenue

        public CEO(double companyGrowthRate, int SIN, int phoneNumber, string fullName, string fullAddress, string email, DateTime hireDate, DateTime dateOfBirth, bool status) : base(SIN, phoneNumber, fullName, fullAddress, email, hireDate, dateOfBirth, status)
        {
            this.companyGrowthRate = companyGrowthRate;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        override public double CalculatePay()
        {
            if(companyGrowthRate < 5)
            {
                return 0; //company not growing.. no pay for CEO
            }
            else if(companyGrowthRate > 10)
            {
                return 100000;
            }else if(companyGrowthRate > 20)
            {
                return 200000;
            }else if(companyGrowthRate > 30)
            {
                return 300000; //company is growing fast, lots of pay for CEO
            }
            else
            {
                return 0;
            }
        }
    }
}
