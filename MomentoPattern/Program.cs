using System;

namespace MomentoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroOriginator hero = new HeroOriginator();
            hero.Shoot(); //Making a shot. 9 patrons left
            GameHistoryCaretaker game = new GameHistoryCaretaker();

            game.History.Push(hero.GetCurrentState()); // save game

            hero.Shoot(); //Making a shot,  9 patrons left

            hero.RestoreState(game.History.Pop());

            hero.Shoot(); //Making a shot,  9 patrons left

            Console.Read();
        }
    }
}
