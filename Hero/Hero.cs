using System;
namespace RBGGame
{
      public class Hero : Stats ,IHero
      {
            public int FireAttack { get; set; }
            public Hero ()
            {
                  this.HP = 10;
                  this.HPNow = 10 ;
                  this.MP = 10 ;
                  this.MPNow = 10 ;
                  this.Attack = 2;
                  this.FireAttack =4;
            }

            public static Hero GetHero()
            {
                  return new Hero();
            }

      }
}