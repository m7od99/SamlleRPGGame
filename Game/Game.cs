using System;
using System.Linq;
using System.Collections.Generic;

namespace RBGGame
{
      public class Game
      {
            private int Score =0;
            private int win = 0;
            private int lose = 0;

            public static void Run()
            {
                  var hero = Hero.GetHero();
                  var monster = Monster.GetMonster();

                  StartMassege();

                  ShowStats.ShowHeroStatts(hero);
                  Console.WriteLine("****************************************************************");
                  ShowStats.ShowMonsterStatts(monster);

                  while (hero.HPNow > 0 || monster.HPNow >0)
                  {
                        Console.WriteLine("Enter a for Attack , b for Block , f for Fire Attack");
                        string chose = Console.ReadLine().ToLower();
                  }
            }

            private static void StartMassege()
            {
                  Console.WriteLine("Enter To Start");
                  Console.ReadLine();
            }
      }
}