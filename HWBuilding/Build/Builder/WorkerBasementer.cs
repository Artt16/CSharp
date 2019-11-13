using System;

namespace Build.Builder
{
    public class WorkerBasementer : IWorker
    {
        public string Name { get; set; }
        public void BuildBasement(House house)
        {
            var basement = new Basement(Name);
            basement.Construct(house);
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
            throw new NotImplementedException();
        }

        public void BuildWindow(House house)
        {
            throw new NotImplementedException();
        }
    }
}
