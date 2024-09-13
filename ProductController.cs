using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROJECTITI.Context;
using PROJECTITI.Models;

namespace PROJECTITI.Controllers
{
    public class ProductController : Controller
    {
        MyContext Db=new MyContext();

        
        public IActionResult Index()
        {
            var _product =Db.Products.Include(p=>p.category);
            return View(_product);
        }
        [HttpGet] 
        public IActionResult Edit(int id)
        {
            var _product = Db.Products.Include(e => e.category).FirstOrDefault(emp => emp.Id == id);
            if (_product == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag._category = new SelectList(Db.Categories, "Id", "Name");
            return View(_product);

            
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ModelState.Remove("Category");
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "All Fields Required");
                ViewBag._category = new SelectList(Db.Categories, "Id", "Name");
                return View();
            }
            Db.Products.Update(product);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var _product = Db.Products.Find(id);
            if (_product == null)
            {
                return RedirectToAction("Index");
            }
            Db.Products.Remove(_product);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag._Category = new SelectList(Db.Categories, "Id", "Name");
            return View();
        }
              [HttpPost]
               public IActionResult Create(Product product)
               {
                   ModelState.Remove("Category");
                   if (!ModelState.IsValid)
                   {
                       ModelState.AddModelError("", "All Fields Required");
                       ViewBag._Departments = new SelectList(Db.Categories, "Id", "Name");
                       return View();
                   }
                   Db.Products.Add(product);
                   Db.SaveChanges();
                   return RedirectToAction("Index");
               }
        [HttpGet]
        public IActionResult ViewDetails(int id)
        {
            var _product = Db.Products.Include(pr=>pr.category).FirstOrDefault(p=>p.Id==id);
            ViewBag._Category = new SelectList(Db.Categories, "Id", "Name");

            if (_product==null)
            {
                return View("index");
            }
            return View(_product);
        }
     
    }
}
