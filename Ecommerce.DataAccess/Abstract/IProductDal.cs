using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.DataAccess.EntityFramework.Abstract;
using Ecommerce.Entity.Concrete;

namespace Ecommerce.DataAccess.Abstract
{
    public interface IProductDal : IRepositoryBase<Product>
    {
        
    }
}