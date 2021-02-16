using System;
namespace RBGGame
{
      public class ShowStats
      {
            public static void ShowHeroStatts(Hero hero)
            {
                  Console.WriteLine("HP : " + hero.HP + " / " + hero.HPNow);
                  Console.WriteLine("MP : " + hero.MP + " / " + hero.MPNow);
                  Console.WriteLine("Attack : " + hero.Attack + "|| Fire Attack : " + hero.FireAttack);
            }

            public static void ShowMonsterStatts(Monster monster)
            {
                  Console.WriteLine("HP : " + monster.HP + " / " + monster.HPNow);
                  Console.WriteLine("MP : " + monster.MP + " / " + monster.MPNow);
                  Console.WriteLine("Attack : " + monster.Attack + "|| rock Attack : " + monster.RockAttack);
            }

            public static void BattelHeroStats(Hero hero)
            {
                  Console.WriteLine("Your HP : " + hero.HP + " / " + hero.HPNow + " || Your Mp : " + hero.MP + " / " + hero.MPNow);
            }

            public static void BattelMonsterStats(Monster monster)
            {
                  Console.WriteLine("Monster HP : " + monster.HP + " / " + monster.HPNow + " || Monster Mp : " + monster.MP + " / " + monster.MPNow);

            }
      }
}