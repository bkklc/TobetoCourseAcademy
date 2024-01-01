
using Business.DTOs.Requests;
using Business.DTOs.Responses;
using Core.Persistence.Paging;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {       

        Task<IPaginate<Course>> GetListAsync();
        Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);


        //Task Delete(Course course);       
        //Task<IPaginate<CourseDetailsDto>> GetCourseDetailListAsync();

    }
}
