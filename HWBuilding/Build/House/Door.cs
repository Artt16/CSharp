using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    public class Door : IPart
    {
        public bool constructionStatus { get; set; } = false;
        public void Construct(House house)
        {
            house.Parts.Add(this); // в этих жлементах фактическое добавление в коллекцию
            constructionStatus = true;
            Console.WriteLine("Door");
        }
    }
}