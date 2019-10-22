using System;
namespace Battle_tanks
{
    public static class BattleTime
    {
        public static void battle()
        {
            Tank_T34[] t34 = new Tank_T34[10]; //так тоже должно работать
            Tank_Pantera[] pantera = new Tank_Pantera[10];

            //лучше списком

            //List<Tank> t34 = new List<Tank>();
            //i panteri
            for (int i = 0; i < t34.Length; i++)
            {
                //t34.Add(new Tank_T34());
                //i panteri
                t34[i] = new Tank_T34();
                pantera[i] = new Tank_Pantera();
            }
            int defeat_t34 = 0, defeat_pantera = 0;
            do
            {
                //bool cri_1, cri_2, cri_3;
                Random rand = new Random();
                int num_t34 = rand.Next(t34.Length);
                int num_pant = rand.Next(pantera.Length);
                if (t34[num_t34].health != 0 && pantera[num_pant].health != 0)
                {
                    if (t34[num_t34] * pantera[num_pant])
                    {
                        pantera[num_pant].health -= t34[num_t34].damage;
                        t34[num_t34].health -= pantera[num_pant].damage / 2;
                        t34[num_t34].exp += 1;
                        pantera[num_pant].exp += 1;
                        pantera[num_pant].maneuv += 1;
                        if (t34[num_t34].health <= 0) { t34[num_t34].win = false; defeat_t34 += 1; }
                        if (pantera[num_pant].health <= 0) { pantera[num_pant].win = false; defeat_pantera += 1; }
                    }
                    else
                    {
                        t34[num_t34].health -= pantera[num_pant].damage;
                        pantera[num_pant].health -= t34[num_t34].damage / 2;
                        t34[num_t34].exp += 1;
                        pantera[num_pant].exp += 1;
                        t34[num_t34].maneuv += 1;
                        if (t34[num_t34].health <= 0) { t34[num_t34].win = false; defeat_t34 += 1; }
                        if (pantera[num_pant].health <= 0) { pantera[num_pant].win = false; defeat_pantera += 1; }
                    }
                    Console.WriteLine(t34[num_t34].ToString());
                    Console.WriteLine(pantera[num_pant].ToString());
                }
            } while (defeat_t34 < t34.Length || defeat_pantera < pantera.Length); 
            //while (t34.Any(c => c.health > 0) && panteri.Any(c => c.health > 0)) //сработает если это списки

            if (defeat_t34 == t34.Length)
            {
                Console.WriteLine(Tanks_res.winPantera + "\n" + Tanks_res.defeatT34);
            }
            else
            {
                Console.WriteLine(Tanks_res.winT34 + "\n" + Tanks_res.defeatPantera);
            }
        }
    }
}
