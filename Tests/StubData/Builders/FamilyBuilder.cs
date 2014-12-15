
namespace Tests.StubData.Builders
{
    using System;
    using Database.Contracts;
    using Database.Entities;

    public class FamilyBuilder
    {
        private Guid Id { get; set; }
        private string Surname { get; set; }
        private string Origin { get; set; }

        public FamilyBuilder()
        {
            this.Id = Guid.NewGuid();
        }

        public FamilyBuilder Badenhorst()
        {
            this.Surname = "Badenhorst";
            this.Origin = "Dutch";

            return this;
        }

        public AddFamilyRequest BuildRequest()
        {
            return new AddFamilyRequest
            {
                Surname = this.Surname,
                Origin = this.Origin
            };
        }

        public Family Build()
        {
            return new Family(this.Id, this.Surname, this.Origin);
        }
    }
}
