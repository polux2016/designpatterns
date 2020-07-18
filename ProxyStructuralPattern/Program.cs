using System;
using ProxyStructuralPattern.ProxyClasses;
using System.Linq;

namespace ProxyStructuralPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get All Users for Portal");
            var realRepo = new UserRepository();
            var portalRepo = new PortalUserRepositoryProxy(realRepo);
            var notPortalRepo = new NotPortalUserRepositoryProxy(realRepo);
            
            //WARNIGN!! It is not possible to put proxy into proxy
            //var notPortalRepo = new NotPortalUserRepositoryProxy(portalRepo);

            var users = portalRepo.GetAllUsers();
            Console.WriteLine($"Portal Users count = {users.Count()}");
            Console.WriteLine($"First Portal User name = {users.First().Name}");

            users = notPortalRepo.GetAllUsers();
            Console.WriteLine($"Not portal Users count = {users.Count()}");
            Console.WriteLine($"First not portal User name = {users.First().Name}");
        }
    }
}
