﻿using System;
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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409


namespace PayRoll
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void bttnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string output = "";
            Employee.Employee[] employees = Employee.EmployeeData.getExampleEmployee(5);
            Employee.Manager[] managers = Employee.EmployeeData.getExampleManager(5);
            Employee.CEO[] ceos = Employee.EmployeeData.getExampleCEO(5);

            foreach (Employee.Employee emp in employees)
            {
                output += emp + "\n\n";
            }

            txtOutput.Text = output;
        }
    }
}
