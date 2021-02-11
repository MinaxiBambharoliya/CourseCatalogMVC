using CourseCatalogMVC.Models;
using CourseCatalogMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogMVC.Controllers
{
    public class CourseController : Controller

    {
        private readonly ICourseRepository courseRepository;
        private readonly ICategoryRepository categoryRepository;

        public CourseController(ICourseRepository courseRepository, ICategoryRepository categoryRepository)
        {
            this.courseRepository = courseRepository;
            this.categoryRepository = categoryRepository;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public ViewResult List()
        {
            //ViewBag.SelectedCategory = categoryRepository.AllCategories.ToList()[2].Name;
            //return View(courseRepository.AllCourses);

            CourseListVM courseListVM = new CourseListVM()
            {
                Courses = courseRepository.AllCourses,
                SelectedCategorName = categoryRepository.AllCategories.ToList()[2].Name
            };

            return View(courseListVM); // Still passing all the courses
        }

        public IActionResult Details(int id)
        {
            var course = courseRepository.GetCourseById(id);
            return View(course);
        }
    }
}
