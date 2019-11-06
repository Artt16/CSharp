using System;
namespace Build
{
    public class TeamLeader
    {
        public string name { get; set; } = "Brigadier Yasya";
        public void Build(Team workers, House house)
        {            
            while (!house.IsComplete)
            {
                try
                {
                    foreach (var worker in workers)
                    {
                        if (!house.IsBasementBuild)
                        {
                            worker.BuildBasement(house);
                            Console.WriteLine("Basement is builded");
                           continue;                              
                        }
                        if (house.IsBasementBuild && !house.IsWallsComplete)
                        {
                            worker.BuildWall(house);
                            Console.WriteLine($"Wall {house.Parts.Count} is builded");
                            continue;
                        }
                        if (house.IsWallsComplete && !house.IsDoorComplete) 
                        {
                            worker.BuildDoor(house);
                            Console.WriteLine("Door is builded");
                            continue;
                        }
                        if(house.IsDoorComplete && !house.IsRoofBuild)
                        {
                            worker.BuildRoof(house);
                            Console.WriteLine("Roof is builded");
                            continue;
                        }
                        if(house.IsRoofBuild && !house.IsWindowComplete)
                        {
                            worker.BuildWindow(house);
                            Console.WriteLine($"Window{house.Parts.Count}is builded");
                            break;
                        }                        
                    }
                }
                catch 
                { continue; }
            }
        }

       
    }
}