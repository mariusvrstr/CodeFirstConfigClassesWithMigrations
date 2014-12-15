
namespace Tests.StubData.Builders
{
    using System;
    using Database.Contracts;
    using Database.Entities;

    public class UserBuilder
    {
        private Guid Id { get; set; }
        private string Name { get; set; }
        private DateTime BirthDay { get; set; }
        private Guid FamilyId { get; set; }

        public UserBuilder()
        {
            this.Id = Guid.NewGuid();
        }

        public UserBuilder Marina(Guid famId)
        {
            this.Name = "Marina";
            this.BirthDay = new DateTime(1992, 06, 27);
            this.FamilyId = famId;

            return this;
        }

        public UserBuilder Jaco(Guid famId)
        {
            this.Name = "Jaco";
            this.BirthDay = new DateTime(1996, 03, 03);
            this.FamilyId = famId;

            return this;
        }

        public UserBuilder Johan(Guid famId)
        {
            this.Name = "Johan";
            this.BirthDay = new DateTime(1996, 03, 03);
            this.FamilyId = famId;

            return this;
        }

        public AddUserRequest BuildRequest()
        {
            return new AddUserRequest
            {
                Name = this.Name,
                BirthDay = this.BirthDay,
                FamilyId = this.FamilyId
            };
        }

        public User Build()
        {
            return new User(
                this.Id, this.Name, this.BirthDay, this.FamilyId);
        }
    }
}
