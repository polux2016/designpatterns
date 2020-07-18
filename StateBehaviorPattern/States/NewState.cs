using StateBehaviorPattern.Contracts;
using StateBehaviorPattern.Model;
using System.Collections.Generic;
using System;

namespace StateBehaviorPattern.States
{
    public class NewState: IState
    {
        public DocumentStateEnum Current { get; } = DocumentStateEnum.New;

        public List<DocumentStateEnum> AvailbleStates { get; } = new List<DocumentStateEnum>()
        {
            DocumentStateEnum.ReadyToProcess,
            DocumentStateEnum.Draft
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