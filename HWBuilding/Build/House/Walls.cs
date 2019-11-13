namespace Build
{
    public class Walls : IPart
    {
        public string BuilderName { get; set; }
        public Walls(string buildername)
        {
            BuilderName = buildername;
        }
        public bool constructionStatus { get; set; } = false;
        public void Construct(House house)
        {
            house.Parts.Add(this);
            constructionStatus = true;
        }
    }
}
