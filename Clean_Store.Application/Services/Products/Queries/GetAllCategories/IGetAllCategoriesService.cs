using Clean_Store.Application.Interfaces.Contexts;
using Clean_Store.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Store.Application.Services.Products.Queries.GetAllCategories
{
    public interface IGetAllCategoriesService
    {
        ResultDto<List<AllCategoriesDto>> Execute();
    }

    public class GetAllCategoriesService : IGetAllCategoriesService
    {
        private readonly IDatabaseContext _context;
        public GetAllCategoriesService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<AllCategoriesDto>> Execute()
        {
            var categories = _context.Categories.Include(p => p.ParentCategory)
                .Where(p => p.ParentCategoryId != null).ToList()
                .Select(p => new AllCategoriesDto
                {
                    Id = p.Id,
                    Name = $"{p.ParentCategory.Name} - {p.Name}"
                }).ToList();
            return new ResultDto<List<AllCategoriesDto>>()
            {
                Data = categories,
                IsSuccess = true,
                Message = "لیست همه دسته بندی ها با موفیت ارسال شد"
            };
        }
    }

    public class AllCategoriesDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
