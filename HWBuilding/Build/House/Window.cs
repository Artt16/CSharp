namespace Build
{
    public class Window : IPart
    {
        public string BuilderName { get; set; }
        public Window(string buildername)
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

