using Clean_Store.Application.Services.Products.Commands.AddNewCategory;
using Clean_Store.Application.Services.Products.Commands.AddNewProduct;
using Clean_Store.Application.Services.Products.Queries.GetAllCategories;
using Clean_Store.Application.Services.Products.Queries.GetCategories;
using Clean_Store.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Store.Application.Interfaces.FacadPatterns
{
    public interface IProductFacad
    {
        AddNewCategoryService AddNewCategoryService { get; }
        GetCategoriesService GetCategoriesService { get; }
        AddNewProductService AddNewProductService { get; }
        GetAllCategoriesService GetAllCategoriesService { get; }
        GetProductForSiteService GetProductForSiteService { get; }
    }
}
