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
using PROG1198_Lab4;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
//PROG1198 - Lab 5
//BY: Jackson Pipe
//Date: 04/11/2022

namespace LeagueUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static League db;
        public MainPage()
        {
            this.InitializeComponent();
            txtBxTeamID.IsReadOnly = true;
            //Create Database Object
            db = new League(App.ConnectionString);
            //Populate listView with Team Objects
            InitListView();
        }
        private void InitListView()
        {
            //populate list view with team objects from ReturnAllTeamObjects method
            List<Team> dbList = new List<Team>();
            dbList = db.ReturnAllTeamObjects();

            foreach (Team t in dbList)
            {
                listViewTeams.Items.Add(t);
            }
        }
        private void listViewTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Team t = (Team)listViewTeams.SelectedItem;
            if (t != null)
            {
                txtBxTeamCity.Text = t.teamCity;
                txtBxTeamID.Text = t.teamID;
                txtBxTeamName.Text = t.teamName;
                txtBxTeamStadium.Text = t.teamStadium;
                txtBxTeamStadiumCapacity.Text = t.teamStadiumCapacity.ToString();
            }
        }

        private void bttnSubmit_Click(object sender, RoutedEventArgs e)
        {
            listViewTeams.Items.Clear();
            int stadiumCapacity;
            //get input from text boxes if teamID text box is not null
            if(!Int32.TryParse(txtBxTeamStadiumCapacity.Text, out stadiumCapacity))
            {
                txtError.Text = "Error: stadiumCapacity must be a numeric value. Update failed.";
                InitListView();
            }
            else if (txtBxTeamID != null)
            {
                txtError.Text = "";
                //stadiumCapacity = Int32.Parse(txtBxTeamStadiumCapacity.Text);
                Team t = new Team(txtBxTeamID.Text, txtBxTeamName.Text, txtBxTeamCity.Text, txtBxTeamStadium.Text, stadiumCapacity);
                //call method to update Team Object
                db.UpdateTeamObject(t);
                //update list view
                InitListView();
            }
        }

        private void bttnSubmitFilter_Click(object sender, RoutedEventArgs e)
        {
            txtError.Text = "";
            listViewTeams.Items.Clear();
            int teamCapacity;

            if (!Int32.TryParse(txtBxTeamStadiumCapacityFilter.Text, out teamCapacity))
            {
                txtError.Text = "TeamStadiumCapacity must be a numeric value";
            }
            else if (txtBxTeamStadiumFilter.Text != null && txtBxTeamStadiumCapacityFilter.Text != null)
            {
                List<Team> dbList = new List<Team>();
                dbList = db.ReturnTeamsByStadiumAndCapacity(txtBxTeamStadiumFilter.Text, teamCapacity);

                foreach (Team t in dbList)
                {
                    listViewTeams.Items.Add(t);
                }
            } 
            else
            {
                txtError.Text = "Error: make sure values are entered correctly for teamStadium and teamStadiumCapacity filters.";
            }
        }
    }
}
