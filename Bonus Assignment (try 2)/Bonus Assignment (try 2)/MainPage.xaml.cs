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

namespace Bonus_Assignment__try_2_
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<int> playerXTurns = new List<int>();
        public List<int> playerOTurns = new List<int>();
        public List<int> moves = new List<int>();

        public int currentMove = 0;
        public int playerXWins = 0;
        public int playerOWins = 0;
        bool turn = true; //true = player X turn, false = player O turn
        bool gameOver = false;

        public MainPage()
        {
            this.InitializeComponent();
        }
        private void update(bool t, int currentMove, Button btn)
        {
            if(t && !gameOver && checkMove(currentMove, moves))
            {
                moves.Add(currentMove);
                playerXTurns.Add(currentMove);
                btn.Content = "X";
                turn = false;
                if (winCheck(playerXTurns))
                {
                    playerXWins++;
                    txtPlayerXWins.Text = "Player X Wins: " + playerXWins.ToString();
                    gameOver = true;
                }
            }
            else if(!t && !gameOver && checkMove(currentMove, moves))
            {
                moves.Add(currentMove);
                playerOTurns.Add(currentMove);
                btn.Content = "O";
                turn = true;
                if (winCheck(playerOTurns))
                {
                    playerOWins++;
                    txtPlayerOWins.Text = "Player O Wins: " + playerOWins.ToString();
                    gameOver = true;
                }
            }
            
        }

        private bool checkMove(int currentMove, List<int> moves) => !moves.Contains(currentMove); //returns true if move is valid (hasnt been played yet)
        private static bool winCheck(List<int> player)
        {
            List<List<int>> winConditions = new List<List<int>>();
            winConditions.Add(new List<int> {1, 2, 3});
            winConditions.Add(new List<int> {3, 6, 9});
            winConditions.Add(new List<int> {7, 8, 9});
            winConditions.Add(new List<int> {1, 4, 7});
            winConditions.Add(new List<int> {4, 5, 6});
            winConditions.Add(new List<int> {2, 5, 8});
            winConditions.Add(new List<int> {1, 5, 9});
            winConditions.Add(new List<int> {3, 5, 7});

            for (int i = 0; i < winConditions.Count(); i++)
            {
                 if(winConditions[i].Intersect(player).Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            currentMove = 1;
            update(turn, currentMove, btnOne);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            currentMove = 2;
            update(turn, currentMove, btnTwo);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            currentMove = 3;
            update(turn, currentMove, btnThree);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            currentMove = 4;
            update(turn, currentMove, btnFour);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            currentMove = 5;
            update(turn, currentMove, btnFive);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            currentMove = 6;
            update(turn, currentMove, btnSix);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            currentMove = 7;
            update(turn, currentMove, btnSeven);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            currentMove = 8;
            update(turn, currentMove, btnEight);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            currentMove = 9;
            update(turn, currentMove, btnNine);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
