using Build.Builder;
using Build.Builder.Director;
using System.Collections;
using System.Collections.Generic;
namespace Build
{
    public class Team :IEnumerable<IWorker>
    {
        private List<IWorker> team = new List<IWorker>();
        public Team()
        {
            team.Add(new WorkerBasementer() { Name = "Piter" });
            team.Add(new WorkerWallsbuilder() { Name = "Ivan" });
            team.Add(new WorkerDoorbuilder() { Name = "Semen" });
            team.Add(new WorkerRoofer() { Name = "Nicola"});
            team.Add(new WorkerWindowbuilder() { Name = "Bill Gates" });
            team.GetEnumerator();        
        }
        public IEnumerator<IWorker> GetEnumerator(List<IWorker> team)
        {
            
            return team.GetEnumerator();
        }

        public IEnumerator<IWorker> GetEnumerator()
        {
            return ((IEnumerable<IWorker>)team).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return team.GetEnumerator();
        }
    }
}