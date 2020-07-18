using ProxyStructuralPattern.Contract;
using ProxyStructuralPattern.Models;
using System.Collections.Generic;

namespace ProxyStructuralPattern
{
    public class UserRepository: IUserRepository
    {
        public List<User> GetAllUsers()
        {
            return new List<User>()
            {
                new User() {Name = "PortalUserName", IsPortal = true},
                new User() {Name = "NotPortalUserName", IsPortal = false}
            };
        }
    }
}