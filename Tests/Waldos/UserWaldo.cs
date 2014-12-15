
namespace Tests.Waldos
{
    using Database;
    using StubData.Builders;

    public static class UserWaldo
    {
        public static void AddUserAsPrerequisites(UserBuilder userBuider)
        {
            var context = ContextFactory.Create();
            context.Users.Add(userBuider.Build());
            context.SaveChanges();
        }
    }
}
