using Business.Abstracts;
using Business.DTOs.Requests;
using Business.DTOs.Responses;
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

    public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
    {
        Course course = new Course();
        course.Id = Guid.NewGuid();
        course.Name = createCourseRequest.Name;
        course.CategoryId = createCourseRequest.CategoryId;
        course.Description = createCourseRequest.Description;

        Course createdCourse = await _courseDal.AddAsync(course);

        CreatedCourseResponse createdCourseResponse = new CreatedCourseResponse();
        createdCourseResponse.Id = createdCourse.Id;
        createdCourseResponse.Name = createdCourse.Name;
        createdCourseResponse.CategoryId = createdCourse.CategoryId;
        createdCourseResponse.Description = createdCourse.Description;
        return createdCourseResponse;
    }

    public async Task Delete(Course course)
    {
        await _courseDal.DeleteAsync(course,true);
    }

    public async Task<IPaginate<CourseDetailsDto>> GetCourseDetailListAsync()
    {
         return await _courseDal.GetCourseDetails();
    }

    
    public async Task<IPaginate<Course>> GetListAsync()
    {
        return await _courseDal.GetListAsync();
    }
}

