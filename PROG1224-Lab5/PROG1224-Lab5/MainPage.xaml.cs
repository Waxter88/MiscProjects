using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Lab3Library;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PROG1224_Lab5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<Employee> empList = new List<Employee>();

        //custom event if pay is over 100000
        public delegate void OnOverPay(object sender, EventArgs e);
        public event OnOverPay OverPayEvent;

        public void payPeriod(int pay)
        {
            if(pay > 100000)
            {
                EventArgs arg = new EventArgs();
                OverPayEvent(this, arg);
            }
        }

        public void overPayHandler(object Sender, EventArgs e)
        {
            //notify user of overpayment
        }

        public MainPage()
        {
            init();
            this.InitializeComponent();
            update();
            LINQResults();
        }
        public void init()
        {
            empList.AddRange(CreateSampleEmployee<Employee>(20));
        }

        public void LINQResults()
        {
            //total number of employees by type
            var totalEmpByType =
                from emp in empList
                group emp by emp.GetType() into e
                select new
                {
                    t = e.Key,
                    c = e.Count()
                };
            foreach(var e in totalEmpByType)
            {
                txtResultTotalEmp.Text += " Type: " + e.t.ToString() + " : " + " Count: " + e.c.ToString();
            }

            //total number of employees active and inactive
            var totalEmpActiveAndInactive =
                from emp in empList
                group emp by emp.Active into e
                select new
                {
                    Active = e.Key,
                    Count = e.Count()
                };
            foreach (var e in totalEmpActiveAndInactive)
            {
                txtResultTotalEmpActiveInactive.Text += " Active: " + e.Active + " Count: " + e.Count;
            }

            //employees with the most seniority and the least seniroity (show name, employee type, and pay)
            var empMostSenior = empList.OrderByDescending(i => i.HireDate).FirstOrDefault();
            txtResultMostSenior.Text = empMostSenior.ToString() + " Pay: " + empMostSenior.CalculatePay();

            var empLeastSenior = empList.OrderBy(i => i.HireDate).FirstOrDefault();
            txtResultLeastSenior.Text = empLeastSenior.ToString() + " Pay: " + empLeastSenior.CalculatePay();

            //employee with the highest pay
            var empHighestPay = empList.OrderByDescending(i => i.CalculatePay()).FirstOrDefault();
            txtResultHighestPay.Text = empHighestPay.ToString() + " Pay: "+ empHighestPay.CalculatePay();

            //average pay of all employees
            var empAvgPay = empList.Average(i => i.CalculatePay());
            txtResultAvgPay.Text = empAvgPay.ToString() + "$";

            //employee with the lowest pay
            var empLowestPay = empList.OrderBy(i => i.CalculatePay()).FirstOrDefault();
            txtResultLowestPay.Text = empLowestPay.ToString();
        }

        public void update()
        {
            listViewResult.Items.Clear();
            for (int i = 0; i < empList.Count; i++)
            {
                listViewResult.Items.Add(empList[i]);
            }
            //sort alphabetically by first name
            empList.Sort((x, y) => string.Compare(x.FirstName, y.FirstName));
        }

        public List<Employee> CreateSampleEmployee<T>(int size)     //add sample employee of each type for size
        {
            List<Employee> emps = new List<Employee>();
            for (int i = 0; i <= size; i++)
            {
                emps.Add(new Salary("empFirst", "empLast" + i, DateTime.Now, "empSIN"));
                emps.Add(new Hourly("empFirst", "empLast" + i, DateTime.Now, "empSIN"));
            }

            return emps;
        }

        private void bttnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(txtBxSearch.Text, out int result))
            {
                var search =
                    from emp in empList
                    where emp.CalculatePay() <= result
                    select emp;
                listViewResult.Items.Clear();
                foreach (var i in search)
                {
                    listViewResult.Items.Add(i);
                }
            }
            else
            {
                //error, input was not an integer
            }
        }
    }
}
