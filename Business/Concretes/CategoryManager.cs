using Business.Abstracts;
using Core.Persistence.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categortyDal;
    public CategoryManager(ICategoryDal categortyDal)
    {
        _categortyDal = categortyDal;
    }

    public async Task Add(Category category)
    {
        await _categortyDal.AddAsync(category);
    }    

    public async Task<IPaginate<Category>> GetListAsync()
    {
        return await _categortyDal.GetListAsync();
    }
}
