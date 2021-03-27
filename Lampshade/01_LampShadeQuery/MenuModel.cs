using _01_LampshadeQuery.Contracts.ArticleCategory;
using System.Collections.Generic;
using _01_LampShadeQuery.Contract.ProductCategory;

namespace _01_LampshadeQuery
{
    public class MenuModel
    {
        public List<ArticleCategoryQueryModel> ArticleCategories { get; set; }
        public List<ProductCategoryQueryModel> ProductCategories { get; set; }
    }
}
