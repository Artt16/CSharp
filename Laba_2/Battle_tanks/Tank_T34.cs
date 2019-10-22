using System.Text;
namespace Battle_tanks
{
    public class Tank_T34:Tank
    {
        
        public Tank_T34():base()
        {
            camouf = Rand(5, 10);
            
        }
        public Tank_T34(int damage, int health, int maneuv, int exp, int camouf)
        {
            this.camouf = Rand(5, 10);
        }
        public override string ToString()
        {
            var t34 = new StringBuilder();
            t34.Append(Tanks_res.t34 + "\n");      
            t34.Append(Tanks_res.damage + damage + "\n");
            t34.Append(Tanks_res.health + health + "\n");
            t34.Append(Tanks_res.maneuv + maneuv + "\n");
            t34.Append(Tanks_res.exp + exp + "\n");
            t34.Append(Tanks_res.comouf + camouf + "\n");
            return t34.ToString();
        }
        public static bool operator*(Tank_T34 t34_obj, Tank_Pantera pantera_obj) //тут лучше базовые классы  
        {
            bool test_1, test_2, test_3;
            if (t34_obj.maneuv > pantera_obj.maneuv) { test_1 = true; }
            else { test_1 = false; }
            if (t34_obj.exp > pantera_obj.exp) { test_2 = true; }
            else { test_2 = false; }
            if (t34_obj.camouf > pantera_obj.camouf) { test_3 = true; }
            else { test_3 = false; }
            if (test_1 && test_2 && test_3)
            {
                return true;
            }
            else if ((test_1 && test_2) || (test_2 && test_3) || (test_1 && test_3))
            {
                return true;
            }
            else
            {
                return false;
            }
            //их еще изменять можно прямо тут
            
        }
    }
}