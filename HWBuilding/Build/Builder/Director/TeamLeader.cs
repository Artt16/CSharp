using System;
namespace Build
{
    public class TeamLeader
    {
        public string name { get; set; } = "Brigadier Yasya";

        public void Build(Team workers, House house)
        {
            var count = 0;
            while (!house.IsComplete)
            {
                foreach (var worker in workers)
                {
                    try
                    {
                        if (!house.IsBasementBuild && !house.IsComplete)
                        {
                            Console.WriteLine(name);
                            Console.WriteLine($"Worker {worker.Name} is building Basement");
                            worker.BuildBasement(house);                            
                            Console.WriteLine("Basement is builded");
                            continue;
                        }
                        if (house.IsBasementBuild && !house.IsWallsComplete )
                        {
                           
                            worker.BuildWall(house);
                            count++;
                            Console.WriteLine($"Worker {worker.Name} is building Wall № {count}");
                            Console.WriteLine($"Wall {count} is builded");     
                            if(count > 3) { count = 0; }
                            continue;                            
                        }
                        if (house.IsWallsComplete && !house.IsDoorComplete) 
                        {
                            Console.WriteLine($"Worker {worker.Name} is building Door");
                            worker.BuildDoor(house);
                            Console.WriteLine("Door is builded");
                            continue;
                        }
                        if(house.IsDoorComplete && !house.IsRoofBuild)
                        {
                            Console.WriteLine($"Worker {worker.Name} is building Roof");
                            worker.BuildRoof(house);
                            Console.WriteLine("Roof is builded");
                            continue;
                        }
                        if(house.IsRoofBuild && !house.IsWindowComplete)
                        {
                            worker.BuildWindow(house);
                            count++;
                            Console.WriteLine($"Worker {worker.Name} is building Window № {count}");
                            Console.WriteLine($"Window {count} is builded");
                            break;
                        }
                    }
                    catch
                    {
                        continue;
                    }              
                }                
            }
        }       
    }
}