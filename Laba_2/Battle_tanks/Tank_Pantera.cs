using System.Text;
namespace Battle_tanks
{
    public class Tank_Pantera:Tank
    {
        public Tank_Pantera()
        {
            this.maneuv = Rand(20, 100);
        }
        public Tank_Pantera(int damage, int health, int maneuv, int exp, int camouf)
        {
            this.maneuv = Rand(20, 100);
        }
        public override string ToString()
        {
            var t34 = new StringBuilder();
            t34.Append(Tanks_res.pantera + "\n");
            t34.Append(Tanks_res.damage + damage + "\n");
            t34.Append(Tanks_res.health + health + "\n");
            t34.Append(Tanks_res.maneuv + maneuv + "\n");
            t34.Append(Tanks_res.exp + exp + "\n");
            t34.Append(Tanks_res.comouf + camouf + "\n");
            return t34.ToString();
        }

    }
}