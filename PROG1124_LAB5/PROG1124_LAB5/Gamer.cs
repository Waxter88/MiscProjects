using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG1124_LAB5
{
    public class Gamer
    {
        public string name { get; set; } = "";
        public string screenName { get; set; } = "";
        public string joinDate { set; get; }
        public int winPercentage { set; get; }
        public int loseCount { set; get; }
        public int winCount { set; get; }
        public int points { set; get; }

        public string getJoinDate() //get current date time, return as string in dd/mm/yyyy format
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            return dateTime.ToString("dd/MM/yyyy");
        }
        public float getWinPercentage(){
            if (winCount > 0)
            {
                return ((float)winCount / (winCount + loseCount) * 100);
            }
            return 0;
        }
        public string toString() => "Name: " + name + " Screen Name: " + screenName + " Joined on: " + getJoinDate() + " Win Percentage: " + getWinPercentage() + "% Lose Count: " + loseCount + " Win Count: " + winCount + " Points: " + points;
        public void winGame()
        {
            this.points += 2;
            this.winCount += 1;
        }
        public void loseGame()
        {
            if (this.points <= 0)
            {
                this.loseCount++;
            }
            else
            {
                this.points--;
                this.loseCount++;
            }
        }
        public void quit()
        {
            this.points = 0;
            this.winCount = 0;
            this.loseCount = 0;
        }
        public void reset()
        {
            this.points = 0;
            this.winCount = 0;
            this.loseCount = 0;
            this.winPercentage = 0;
            this.name = "";
            this.screenName = "";
            this.joinDate = "";
        }
    }
}
