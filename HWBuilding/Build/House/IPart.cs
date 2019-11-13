namespace Build
{
    public interface IPart
    {
        bool constructionStatus { get; set; }
        void Construct(House house);
    }
}

