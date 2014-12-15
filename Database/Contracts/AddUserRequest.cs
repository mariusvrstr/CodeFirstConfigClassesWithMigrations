
namespace Database.Contracts
{
    using System;

    public class AddUserRequest
    {
        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public Guid FamilyId { get; set; }
    }
}
