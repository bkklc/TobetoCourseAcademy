﻿using Core.Persistence.Paging;
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
        //public IList<Course> GetAll();

        Task<IPaginate<Course>> GetListAsync();
        Task Add(Course course);
        //List<CourseDetailDto> GetCourseDetail();
        Task<IPaginate<CourseDetailsDto>> GetCourseDetailList();

    }
}