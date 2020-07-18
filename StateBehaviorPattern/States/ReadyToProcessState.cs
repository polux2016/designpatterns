using StateBehaviorPattern.Contracts;
using StateBehaviorPattern.Model;
using System.Collections.Generic;
using System;

namespace StateBehaviorPattern.States
{
    public class ReadyToProcessState: IState
    {
        public DocumentStateEnum Current { get; } = DocumentStateEnum.ReadyToProcess;

        public List<DocumentStateEnum> AvailbleStates { get; } = new List<DocumentStateEnum>()
        {
            DocumentStateEnum.Processed,
            DocumentStateEnum.Failed
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