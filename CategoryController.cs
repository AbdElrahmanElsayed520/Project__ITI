using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROJECTITI.Context;
using PROJECTITI.Models;

namespace PROJECTITI.Controllers
{
    public class CategoryController : Controller
    {
        MyContext Db = new MyContext();
        public IActionResult Index()
        {
            var _category = Db.Categories;
            return View(_category);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "All Fields Are Requird");
                return View();
            }
            Db.Categories.Add(category);
            Db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            var _category = Db.Categories.Find(id);
            if (_category == null)
            {
                return RedirectToAction("Index");
            }
            Db.Categories.Remove(_category);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var _category = Db.Categories.FirstOrDefault(c => c.Id == id);
            if (_category == null)
            {
                return RedirectToAction("Index");
            }
            return View(_category);


        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "All Fields Required");
                return View();
            }
            Db.Categories.Update(category);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ViewDetails(int id)
        {
            var _category = Db.Categories.FirstOrDefault(p => p.Id == id);
            
            if (_category == null)
            {
                return View("index");
            }
            return View(_category);
        }

    }
}
