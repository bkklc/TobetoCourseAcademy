using Core.DataAccess.Repositories;
using Core.Persistence.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Contexts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfRepositoryBase<Course, Guid, NorthwindContext>, ICourseDal
    {
        NorthwindContext _context;
        public EfCourseDal(NorthwindContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IPaginate<CourseDetailsDto>> GetCourseDetails()
        {
            int index = 0;
            int size = 20;

            var result = await (from course in _context.Courses
                                join category in _context.Categories
                                on course.CategoryId equals category.Id
                                select new CourseDetailsDto
                                {
                                    CategoryName = category.Name,
                                    CourseName = course.Name
                                }).ToPaginateAsync(index, size, 0);

            return result;
        }
    }
}