using System;
using System.Linq;

namespace Build.Builder
{
    public class WorkerBasementer : IWorker
    {
        public string Name { get; set; }
        public void BuildBasement(House house)
        {
            var basement = house.Parts.FirstOrDefault(b => b.GetType() == typeof(Basement));
            if (basement == null || !basement.constructionStatus)
            {
                basement = new Basement();
                basement.Construct(house);
            }
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
