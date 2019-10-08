using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_4
{
    public enum Result {NumberOfWins, NumberOfDraws, NumberOfLoss}
    class Teams
    {
        public string TeamName { get; private set; }
        public int NumberOfWins { get; private set; }
    public int NumberOfLosses { get; private set; }
        public int NumberOfDraws { get; private set; }
        public int NumberOfGames { get; private set; }

        private int points;

        public int Points
        {
            get
            {
                points = (NumberOfWins * 3) + (NumberOfDraws);
                return points;
            }
        }

        public Teams(string name)
        {
            TeamName = name;
        }

        public string DisplayTeamTable()
        {
            return string.Format($"{TeamName,-15}{Points,-15}{NumberOfWins,-15}{NumberOfDraws,-15}{NumberOfLosses,-15}{NumberOfGames,-15}");
        }


    }
}
