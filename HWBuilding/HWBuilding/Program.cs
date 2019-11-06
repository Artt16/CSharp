using System;
using System.Collections.Generic;
using Build;
using Build.Builder;
using Build.Builder.Director;
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
            //var _team = new List<IWorker>();
            var team = new Team();//_team);
            //_team.Add(new WorkerBasementer());
            //_team.Add(new WorkerWallsbuilder());
            //_team.Add(new WorkerWindowbuilder());
            //_team.Add(new WorkerRoofer());
            //_team.Add(new WorkerDoorbuilder());
            teamleader.Build(team, house);

        }     
    }
}