
namespace Database.Contracts
{
    using System;
    using Entities;

    public interface IUserRepository
    {
        User AddUser(AddUserRequest request);

        User GetUserByNameAndFamily(string name, Guid familyId);

        User GetPersonById(Guid userIdy);
    }
}
