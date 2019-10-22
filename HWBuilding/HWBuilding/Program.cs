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
            //Team team = new Team();
            TeamLeader teamleader = new TeamLeader();
            var team = new List<IWorker>();
            team.Add(new WorkerBasementer());
            team.Add(new WorkerWallsbuilder());
            team.Add(new WorkerWindowbuilder());
            team.Add(new WorkerRoofer());//
            team.Add(new WorkerDoorbuilder());//
            teamleader.Build(team, house);

        }     
    }
}