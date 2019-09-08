using System.Collections.Generic;

namespace MomentoPattern
{
    // Caretaker
    class GameHistoryCaretaker
    {
        public Stack<HeroMemento> History { get; private set; }
        public GameHistoryCaretaker()
        {
            History = new Stack<HeroMemento>();
        }
    }
}