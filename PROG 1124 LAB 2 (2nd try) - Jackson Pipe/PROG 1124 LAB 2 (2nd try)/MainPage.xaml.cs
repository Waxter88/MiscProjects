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

namespace PROG_1124_LAB_2__2nd_try_
{
    //PROG 1124 - LAB 4
    //DATE: 11/01/2021
    //BY: Jackson Pipe

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public string shapeSelection;
        public double calcCuboid(double l, double w, double h) => ((2 * l * w) + (2 * l * h) + (2 * h * w));
        public double calcSphere(double r) => (4 * Math.PI * (Math.Pow(r, 2)));
        public double calcCube(double l) => 6 * Math.Pow(l, 2);
        public double calcCylinder(double r, double h) => 2 * Math.PI * r * h + 2 * Math.PI * Math.Pow(r, 2);


        private void submitBttn_Click(object sender, RoutedEventArgs e)
        {

            double l, w, h, r;
            bool length, width, height, radius;
            length = Double.TryParse(inputLengthTxtBox.Text, out l);
            width = Double.TryParse(inputWidthTxtBox.Text, out w);
            height = Double.TryParse(inputHeightTxtBox.Text, out h);
            radius = Double.TryParse(inputRadiusTxtBox.Text, out r);

            if (shapeSelection == null || shapeSelection == "Choose a Shape") resultTxt.Text = "Choose a shape.";
            else if (shapeSelection == "Cuboid" && l != 0 && w != 0 && h != 0)
            {  
                resultTxt.Text = Convert.ToString(calcCuboid(l, w, h));
            }
            else if (shapeSelection == "Sphere" && r != 0)
            {
                resultTxt.Text = Convert.ToString(calcSphere(r));
            }
            else if (shapeSelection == "Cube" && l != 0)
            {
                resultTxt.Text = Convert.ToString(calcCube(l));
            }
            else if (shapeSelection == "Cylinder" && r != 0 && h != 0)
            {
                resultTxt.Text = Convert.ToString(calcCylinder(r, h));
            }
            else
            {
                resultTxt.Text = "Error: Make sure values are entered correctly."; //error, values not entered correctly
            }
        }

        private void shapeComboBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;

            inputRadiusTxtBox.IsEnabled = true;
            inputHeightTxtBox.IsEnabled = true;
            inputWidthTxtBox.IsEnabled = true;
            inputLengthTxtBox.IsEnabled = true;

            if (shapeComboBx == null || item.Content.ToString() == "Choose a Shape") resultTxt.Text = "Choose a shape.";

            else if (item.Content.ToString() == "Cuboid")
            { 
                inputRadiusTxtBox.IsEnabled = false;
                shapeSelection = "Cuboid";
            }
            else if (item.Content.ToString() == "Sphere")
            {
                inputHeightTxtBox.IsEnabled = false;
                inputWidthTxtBox.IsEnabled = false;
                inputLengthTxtBox.IsEnabled = false;
                shapeSelection = "Sphere";
            }
            else if (item.Content.ToString() == "Cube")
            {
                inputRadiusTxtBox.IsEnabled = false;
                inputWidthTxtBox.IsEnabled = false;
                inputHeightTxtBox.IsEnabled = false;
                shapeSelection = "Cube";
            }
            else if (item.Content.ToString() == "Cylinder")
            {
                inputWidthTxtBox.IsEnabled = false;
                inputLengthTxtBox.IsEnabled = false;
                shapeSelection = "Cylinder";
            }

        }
    }
}
