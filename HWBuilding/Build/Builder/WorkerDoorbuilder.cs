namespace Build.Builder
{
    public class WorkerDoorbuilder : IWorker
    {
        public WorkerDoorbuilder(){}
        public string Name { get; set; }

        public void BuildBasement(House house)
        {
            throw new System.NotImplementedException(); 
        }

        public void BuildDoor(House house)
        {
            var door = new Door(Name);
            door.Construct(house);
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
