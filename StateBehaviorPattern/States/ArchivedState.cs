using StateBehaviorPattern.Contracts;
using StateBehaviorPattern.Model;
using System.Collections.Generic;
using System;

namespace StateBehaviorPattern.States
{
    public class ArchivedState : IState
    {
        public DocumentStateEnum Current { get; } = DocumentStateEnum.Archived;

        public List<DocumentStateEnum> AvailbleStates { get; } = new List<DocumentStateEnum>()
        {
            DocumentStateEnum.Draft,
            DocumentStateEnum.Failed
        };

        public void Handle(IDocument context)
        {
            context.AvailbleRoles = new List<UserRoleEnum>() {
                UserRoleEnum.Admin
            };
        }
    }
}