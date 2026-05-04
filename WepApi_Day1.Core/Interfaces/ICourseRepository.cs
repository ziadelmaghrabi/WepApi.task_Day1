using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WepApi_Day1.Core.Entities;

namespace WepApi_Day1.Core.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourses();
        Course? GetCourseById(int id);

        Course? GetCourseByName(string name);
        void AddCourse(Course course);
        bool UpdateCourse(int id, Course course);
        void DeleteCourse(int id);

    }
}
