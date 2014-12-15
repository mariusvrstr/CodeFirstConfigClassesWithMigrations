
namespace Database.Repository
{
    using System;
    using System.Linq;
    using Contracts;
    using Entities;

    public class UserRepository : IUserRepository
    {
        public User AddUser(AddUserRequest request)
        {
            var context = ContextFactory.Create();

            var user = new User(request.Name, request.BirthDay, request.FamilyId);

            var newUser = context.Users.Add(user);

            context.SaveChanges();
            return newUser;
        }

        public User GetUserByNameAndFamily(string name, Guid familyId)
        {
            var context = ContextFactory.Create();

            var user = context.Users.FirstOrDefault(usr => usr.Name == name && usr.FamilyId == familyId);

            return user;
        }

        public User GetPersonById(Guid userId)
        {
            var context = ContextFactory.Create();

            var user = context.Users.FirstOrDefault(usr => usr.Id == userId);

            return user;
        }
    }
}
