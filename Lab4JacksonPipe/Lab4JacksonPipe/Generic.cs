using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3Library;

namespace Lab4JacksonPipe
{
    public class Generic<T>
    {
        decimal empCount, totalPay, totalBonus, totalDeductions;

        public decimal TotalEmployees { get => empCount; }
        public decimal TotalPay { get => totalPay; }
        public decimal Totalbonus { get => totalBonus; }
        public decimal TotalDeductions { get => totalDeductions; }

        public Generic(DateTime payPeriod, List<T> employees)
        {

        }

        public List<string> ProcessPayRoll(List<Employee> employees)
        {
            List<string> empPayRollInfo = new List<string>();
            foreach (Employee e in employees)
            {
                empPayRollInfo.Add(e.SocialInsuranceNumber + " " + e.FullName + " - Net Pay: " + e.CalculatePay().ToString() + " - Bonus: " + e.Bonus().ToString() + " - Deductions (Union Dues): " + e.UnionDue().ToString());
                empCount += 1;
                totalPay += e.CalculatePay();
                totalBonus += e.Bonus();
                totalDeductions += e.UnionDue();
            }
            return empPayRollInfo;
        }
    }
}
