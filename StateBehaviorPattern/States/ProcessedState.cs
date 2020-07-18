using StateBehaviorPattern.Contracts;
using StateBehaviorPattern.Model;
using System.Collections.Generic;
using System;

namespace StateBehaviorPattern.States
{
    public class ProcessedState: IState
    {
        public DocumentStateEnum Current { get; } = DocumentStateEnum.Processed;

        public List<DocumentStateEnum> AvailbleStates { get; } = new List<DocumentStateEnum>()
        {
            DocumentStateEnum.Archived,
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