using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Business.Abstract;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entity.Dtos.CategoryCreateDtos;
using Ecommerce.Entity.Dtos.CategoryDtos;

namespace Ecommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IMapper _mapper;
     private readonly ICategoryDal  _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void CreateCategory(CategoryCreateDto categoryCreate)
        {
            var map = _mapper.Map<Category>(categoryCreate);
            _categoryDal.Add(map);
        }

        public List<CategoryHomeDto> GetHomeCategories()
        {
            throw new NotImplementedException();
        }
    }
}