
namespace Tests.DAL_Tests
{
    using System;
    using System.Transactions;
    using Database.Repository;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StubData.Builders;
    using StubData.ObjectMother;
    using Waldos;

    [TestClass]
    public class UserRepositoryTests
    {
        private TransactionScope _transaction;

        [TestInitialize]
        public void IntitializeTest()
        {
            ObjectMother.Initialize();
           _transaction = new TransactionScope(TransactionScopeOption.RequiresNew, TimeSpan.MaxValue);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _transaction.Dispose();
        }

        [TestMethod]
        public void TestGetUserByFamilyAndName()
        {
            var johan = new UserBuilder().Johan(ObjectMother.Instance.Families.Badenhorst.Id);
            UserWaldo.AddUserAsPrerequisites(johan);

            var userRepo = new UserRepository();
            var found = userRepo.GetUserByNameAndFamily(johan.Build().Name, johan.Build().FamilyId ?? Guid.NewGuid());

            Assert.IsNotNull(found);
            Assert.AreEqual(johan.Build().Id, found.Id);
        }

        [TestMethod]
        public void TestAddingUser()
        {
            var userRepo = new UserRepository();

            var user = userRepo.AddUser(
                new UserBuilder()
                    .Marina(ObjectMother.Instance.Families.Badenhorst.Id)
                    .BuildRequest()
            );

            var found = userRepo.GetPersonById(user.Id);

            Assert.IsNotNull(found);
            Assert.AreEqual(user.ToString(), found.ToString());
        }
    }
}
