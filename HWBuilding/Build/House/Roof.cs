namespace Build
{
    public class Roof : IPart
    {
        public bool constructionStatus { get; set; } = false;
        public string BuilderName { get; set; }
        public Roof(string builderName)
        {
            BuilderName = builderName;
        }
        public void Construct(House house)
        {
            house.Parts.Add(this);
            constructionStatus = true;
        }
    }
}

