using ProxyStructuralPattern.Models;
using System.Collections.Generic;

namespace ProxyStructuralPattern.Contract
{
    public interface IUserRepositoryProxy
    {
        List<User> GetAllUsers();
    }
}