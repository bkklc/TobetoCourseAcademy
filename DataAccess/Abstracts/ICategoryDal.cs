﻿using Core.DataAccess;
using Core.DataAccess.Repositories;
using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface ICategoryDal:IRepository<Category, int>, IAsyncRepository<Category, int>
{
    
}
