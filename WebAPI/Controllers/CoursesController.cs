using Business.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;
        ICategoryService _categoryService;
        public CoursesController(ICourseService courseService, ICategoryService categoryService)
        {
            _courseService = courseService;
            _categoryService = categoryService;
        }
               

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] Course course)
        {
            await _courseService.Add(course);
            return Ok();
        }


        [HttpGet("GetList")]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseService.GetListAsync();
            return Ok(result);
        }

        [HttpGet("getCourseDetails")]
        public async Task<IActionResult> GetCourseDetailList()
        {
            var result = await _courseService.GetCourseDetailListAsync();
            return Ok(result);
        }


    }

}