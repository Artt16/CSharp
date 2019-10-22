using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var wall = house.Parts.FirstOrDefault(b => b.GetType() == typeof(Walls));
            if (wall != null)
            {
                if (!wall.constructionStatus)
                {
                    wall.Construct(house);
                }
            }
        }

        public void BuildWindow(House house)
        {
            throw new NotImplementedException();
        }
    }
}
