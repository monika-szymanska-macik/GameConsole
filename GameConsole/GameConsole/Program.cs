using System;
using System.IO;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Sarah"
            };
            PlayerCharacter amrit = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Amrit"
            };
            PlayerCharacter gentry = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Gentry"
            };

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);
                
            //PlayerCharacter[] players = new PlayerCharacter[3]
            //{
            //    new PlayerCharacter {Name = "Sarah"},
            //    new PlayerCharacter(),
            //    null
            //};

            //string p1 = players?[0]?.Name;
            //string p2 = players?[1]?.Name;
            //string p3 = players?[2]?.Name;
            //PlayerCharacter player = new PlayerCharacter();

            //int days = player?.DaysSinceLastLogin ?? -1;

            ////int days = player.DaysSinceLastLogin.Value;
            //Console.WriteLine(days);

            

            Console.ReadLine();
        }
    }
}
