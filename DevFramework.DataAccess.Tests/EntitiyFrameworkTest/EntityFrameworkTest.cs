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

        [TestMethod]
        public void Get_all_with_parameters_returns_filtered_products()
        {
            EfProductDal efProductDal = new EfProductDal();
            var result = efProductDal.GetList(p=>p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);

        }



    }
}
