using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project
{
   public class ScoreBoard
    {
        public ScoreBoard(string Team1, string Team2)
        {
            Home = new TeamDisplay(Team1);
            Away = new TeamDisplay(Team2);
            
        }

        private TeamDisplay Home;
        private TeamDisplay Away;


        public void AwayGoal()
        {
            Away.Increment();
        }

        public void HomeGoal()
        {
            Home.Increment();
        }

        public string GetData()
        {
            return Home.GetTeamName() + "  " + Home.GetScore() + " / " + Away.GetScore() + "   " + Away.GetTeamName();
        }

        public void UpdateDisplay()
        {
            Home.GetScore();
            Away.GetScore();
        }

        public void Zeroise()
        {
            Home.SetScore(0);
            Away.SetScore(0);

        }
    }
}
