using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;
using ShopManagement.Application.Contracts.Product;

namespace ShopManagement.Domain.ProductAgg
{
    public interface IProductRepository  : IRepository<long, Product>
    {
        List<ProductViewModel> Search(ProductSearchModel searchModel);

        EditProduct GetDetails(long id);
    }
}
