using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public static class EmployeeData
    {
        public static Employee[] getExampleEmployee(int size)
        {
            Employee[] emp = null;
            for(int i = 0; i <= size; i++)
            {
                emp[i] = new Employee(12345678+i, 289670123+i, "Test Person #" + i, i + " Imaginary Dr.", "testemail" + i + "@test.ca", DateTime.Today, DateTime.Today, true);
            }
            return emp;
        }

        public static CEO[] getExampleCEO(int size)
        {
            CEO[] ceo = null;
            for (int i = 0; i <= size; i++)
            {
                ceo[i] = new CEO(10+i, 12345678 + i, 289670123 + i, "Test Person #" + i, i + " Imaginary Dr.", "testemail" + i + "@test.ca", DateTime.Today, DateTime.Today, true);
            }
            return ceo;
        }

        public static Manager[] getExampleManager(int size)
        {
            Manager[] man = null;
            for (int i = 0; i <= size; i++)
            {
                man[i] = new Manager(1000000, 60000, 12345678 + i, 289670123 + i, "Test Person #" + i, i + " Imaginary Dr.", "testemail" + i + "@test.ca", DateTime.Today, DateTime.Today, true);
            }
            return man;
        }
    }
}
