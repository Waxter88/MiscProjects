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

namespace PROG1124___LAB_4
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

       

        private void shapeComboBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void submitBttn_Click(object sender, RoutedEventArgs e)
        {
            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            if (shapeComboBx == null) resultTxt.Text = "Select a shape from the dropdown menu.";
            else if (item.Content.ToString() == "Cuboid") { resultTxt.Text = "cuboid"; }
            else if (item.Content.ToString() == "Sphere") { }
            else if (item.Content.ToString() == "Cube") { }
            else if (item.Content.ToString() == "Cylinder") { }
        }
    }
}
