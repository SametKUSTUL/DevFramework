using DevFramework.Nortwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.DataAccess.Tests.EntitiyFrameworkTest
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal efProductDal = new EfProductDal();
            var result = efProductDal.GetList();

            Assert.AreEqual(79, result.Count);

        }
    }
}
