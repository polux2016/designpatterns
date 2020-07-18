using StateBehaviorPattern.Contracts;
using StateBehaviorPattern.Model;
using System.Collections.Generic;
using System;

namespace StateBehaviorPattern.States
{
    public class FailedState: IState
    {
        public DocumentStateEnum Current { get; } = DocumentStateEnum.Failed;

        public List<DocumentStateEnum> AvailbleStates { get; } = new List<DocumentStateEnum>()
        {
            DocumentStateEnum.Draft
        };

        public void Handle(IDocument context)
        {
            context.AvailbleRoles = new List<UserRoleEnum>() {
                UserRoleEnum.Admin
            };
        }
    }
}