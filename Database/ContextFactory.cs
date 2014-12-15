
using Database.Contracts;

namespace Database
{
    public static class ContextFactory
    {
        public static IDataContext Create()
        {
            return new DataContext();
        }

    }
}
