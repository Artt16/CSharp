using System;
namespace Build.Builder.Director
{
    public class WorkerWindowbuilder : IWorker
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
            throw new NotImplementedException();
        }
        public void BuildWindow(House house)
        {
            var window = new Window(Name);
            window.Construct(house);               
            
        }
    }
}
