using System;
using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal: Core.DataAccess.IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();

    }
}


//Code Refactoring: