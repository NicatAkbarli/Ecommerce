using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.DataAccess.EntityFramework.Concrete;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entity.Concrete;

namespace Ecommerce.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal  : EfRepositoryBase<Product, AppDbContext> , IProductDal
    {
        
    }
}