///<summary>
///1.2. Реализовать не менее пяти закрытых полей(различных типов), представляющих основные характеристики рассматриваемого класса.
///1.3. Создать не менее трех методов управления классом и методы доступа к его закрытым полям.
///1.4. Создать метод, в который передаются аргументы по ссылке.
///1.5. Создать не менее двух статических полей (различных типов), представляющих общие характеристики объектов данного класса.
///1.6. Обязательным требованием является реализация нескольких перегруженных конструкторов, аргументы
///которых определяются студентом, исходя из специфики реализуемого класса, а так же реализация конструктора по умолчанию.
///1.7. Создать статический конструктор.
///1.8. Создать массив (не менее 5 элементов) объектов созданного класса.
///1.9. Создать дополнительный метод для данного класса в другом файле, используя ключевое слово partial.
/// </summary>
using System;
namespace Tasks
{
    public partial class Task6_Iron
    {
        private string name;
        private string mode;
        private int power;
        private string product_class;
        private double price;

        public static string IronForeign;
        public static int YearOfIssue;

        public Task6_Iron (string _name, string _mode, int _power, string _product_class, double _price )
        {
            name = _name;
            mode = _mode;
            power = _power;
            product_class = _product_class;
            price = _price;
        }
        public Task6_Iron()
        {
            name = "Default";
            mode = "Default";
            power = 0;
            product_class = "Default";
            price = 0.00;
            Print();
        }
        public Task6_Iron(string _name)
        {
            name = _name;
            mode = "Default";
            power = 0;
            product_class = "Default";
            price = 0.00;
            Print();
        }
        public Task6_Iron(string _name, int _power, double _price)
        {
            name = _name;
            mode = "Default";
            power = _power;
            product_class = "Default";
            price = _price;
            Print();
        }
        public void Print()
        {
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Mode = " + mode);
            Console.WriteLine("Power = " + power);
            Console.WriteLine("Class of product = " + product_class);
            Console.WriteLine("Price = " + price + "\n");
        }
        public void Print(ref Task6_Iron obj)
        {
            Console.WriteLine("Name = " + obj.name);
            Console.WriteLine("Mode = " + obj.mode);
            Console.WriteLine("Power = " + obj.power);
            Console.WriteLine("Class of product = " + obj.product_class);
            Console.WriteLine("Price = " + obj.price);
        }
    } 

    
}
