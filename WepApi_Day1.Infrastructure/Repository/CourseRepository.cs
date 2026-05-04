using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WepApi_Day1.Core.Entities;
using WepApi_Day1.Core.Interfaces;
using WepApi_Day1.Infrastructure.Data;

namespace WepApi_Day1.Infrastructure.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _context;

        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddCourse(Course course)
        {
          _context.Courses.Add(course);
              _context.SaveChanges();

        }

        public void DeleteCourse(int id)
        {
            _context.Courses.Remove(_context.Courses.FirstOrDefault(c => c.Id == id));
            _context.SaveChanges();

        }

        public IEnumerable<Course> GetAllCourses()
        {
          return _context.Courses.ToList();
             

        }

        public Course? GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(c=>c.Id == id);

             
        }

        public Course? GetCourseByName(string name)
        {
           return  _context.Courses.FirstOrDefault(c => c.Crs_Name == name);

        }

        public bool UpdateCourse(int id, Course course)
        {
            var existingCourse = _context.Courses.Find(id);

            if (existingCourse == null)
                return false;

            existingCourse.Crs_Name = course.Crs_Name;

            _context.SaveChanges();

            return true;
        }
    }
}
