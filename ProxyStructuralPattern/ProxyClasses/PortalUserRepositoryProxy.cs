using ProxyStructuralPattern.Contract;
using ProxyStructuralPattern.Models;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ProxyStructuralPattern.ProxyClasses
{
    public class PortalUserRepositoryProxy: IUserRepositoryProxy
    {
        private IUserRepository _userRepository;

        public PortalUserRepositoryProxy([NotNull]IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers()
                .Where(User => User.IsPortal)
                .ToList();
        }
    }
}