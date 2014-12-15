
namespace Database.Contracts
{
    using System;
    using System.Collections.Generic;
    using Entities;

    public interface IFamilyRepository
    {
        Family AddFamily(AddFamilyRequest request);

        Family GetFamilyById(Guid familyId);

        Family GetFamilyBySurname(string surname);

        IEnumerable<User> GetFamilyMembers(Guid familyId);
    }
}
