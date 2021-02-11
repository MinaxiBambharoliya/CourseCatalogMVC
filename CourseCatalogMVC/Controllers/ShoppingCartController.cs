using CourseCatalogMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICourseRepository courseRepository;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(ICourseRepository courseRepository, ShoppingCart shoppingCart)
        {
            this.courseRepository = courseRepository;
            this.shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {

            shoppingCart.ShoppingCartItems = shoppingCart.GetShoppingCartItems();

            return View(shoppingCart);
        }

        public RedirectToActionResult AddToShoppingCart(int courseId)
        {
            var SelectedCourse = courseRepository.GetCourseById(courseId);

            shoppingCart.AddItemToCart(SelectedCourse, SelectedCourse.Fee);

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int courseId)
        {
            var SelectedCourse = courseRepository.GetCourseById(courseId);

            shoppingCart.RemoveItemFromCart(SelectedCourse);

            return RedirectToAction("Index");
        }
    }
}
