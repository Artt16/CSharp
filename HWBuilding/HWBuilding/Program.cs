using Build;
using Build.Project;

namespace HWBuilding
{
    public class Program
    {
        static void Main(string[] args)
        {
            var project = new HouseProject() { BasementNeeded = true, WallCount = 4, DoorNeeded = true, RoofNeeded = true, WindowCount = 4 };
            House house = new House(project);
            TeamLeader teamleader = new TeamLeader();
            var team = new Team();
            teamleader.Build(team, house);

        }     
    }
}