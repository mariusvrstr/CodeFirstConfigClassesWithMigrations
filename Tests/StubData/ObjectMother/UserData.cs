
using Database.Contracts;

namespace Tests.StubData.ObjectMother
{
    using Database;
    using Database.Entities;
    using Builders;

    public class UserData
    {
        public static User Jaco { get; set; }

        public UserData Init(IDataContext context)
        {
            Jaco = context.Users.Add( new UserBuilder().Jaco(ObjectMother.Instance.Families.Badenhorst.Id).Build());
           
            return this;
        }
    }
}
