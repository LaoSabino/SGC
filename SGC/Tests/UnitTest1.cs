using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGC.DI;
using SGC.Infra.Repository;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Saveuser()
        {
            var di = new ModuleDI();

            di.Load();

            var userRepository = Instance.Get<IRepository<User>>();

            //var repo = new UserRepository();



            repo.Create(new SGC.Core.User() { });


        }
    }
}
