using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgBattleSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Person player = new Person(300, 100, 60, 80, 70);
            Person enemy = new Person(500, 40, 30, 40, 10);

            player.chooseActions();
            player.getMagicOptions();

            read();
        }

        static void log(string i)
        {
            Console.WriteLine(i);
        }

        static void read()
        {
            Console.ReadLine();
        }
    }
}
