using System;
namespace Build.Builder
{
    public class WorkerWallsbuilder : IWorker
    {
        public string Name { get; set; }
        public void BuildBasement(House house)
        {
            throw new NotImplementedException();
        }

        public void BuildDoor(House house)
        {
            throw new NotImplementedException();
        }

        public void BuildRoof(House house)
        {
            throw new NotImplementedException();
        }

        public void BuildWall(House house)
        {
                var wall = new Walls(Name);
                wall.Construct(house);
        }

        public void BuildWindow(House house)
        {
            throw new NotImplementedException();
        }
    }
}
