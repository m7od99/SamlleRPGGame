using System;
using System.Linq;
using System.Collections.Generic;

namespace RBGGame
{
      public class Game
      {
            public static void Run()
            {
                  var hero = Hero.GetHero();
                  var monster = Monster.GetMonster();

                  StartMassege();

                  ShowStats.ShowHeroStatts(hero);
                  Console.WriteLine("****************************************************************");
                  ShowStats.ShowMonsterStatts(monster);

                  while (hero.HPNow > 0 && monster.HPNow > 0)
                  {
                        ShowStats.BattelHeroStats(hero);
                        ShowStats.BattelMonsterStats(monster);
                        Console.WriteLine("Enter a for Attack , b for Block , f for Fire Attack");
                        string answer = Console.ReadLine().ToLower();
                        string monsterBehaver = Monster.RandomAttack();
                        if (answer == "a")
                        {
                              monster.HPNow = monster.HPNow - hero.Attack;
                        }
                        else if (answer == "f" && hero.MPNow >= 2)
                        {
                              hero.MPNow = hero.MPNow - 2;
                              if (monsterBehaver != "block")
                              {
                                    monster.HPNow = monster.HPNow - hero.FireAttack;

                              }
                        }
                        if (monsterBehaver == "rockattack" && monster.MPNow >= 2)
                        {
                              monster.MPNow = monster.MPNow - 2;
                              if (answer != "b")
                              {
                                    hero.HPNow = hero.HPNow - monster.RockAttack;
                              }
                        }
                        if (monsterBehaver == "attack")
                        {
                              hero.HPNow = hero.HPNow - monster.Attack;
                        }
                        ShowStats.BattelHeroStats(hero);
                        ShowStats.BattelMonsterStats(monster);
                  }
                  if (monster.HPNow <= 0)
                  {
                        Console.WriteLine("You Win");
                  }
                  else
                  {
                        Console.WriteLine("You Lose");
                  }
            }

            private static void StartMassege()
            {
                  Console.WriteLine("Enter To Start");
                  Console.ReadLine();
            }
      }
}