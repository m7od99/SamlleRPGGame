using System;
namespace RBGGame
{
      public class Monster : Stats, IMonster
      {
            public int RockAttack { get; set; }
            public Monster()
            {
                  this.HP = 20;
                  this.HPNow = 20;
                  this.MP = 5;
                  this.MPNow = 5;
                  this.Attack = 1;
                  this.RockAttack = 4;
            }

            public static Monster GetMonster()
            {
                  return new Monster();
            }

            public string RandomAttack()
            {
                  var random = new Random().Next(0, 2);
                  switch (random)
                  {
                        case 0:
                              return "attack";

                        case 1:

                              return "block";
                        default:

                              return "rockattack";

                  }

            }

      }
}