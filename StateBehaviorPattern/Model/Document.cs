using StateBehaviorPattern.Contracts;
using StateBehaviorPattern.States;
using System.Collections.Generic;
using System.Linq;
using System;

namespace StateBehaviorPattern.Model
{
    public class Document : IDocument
    {
        public IState State { get; private set; }

        public string Name { get; set; }

        public List<UserRoleEnum> AvailbleRoles { get; set; }

        public Document()
        {
            State = new NewState();
            HandleCurrentState();
        }

        public void MoveTo<T>() where T : class, IState, new()
        {
            T newState = new T();

            if (State.AvailbleStates.Any(state => state == newState.Current))
            {
                State = newState;
            }
            else
            {
                Console.WriteLine($"Can't move from {State.Current} to {newState.Current}.");
                State = new FailedState();
            }

            HandleCurrentState();
        }

        private void HandleCurrentState()
        {
            Console.WriteLine($"State {State.Current} will be handled");
            State.Handle(this);
            Console.WriteLine($"New Rights list: '{GetCurrentRightAsAString()}'");
        }

        private string GetCurrentRightAsAString()
        {
            return string.Join(", ", AvailbleRoles.Select(right => right.ToString()));
        }
    }
}