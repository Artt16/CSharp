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
            team.Add(new WorkerBasementer());
            team.Add(new WorkerWallsbuilder());
            team.Add(new WorkerDoorbuilder());
            team.Add(new WorkerRoofer());
            team.Add(new WorkerWindowbuilder());
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