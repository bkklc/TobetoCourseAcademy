using Core.DataAccess;
using Core.DataAccess.Repositories;
using Core.Persistence.Paging;
using Entities.Concretes;
using Entities.DTOs;

namespace DataAccess.Abstracts;

public interface ICourseDal : IRepository<Course, Guid>, IAsyncRepository<Course, Guid>
{
    Task<IPaginate<CourseDetailsDto>> GetCourseDetails();
}

