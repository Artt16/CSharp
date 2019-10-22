using System;
namespace Tasks
{    
    partial class Task6_Iron
    {
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public string Product_class
        {
            get { return product_class; }
            set { product_class = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        static Task6_Iron()
        {
            IronForeign = "Germany";
            YearOfIssue = 2019;
        }
    }
}
