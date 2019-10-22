using System.Linq;

namespace Build.Builder
{
    public class WorkerDoorbuilder : IWorker
    {
        public string Name { get; set; }
        
        public void BuildBasement(House house)
        {
            throw new System.NotImplementedException(); //а этот не умеет фундамент
        }

        public void BuildDoor(House house)
        {

            var door = house.Parts.FirstOrDefault(b => b.GetType() == typeof(Door));
            if (door != null)
            {
                if (!door.constructionStatus)
                {
                    door.Construct(house);
                }
            }
        }

        public void BuildRoof(House house)
        {
            throw new System.NotImplementedException();
        }

        public void BuildWall(House house)
        {
            throw new System.NotImplementedException();
        }

        public void BuildWindow(House house)
        {
            throw new System.NotImplementedException();
        }
    }
}
