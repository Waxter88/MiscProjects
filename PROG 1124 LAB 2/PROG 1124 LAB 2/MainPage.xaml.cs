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

namespace PROG_1124_LAB_2
{
   //PROG 1124 - LAB 2
   //By: Jackson Pipe
   //Date: 09/29/2021
    
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public bool cmChanged;
        public bool inChanged;
        public double prevInputCm;
        public double prevInputIn;

        double convertInch (double cm, double inch)
        {
            cm = inch * 2.54;
            //convert inches to centimeters
            return cm;
        }

        double convertCm(double cm, double inch)
        {
            inch = cm / 2.54;
            //convert centimeters to inches
            return inch;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }

        private void inchesInputLabel_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void inputInches_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (!e.Equals(prevInputIn))//check if there has been input to inputInch
            {
                inChanged = true;
                cmChanged = false;
            }
            
        }

        private void inputCentimeter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!e.Equals(prevInputCm))//check if there has been input to inputCm
            {
                cmChanged = true;
                inChanged = false;
            }
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            double cm = Convert.ToDouble(inputCm.Text);
            double inch = Convert.ToDouble(inputInch.Text);
            outputText.Text = ""; //reset outputText

            if(cmChanged)//cm inputed, convert cm to inch
            {
                inputInch.Text = Convert.ToString(convertCm(cm, inch));
                cmChanged = false;
            }
            else if(inChanged)//inch inputed, convert inch to cm
            {
                inputCm.Text = Convert.ToString(convertInch(cm, inch));
                inChanged = false;
            }
            else //error, no input
            {
                outputText.Text = "Enter values to convert...";
            }
            
            prevInputCm = cm;
            prevInputIn = inch;
        }
        
    }
}
