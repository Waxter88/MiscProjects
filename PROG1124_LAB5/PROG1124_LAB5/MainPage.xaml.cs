using System;
using System.Collections.Generic;
using System.ComponentModel;
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

//PROG1124 - LAB 5
//BY: Jackson Pipe
//Date: 11/16/2021

namespace PROG1124_LAB5
{
    public sealed partial class MainPage : Page
    {
        Gamer Gamer1 = new Gamer(); //initialize object of Gamer.cs
        public MainPage()
        {
            this.InitializeComponent();
            joinDateTxtBx.Text = Gamer1.getJoinDate();
        }
        public void updateGamer(Gamer gamer) //update interface values from Gamer object
        {
            winCountTxtBx.Text = gamer.winCount.ToString();
            winPercentTxtBx.Text = gamer.getWinPercentage().ToString();
            pointsTxtBx.Text = gamer.points.ToString();
            loseCountTxtBx.Text = gamer.loseCount.ToString();
            nameTxtBx.Text = gamer.name;
            screenNameTxtBx.Text = gamer.screenName;
            joinDateTxtBx.Text = gamer.getJoinDate();
            outputTxt.Text = gamer.toString();
        }
        private void submitBttn_Click(object sender, RoutedEventArgs e)
        {
            errorTxt.Text = ""; //reset error text
            if (nameTxtBx.Text != "")
            {
                Gamer1.name = nameTxtBx.Text;
            }
            else
            {
                errorTxt.Text += "Enter one character or more for a Name.";
            }
            if (screenNameTxtBx.Text != "")
            {
                Gamer1.screenName = screenNameTxtBx.Text;
            }
            else
            {
                errorTxt.Text += "\nEnter one character or more for a Screen Name.";
            }
            updateGamer(Gamer1);
        }
        private void textChangedEventHandler(object sender, TextChangedEventArgs args) //update outputTxt on TextChanged Event
        {
            outputTxt.Text = Gamer1.toString();
        }
        private void quitBttn_Click(object sender, RoutedEventArgs e)
        {
            Gamer1.quit();
            updateGamer(Gamer1);
           // outputTxt.Text = Gamer1.toString();
        }
        private void winBttn_Click(object sender, RoutedEventArgs e)
        {
            Gamer1.winGame();
            updateGamer(Gamer1);
        }
        private void loseBttn_Click(object sender, RoutedEventArgs e)
        {
            Gamer1.loseGame();
            updateGamer(Gamer1);
        }
        private void resetBttn_Click(object sender, RoutedEventArgs e)
        {
            Gamer1.reset();
            updateGamer(Gamer1);
        }
    }
}
