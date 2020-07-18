using StateBehaviorPattern.Contracts;
using System.Collections.Generic;

namespace StateBehaviorPattern.Contracts
{
    public interface IState
    {
        DocumentStateEnum Current { get; }

        List<DocumentStateEnum> AvailbleStates {get;}

        void Handle(IDocument context);
    }
}