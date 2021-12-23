using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwind.Entities.Concrete;
using DevFramework.Nortwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Nortwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
      
    }
}
