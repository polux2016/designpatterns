using System;

namespace MomentoPattern
{
    // Originator
    class HeroOriginator
    {
        private int patrons = 10; 
        private int lives = 5; 

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine("Making a shot. {0} patrons left", patrons);
            }
            else
                Console.WriteLine("No more patrons.");
        }
        public HeroMemento GetCurrentState()
        {
            Console.WriteLine("Saving the game. Parameters: {0} patrons, {1} lives", patrons, lives);
            return new HeroMemento(patrons, lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            this.patrons = memento.Patrons;
            this.lives = memento.Lives;
            Console.WriteLine("Restoring the game. Parameters: {0} patrons, {1} lives", patrons, lives);
        }
    }
}