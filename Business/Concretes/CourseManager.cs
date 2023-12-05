using Business.Abstracts;
using Core.Persistence.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public async Task Add(Course course)
    {
        await _courseDal.AddAsync(course);        
    }

    //public List<CourseDetailDto> GetCourseDetail()
    //{
    //    return _courseDal.GetCourseDetail();
    //}

    public async Task<IPaginate<CourseDetailsDto>> GetCourseDetailList()
    {
         return await _courseDal.GetCourseDetails();
    }

    //public IList<Course> GetAll()
    //    {
    //        //iş kodları
    //        EfCourseDal courseDal = new EfCourseDal();
    //        return courseDal.GetList();

    //    }

    public async Task<IPaginate<Course>> GetListAsync()
    {
        return await _courseDal.GetListAsync();
    }
}

