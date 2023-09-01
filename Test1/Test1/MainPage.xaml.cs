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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Test1
{
    //PROG1124 - Midterm Test 1
    // Developed by: Jackson Pipe
    // Date: 10/18/2021
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void locateBttn_Click(object sender, RoutedEventArgs e)
        {
            string codeValue = airportCodeTxtBox.Text.ToUpper();
            switch (codeValue)
            {
                case "YYZ":
                    airportTxtBox.Text = "Toronto, ON Canada";
                    break;

                case "MIA":
                    airportTxtBox.Text = "Miami, FL USA";
                    break;

                case "BUF":
                    airportTxtBox.Text = "Buffalo, NY USA";
                    break;

                case "JFK":
                    airportTxtBox.Text = "New York, NY USA";
                    break;

                case "MYR":
                    airportTxtBox.Text = "Myrtle Beach, SC USA";
                    break;
                default:
                    airportTxtBox.Text = "Code Not Found.";
                    break;
            }
        }

        private string repeatMessage(string message, int repeat)
        {
            string temp = message;
            message = "";
            if (repeat <= 12)
            {
                for (int i = 1; i <= repeat; i++)
                {
                    message += i + ". " + temp + "\n";
                }
                    return message;
            }
            else
                return "Invalid Entry";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int repeat = Int32.Parse(repetitionNumTxtBox.Text);
            string msg = messageTxtBox.Text;

            displayTxtBox.Text = repeatMessage(msg, repeat);
        }
    }
}
