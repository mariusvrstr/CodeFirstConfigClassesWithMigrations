
using Database.Contracts;

namespace Tests.StubData.ObjectMother
{
    using System.Linq;
    using Database;

    public class ObjectMother
    {
        private static ObjectMother instance { get; set; }

        public UserData Users { get; set; }

        public FamilyData Families { get; set; }

        public static ObjectMother Instance
        {
            get
            {
                if (instance == null)
                {
                    Initialize();
                }

                return instance;
            }
        }
        
        public static void Initialize()
        {
            instance = new ObjectMother();
            var context = ContextFactory.Create();

            ClearData(context);

            instance.Families = new FamilyData().Init(context);
            instance.Users = new UserData().Init(context);

            context.SaveChanges();
        }

        private static void ClearData(IDataContext context)
        {
            if (context.Users.Any())
            {
                foreach (var user in context.Users)
                {
                    context.Users.Remove(user);
                }
            }

            if (context.Families.Any())
            {
                foreach (var family in context.Families)
                {
                    context.Families.Remove(family);
                }
            }
        }
    }
}
