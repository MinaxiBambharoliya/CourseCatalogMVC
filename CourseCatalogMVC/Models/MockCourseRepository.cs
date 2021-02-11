using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogMVC.Models
{
    public class MockCourseRepository : ICourseRepository
    {
        private readonly ICategoryRepository categoryRepository;
        public MockCourseRepository(ICategoryRepository repo)
        {
            categoryRepository = repo;
        }

        public IEnumerable<Course> AllCourses => new List<Course> {
        new Course
        {
            CourseId = 1,
            Title = "ASP.NET Core",
            Description = "",
            Fee = 1350,
            isWeekendClassAvailable = true,
            ImageUrl = "",
            Category = categoryRepository.AllCategories.ToList()[0]
        },
           new Course
        {
            CourseId = 2,
            Title = "Python",
            Description = "",
            Fee = 1350,
            isWeekendClassAvailable = false,
            ImageUrl = "",
            Category = categoryRepository.AllCategories.ToList()[2]
        },
              new Course
        {
            CourseId = 3,
            Title = ".NET Core",
            Description = "",
            Fee = 1350,
            isWeekendClassAvailable = false,
            ImageUrl = "",
            Category = categoryRepository.AllCategories.ToList()[0]
        },
                 new Course
        {
            CourseId = 4,
            Title = "Android Application Development",
            Description = "",
            Fee = 2250,
            isWeekendClassAvailable = true,
            ImageUrl = "",
            Category = categoryRepository.AllCategories.ToList()[2]
        },
                    new Course
        {
            CourseId = 5,
            Title = "Data Analysis Course",
            Description = "",
            Fee = 1350,
            isWeekendClassAvailable = false,
            ImageUrl = "",
            Category = categoryRepository.AllCategories.ToList()[1]
        },
                       new Course
        {
            CourseId = 6,
            Title = "Entity Framework",
            Description = "",
            Fee = 1350,
            isWeekendClassAvailable = false,
            ImageUrl = "",
            Category = categoryRepository.AllCategories.ToList()[0]
        }
        };

        public IEnumerable<Course> FreeCoursesOfTheWeek { get; }

        public Course GetCourseById(int courseId)
        {
            return AllCourses.FirstOrDefault(c => c.CourseId==courseId);
        }
    }
}
