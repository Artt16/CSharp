
namespace Build
{
    public class Door : IPart
    {
        public string BuilderName { get; set; }

        public Door(string builderName)
        {
            BuilderName = builderName;
        }
        public bool constructionStatus { get; set; } = false;
        public void Construct(House house)
        {
            house.Parts.Add(this); 
            constructionStatus = true;
        }
    }
}