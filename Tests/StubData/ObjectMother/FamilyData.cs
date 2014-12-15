
using Database.Contracts;

namespace Tests.StubData.ObjectMother
{
    using Database;
    using Database.Entities;
    using Builders;

    public class FamilyData
    {
        public Family Badenhorst { get; set; }

        public FamilyData Init(IDataContext context)
        {
            Badenhorst = context.Families.Add((new FamilyBuilder().Badenhorst().Build()));

            return this;
        }
    }
}
