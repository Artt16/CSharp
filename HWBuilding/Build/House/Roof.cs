using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    public class Roof : IPart
    {
        public bool constructionStatus { get; set; } = false;
        public void Construct(House house)
        {
            house.Parts.Add(this);
            constructionStatus = true;
            Console.WriteLine("Roof ");
        }
    }
}

