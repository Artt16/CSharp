using Build.Builder;
using Build.Builder.Director;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Build
{
    public class Team : IEnumerable
    {
        private List<IWorker> team;
        public Team(House house)
        {
            team.Add(new WorkerBasementer());
            team.Add(new WorkerWallsbuilder());
            team.Add(new WorkerDoorbuilder());
            team.Add(new WorkerRoofer());
            team.Add(new WorkerWindowbuilder());

            
        //    for (int i = 0; i < 2; i++)
        //    {
        //        team
        //        team[i] = new Worker();
        //        team[i].name = $"Builder {i + 1}";
        //    }
        //}
        //public int Length()
        //{
        //    return team.Length;
        }
        //public IWorker this[int index]
        //{
        //    get
        //    {
        //        if (index >= 0 && index <= 3)
        //            return team[index];
        //        return null;
        //    }
        //    set { team[index] = value; }
        //}
        public IEnumerator GetEnumerator()
        {
            return team.GetEnumerator();
        }
    }
}