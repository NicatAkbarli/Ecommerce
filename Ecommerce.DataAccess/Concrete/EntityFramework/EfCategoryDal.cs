using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.DataAccess.EntityFramework.Concrete;
using Ecommerce.DataAccess.Abstract;

namespace Ecommerce.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfRepositoryBase<Category , AppDbContext> , ICategoryDal
    {
        
    }
}