using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApi_Day1.Core.Entities;
using WepApi_Day1.Core.Interfaces;

namespace WepApi_Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository; 

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;

        }

        [HttpGet]
        public IActionResult GetAllCourses()
        {
            return Ok(_courseRepository.GetAllCourses());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCourse(int id)
        {
            var course = _courseRepository.GetCourseById(id);
            if (course == null)
                return NotFound();//404
            return Ok(course);
        }

        [HttpGet("{Crs_Name:alpha}")]

        public IActionResult GetCourseByName(string Crs_Name)
        {
            var course = _courseRepository.GetCourseByName(Crs_Name);
            if (course == null)
                return NotFound();//404
            return Ok(course);

        }
        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            if (course == null)
                return BadRequest();

            _courseRepository.AddCourse(course);
            return Created();   //202
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateCourse(Course course)
        {
            var existingCourse = _courseRepository.GetCourseById(course.Id);
            if (existingCourse == null)
                return NotFound();//404
            _courseRepository.UpdateCourse(course.Id, course);
            return NoContent();   //204

        }
       
        [HttpDelete]
         public IActionResult DeleteCourse(int id)
        {
            var existingCourse = _courseRepository.GetCourseById(id);
            if (existingCourse == null)
                return NotFound();//404
            _courseRepository.DeleteCourse(id);
            return Ok();
        }


    }
}
