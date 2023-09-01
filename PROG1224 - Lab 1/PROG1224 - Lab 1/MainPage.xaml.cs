using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
//PROG1224 - Lab 1
//BY: Jackson Pipe
//DATE: 01/20/2022

namespace PROG1224___Lab_1
{
    public sealed partial class MainPage : Page
    {
        int[] winningNums = new int[6];
        int[] playerNums = new int[7];

        Random random = new Random();

        private void GenerateRandomNumbers(int[] numberArray)
        {
            int num;
            for (int i = 0; i < numberArray.Length; i++)
            {
                do
                {
                    num = random.Next(1, 50);
                } while (numberArray.Contains(num));
                numberArray[i] = num;
            }
        }

        private string BuildDisplayString(int[] numberArray)
        {
            string displayString = "";
            foreach (int i in numberArray)
            {
                displayString += i + "  ";
            }
            return displayString;
        }

        private int CompareTwoArrays(int[] array1, int[] array2) => array1.Intersect(array2).Count();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnGeneratePlayerNum_Click(object sender, RoutedEventArgs e)
        {
            GenerateRandomNumbers(playerNums);
            txtPlayerNumResult.Text = BuildDisplayString(playerNums);
        }

        private void btnGenerateWinningNum_Click(object sender, RoutedEventArgs e)
        {
            GenerateRandomNumbers(winningNums);
            txtWinningNumResult.Text = BuildDisplayString(winningNums);

            txtNumOfMatches.Text = CompareTwoArrays(playerNums, winningNums).ToString(); //amount of matching numbers between playerNums and winningNums
        }
    }
}
