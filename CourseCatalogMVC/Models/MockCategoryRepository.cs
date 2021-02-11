using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogMVC.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category> {
            new Category {
                CategoryId = 101,
                Name = "Web Technology",
                Description = "All Server-side and Client-side Web Technology courses."
            },
            new Category {
                CategoryId = 102,
                Name = "Data Science",
                Description = "All Data Science related courses."
            },
            new Category {
                CategoryId = 103,
                Name = "Mobile Application Development",
                Description = "Various courses related to Mobile Application Development."
            }
         };
    }
}
