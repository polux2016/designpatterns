using System.Collections;
using System.Collections.Generic;

namespace StateBehaviorPattern.Contracts
{
    public interface IDocument
    {
        IState State { get; }

        string Name { get; set; }

        List<UserRoleEnum> AvailbleRoles { get; set; }
    }
}