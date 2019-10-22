///<summary>
///Разработать программу, моделирующую танковый бой. В танковом бою участвуют 2 армии: танков «Т-34» и танков «Pantera». 
///Каждый танк («Т-34» и «Pantera») описываются параметрами: «Боекомплект»(Урон) (random 5-10), 
///«Уровень брони»(Здоровье)(random 80 - 110), «Уровень маневренности»(random 1-100), «Опыт экипажа»(random 1-10),  «Маскировка» (random 1-10).
///Каждый танк участвует в парной битве, т.е.случайный танк «Т-34» сражается с случайным танком «Pantera» и т.д.
///Победа присуждается тому танку, который превышает противника по двум и более параметрам из трех (маневренность, опыт, маскировка). 
///У проигравшего танка убирается количество брони равное урону танка-победителя.Проигравший танк наносит в ответ половину урона.
///Оба танка получают +1 опыта.Проигравший танк получает +1 к маскировке. Бой продолжается пока не останутся танки только одного типа.
///Танки с Уровнем брони < 0 в сражении не учавстсвуют. Сражение (проверку на победу в бою) реализовать путем перегрузки оператора «*» (произведение). 
///Классовая структура включает типы Tank, TankT34 : Tank, TankPantera: Tank.
///Армии задаются переменными типа List<Tank>.
///Дополнительно: делаем для т34 маскировку random 5-10, а пантерам маневренность 20-100
///
/// </summary>
using System;
namespace Battle_tanks
{
    public abstract class Tank
    {
        static Random range = new Random();
        public int damage { get; set; }
        public int health { get; set; }
        public int maneuv { get; set; }
        public int exp { get; set; }
        public int camouf { get; set; }
        public bool win;

        public Tank()
        { 
            this.damage = Rand(5,10);
            this.health = Rand(80,110);
            this.maneuv = Rand(1,100);
            this.exp = Rand(1, 10);
            this.camouf = Rand(1, 10);
            this.win = true;
        }
        public int Rand(int first, int second)
        {
            return range.Next(first, second);
        }

        //public static bool operator *(Tank tank1, Tank tank2) //вот как тут
        //{
        //    if (tank1 > tank2)//для этого нужно еще >< перегрузить
        //        //tank1 победил
        //        //их еще изменять можно прямо тут
        //        tank2.health -= tank1.damage; //типа такого
        //    else
        //        //code


        //}

        //public static bool operator >(Tank tank1, Tank tank2)
        //{
        //    //условия когда один сильнее другого
        //}
    }

}
