using StateBehaviorPattern.Contracts;
using StateBehaviorPattern.Model;
using System.Collections.Generic;
using System;

namespace StateBehaviorPattern.States
{
    public class DraftState: IState
    {
        public DocumentStateEnum Current { get; } = DocumentStateEnum.Draft;

        public List<DocumentStateEnum> AvailbleStates { get; } = new List<DocumentStateEnum>()
        {
            DocumentStateEnum.ReadyToProcess
        };

        public void Handle(IDocument context)
        {
            context.AvailbleRoles = new List<UserRoleEnum>() {
                UserRoleEnum.Admin,
                UserRoleEnum.Manager
            };
        }
    }
}