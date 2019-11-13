
namespace Build
{
    public class Basement : IPart
    {
        public string BuilderName { get; set; }
        public Basement(string buildername)
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

