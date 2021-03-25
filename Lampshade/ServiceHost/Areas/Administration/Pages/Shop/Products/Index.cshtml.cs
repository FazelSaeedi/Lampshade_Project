using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Administration.Pages.Shop.Products
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        private readonly IProductApplication _productApplication;
        private readonly IProductCategoryApplication _productCategoryApplication;

        public ProductSearchModel SearchModel;
        public List<ProductViewModel> Products;

        public SelectList ProductCategories;
        public IndexModel(IProductApplication productApplication, IProductCategoryApplication productCategoryApplication)
        {
            _productApplication = productApplication;
            _productCategoryApplication = productCategoryApplication;
        }


        public void OnGet(ProductSearchModel SearchModel)
        {
            ProductCategories = new SelectList(_productCategoryApplication.GetProductCategories() , "Id" , "Name");
            Products = _productApplication.Search(SearchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProduct();
            command.Categories = _productCategoryApplication.GetProductCategories();
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateProduct command)
        {
            var result = _productApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var Product = _productApplication.GetDetails(id);
            Product.Categories = _productCategoryApplication.GetProductCategories();
            return Partial("Edit", Product);
        }

        public JsonResult OnPostEdit(EditProduct command)
        {
            if (ModelState.IsValid)
            {
            }

            var result = _productApplication.Edit(command);
            return new JsonResult(result);
        }

       /* public IActionResult OnGetIsInStock(long id)
        {
            var result = _productApplication.IsStock(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetNotInStock(long id)
        {
            var result = _productApplication.NotInStock(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }*/
    }
}
