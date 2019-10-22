using System;

namespace Build
{
    public class Basement : IPart
    {
        public Basement() { }
        public bool constructionStatus { get; set; } = false;
        public void Construct(House house)
        {
            house.Parts.Add(this);
            constructionStatus = true;
            Console.WriteLine("Basement");
        }
    }
}

