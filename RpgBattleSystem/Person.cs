using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgBattleSystem
{
    class Person
    {
        private int hp;
        private int maxHp;
        private int atkH;
        private int atkL;
        private int mp;
        private int maxMp;
        private int atk;
        private int df;
        private int magic;
        private string[] actions = new string[] {"Attack", "Magic", "View Stats"};
        private Dictionary<string, int> magicOptions = new Dictionary<string, int>();



        public Person(int hp, int mp, int atk, int df, int magic)
        {
            maxHp = hp;
            hp = hp;
            atkH = atk + 10;
            atkL = atk - 10;
            maxMp = mp;
            mp = mp;
            magic = magic;
        }

        public void getMagicOptions()
        {
            magicOptions.Add("Fire:", 30);
            magicOptions.Add("Blizzard:", 50);
            magicOptions.Add("Thunder:", 40);

            foreach (var pair in magicOptions)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
            
        }

        public int generateDmg()
        {
            Random rngDmg = new Random();
            int dmg = rngDmg.Next(atkH, atkL);
            return dmg;
        }

        public int takeDmg(int dmg)
        {
            hp -= dmg;
            if (hp < 0)
            {
                hp = 0;
            }
            return hp;
        }

        public int getHp()
        {
            return hp;
        }

        public int getMaxHp()
        {
            return maxHp;
        }

        public int getMp()
        {
            return mp;
        }

        public int getMaxMp()
        {
            return maxMp;
        }

        public void chooseActions()
        {
            Console.WriteLine("ACTIONS: ");
            foreach(var item in actions)
            {
                Console.WriteLine(item);
            }
            
        }

        public void getPlayerStats()
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"Your HP: {getHp()} \nYour MP: {getMp()}");
        }

        public void getEnemyStats()
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"Enemy MP: {getHp()}\nEnemy MP: {getMp()}");
        }

    }
}
