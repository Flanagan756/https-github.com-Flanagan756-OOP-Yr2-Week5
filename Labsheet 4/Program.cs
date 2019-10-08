using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Teams> teams = new List<Teams>();
            {
                Teams SligoRovers = new Teams("Sligo Rovers");
                Teams FinnHarps = new Teams("Finn  Harps");
                Teams GalwayUnited = new Teams("Galway  United");
                Teams DerryCity = new Teams("Derry  City");
                Teams Dundalk = new Teams("Dundalk");

                

                teams.Add(SligoRovers);
                teams.Add(FinnHarps);
                teams.Add(GalwayUnited);
                teams.Add(DerryCity);
                teams.Add(Dundalk);
                
                
                
            }

            Display(teams);

        }
      static void Display(List<Teams>teams)
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}","NAME","POINTS","WINS","DRAWS","LOSSES","PLAYED");
            foreach ( Teams team in teams)
            {
                Console.WriteLine(team.DisplayTeamTable());
            }
        }

    }
}
