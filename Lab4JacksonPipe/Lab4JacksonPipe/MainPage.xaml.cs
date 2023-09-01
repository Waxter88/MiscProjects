using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Lab3Library;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

//PROG1224 Lab 4B
//Date : 03/23/2022
//By: Jackson Pipe

// TODO - 
/* - Fix date filter
 * - ability to edit/modify existing employees from list (employeeListView)
 *      - changes depending on type of employee (hourly/salary)
 *      - Add Birthday input box
 * 
 * - Select employees for the current pay period, enter pay period dateTime
 *      
 */

namespace Lab4JacksonPipe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
 
    public sealed partial class MainPage : Page
    {
        public List<Employee> empList = new List<Employee>();
        List<ListViewItem> displayItems = new List<ListViewItem>();
        private Employee selectedEmp;
        
        public List<Employee> CreateSampleEmployee<T>(int size) //add sample employee of each type for size
        {
            List<Employee> emps = new List<Employee>();
            for(int i = 0; i <= size; i++)
            {
                emps.Add(new Salary("empFirst", "empLast" + i, DateTime.Now, "empSIN"));
                emps.Add(new Hourly("empFirst", "empLast"+ i, DateTime.Now, "empSIN"));
            }

            return emps;
        }

        public MainPage()
        {
            this.InitializeComponent();
            
            init();
            update();
        }

        public void init()
        {
            //create sample employees
            empList.AddRange(CreateSampleEmployee<Employee>(10));
            //populate employee type, employee type filter combo boxes
            employeeTypeFilter.Items.Add("Hourly");
            employeeTypeFilter.Items.Add("Salary");
            comboBxEmployeeType.Items.Add("Hourly");
            comboBxEmployeeType.Items.Add("Salary");
        }
        public void update()
        {
            employeeListView.Items.Clear();
            for (int i = 0; i < empList.Count; i++)
            {
                employeeListView.Items.Add(empList[i]); 
            }
            //sort alphabetically by first name
            empList.Sort((x, y) => string.Compare(x.FirstName, y.FirstName));
        }

        private void employeeTypeFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            employeeListView.Items.Clear();
            foreach (Employee emp in empList.Where(emps => emps.GetType().ToString().Contains(employeeTypeFilter.SelectedValue.ToString(), StringComparison.OrdinalIgnoreCase)))
            {
                employeeListView.Items.Add(emp);
            }
        }

        private void txtBxFilterEmployeeName_TextChanged(object sender, TextChangedEventArgs e)
        {
            employeeListView.Items.Clear();
            foreach(Employee emp in empList.Where(emps => emps.FullName.Contains(txtBxFilterEmployeeName.Text, StringComparison.OrdinalIgnoreCase)))
            {
                employeeListView.Items.Add(emp);
            }

        }

        private void employeeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (employeeListView.SelectedItem != null)
            {
                txtSelectedEmployee.Text = employeeListView.SelectedItem.ToString();
                foreach (Employee emp in empList.Where(emps => emps.ToString().Contains(employeeListView.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase)))
                {
                    selectedEmp = emp;
                    txtBxFirstName.Text = emp.FirstName;
                    txtBxLastName.Text = emp.LastName;
                    txtBxEmployeeSIN.Text = emp.SocialInsuranceNumber;
                }
            }
            else
            {
                txtSelectedEmployee.Text = "";
            }
        }

        private void bttnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (comboBxEmployeeType.SelectedValue.ToString() == "Salary")
            {
                empList.Add(new Salary(txtBxFirstName.Text, txtBxLastName.Text, txtBxEmployeeSIN.Text));
                update();
            }else if(comboBxEmployeeType.SelectedValue.ToString() == "Hourly")
            {
                empList.Add(new Hourly(txtBxFirstName.Text, txtBxLastName.Text, txtBxEmployeeSIN.Text));
                update();
            }
            else
            {
                //no employee type selected
                update();
            }

            update();
        }

        private void comboBxEmployeeType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //change options for creating employee (depending on hourly or salary)
        }

        private void bttnDisplayPayrollInfo_Click(object sender, RoutedEventArgs e)
        {
            Generic<Employee> payroll = new Generic<Employee>(DateTime.Now, empList);
            foreach(string emp in payroll.ProcessPayRoll(empList))
            {
                listBxPayRoll.Items.Add(emp);
            }
        }

        private void bttnSubmitEdit_Click(object sender, RoutedEventArgs e)
        {
            foreach (Employee emp in empList.Where(emps => emps.ToString().Contains(employeeListView.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase)))
            {
                emp.FirstName = txtBxFirstName.Text;
                emp.LastName = txtBxLastName.Text;
                emp.SocialInsuranceNumber = txtBxEmployeeSIN.Text;
            }
            update();
        }
    }
}
