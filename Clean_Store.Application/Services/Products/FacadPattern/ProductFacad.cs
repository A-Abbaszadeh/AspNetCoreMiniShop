using Clean_Store.Application.Interfaces.Contexts;
using Clean_Store.Application.Interfaces.FacadPatterns;
using Clean_Store.Application.Services.Products.Commands.AddNewCategory;
using Clean_Store.Application.Services.Products.Commands.AddNewProduct;
using Clean_Store.Application.Services.Products.Queries.GetAllCategories;
using Clean_Store.Application.Services.Products.Queries.GetCategories;
using Clean_Store.Application.Services.Products.Queries.GetProductForSite;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Store.Application.Services.Products.FacadPattern
{
    public class ProductFacad : IProductFacad
    {
        private readonly IDatabaseContext _context;
        private readonly IHostingEnvironment _environment;
        public ProductFacad(IDatabaseContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        private AddNewCategoryService _addNewCategory;
        public AddNewCategoryService AddNewCategoryService 
        {
            get
            {
                return _addNewCategory = _addNewCategory ?? new AddNewCategoryService(_context);
            }
        }

        private GetCategoriesService _getCategoriesService;
        public GetCategoriesService GetCategoriesService
        {
            get
            {
                return _getCategoriesService = _getCategoriesService ?? new GetCategoriesService(_context);
            }
        }

        private AddNewProductService _addNewProductService;
        public AddNewProductService AddNewProductService
        {
            get
            {
                return _addNewProductService = _addNewProductService ?? new AddNewProductService(_context,_environment);
            }
        }

        private GetAllCategoriesService _getAllCategoriesService;
        public GetAllCategoriesService GetAllCategoriesService
        {
            get
            {
                return _getAllCategoriesService = _getAllCategoriesService ?? new GetAllCategoriesService(_context);
            }
        }

        private GetProductForSiteService _getProductForSiteService;
        public GetProductForSiteService GetProductForSiteService
        {
            get
            {
                return _getProductForSiteService = _getProductForSiteService ?? new GetProductForSiteService(_context);
            }
        }
    }
}
