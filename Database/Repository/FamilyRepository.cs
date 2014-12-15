
namespace Database.Repository
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Contracts;
    using Entities;

    public class FamilyRepository : IFamilyRepository
    {
        public Family AddFamily(AddFamilyRequest request)
        {
            var context = ContextFactory.Create();

            var family = new Family(request.Surname, request.Origin);

            var newFamily = context.Families.Add(family);

            context.SaveChanges();
            return newFamily;
        }

        public Family GetFamilyById(Guid familyId)
        {
            var context = ContextFactory.Create();

            var family = context.Families.FirstOrDefault(fam => fam.Id == familyId);

            return family;
        }

        public Family GetFamilyBySurname(string surname)
        {
            var context = ContextFactory.Create();

            var family = context.Families.FirstOrDefault(usr => usr.Surname == surname);

            return family;
        }

        public IEnumerable<User> GetFamilyMembers(Guid familyId)
        {
            var context = ContextFactory.Create();

            var members = context.Users.Where(usr => usr.Family.Id == familyId);

            return members;
        }
    }
}
