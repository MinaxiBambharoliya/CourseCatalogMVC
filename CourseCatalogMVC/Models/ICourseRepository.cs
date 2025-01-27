﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogMVC.Models
{
    public interface ICourseRepository
    {
        IEnumerable<Course> AllCourses { get; }

        IEnumerable<Course> FreeCoursesOfTheWeek { get; }

        Course GetCourseById(int courseId);

    }
}
