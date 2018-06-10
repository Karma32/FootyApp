using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project
{
    class TeamDisplay
    {
        private int score;
        private string TeamName;

        public TeamDisplay(string name)
        {
            TeamName = name;
            score = 0;
        }

        public void SetScore(int goals)
        {
            score = goals;
        }

        public void SetTeamName(string name)
        {
            TeamName = name;
        }

        public int GetScore()
        {
            return score;
        }

        public string GetTeamName()
        {
            return TeamName;
        }

        public void Increment()
        {
            score = score + 1;
        }
    }
}
