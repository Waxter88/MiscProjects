using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG1198_Lab4
{
    public class Team
    {
        public string teamID { get; set; }
        public string teamName { get; set; }
        public string teamCity { get; set; }
        public string teamStadium { get; set; }
        public int teamStadiumCapacity { get; set; }
        public Team(string teamId, string teamName, string teamCity, string teamStadium, int teamStadiumCap)
        {
            this.teamID = teamId;
            this.teamName = teamName;
            this.teamCity = teamCity;
            this.teamStadium = teamStadium;
            this.teamStadiumCapacity = teamStadiumCap; 
        }
        public Team() { }
        public override string ToString()
        {
            return "teamID: " + teamID.ToString() + " teamName: " + teamName.ToString() + " teamCity: " + teamCity.ToString();
        }

    }
}
