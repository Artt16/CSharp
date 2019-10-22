using System.Collections.Generic;

namespace Build
{

    public class TeamLeader
    {
        public string name { get; set; } = "Brigadier Yasya";//=)

         public void Build(List<IWorker> workers, House house) //тут можно переделать, чтобы team использовал, но тогда надо чтобы team был IEnumerable
        //public void Build(Team workers, House house)
        {
            while (!house.IsComplete)
            {
                try
                {
                    foreach (var worker in workers)
                    {
                        // а тут бригадир достает из штанин проект
                        worker.BuildBasement(house);
                        worker.BuildWall(house);
                        worker.BuildDoor(house);
                        worker.BuildRoof(house);
                        worker.BuildWindow(house);
                        //ну вот и все, тут все детали надо добавить
                        //то потом можно так вызывать
                        //worker
                        //    .BuildDoor(house)
                        //    .BuildRoof(house)
                        //    .BuildWall(house)
                        //    .BuildDoor(house);
                    }
                }
                catch //если ктото чето не умеет то просто продолжаем строить
                { continue; }
            }
        }

       
    }
}