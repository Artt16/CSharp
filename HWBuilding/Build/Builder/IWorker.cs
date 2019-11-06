namespace Build
{
    public interface IWorker
    {
        string Name { get; set; }
        void BuildRoof(House house);
        void BuildBasement(House house);
        void BuildWall(House house);
        void BuildDoor(House house);
        void BuildWindow(House house);

        //IWorker BuildBasement(House house);
        //IWorker BuildWall(House house);
        //IWorker BuildWindow(House house);
        //IWorker BuildDoor(House house); // если вот так объявить
        //IWorker BuildRoof(House house);


    }
}
