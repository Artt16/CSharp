using System;
using System.Linq;

namespace Build
{
    public class WorkerRoofer : IWorker
    {
        public WorkerRoofer() { }
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
            var roof = house.Parts.FirstOrDefault(b => b.GetType() == typeof(Roof));
            if (roof != null)
            {
                if (!roof.constructionStatus)
                {
                    roof.Construct(house);
                }
            }
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