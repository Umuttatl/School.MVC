using Microsoft.AspNetCore.Mvc;
using School.Models;
using System.Linq;

namespace LibApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            using (StudentContext db = new StudentContext())
            {
                var model = db.Students.ToList();
                return View(model);
            }
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            using (StudentContext db = new StudentContext())
            {
                db.Students.Add(student);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            using (StudentContext db = new StudentContext())
            {
                var student = db.Students.Find(id);
                db.Students.Remove(student);

                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public IActionResult Update(int id)
        {
            using (StudentContext db = new StudentContext())
            {
                var model = db.Students.Find(id);
                return View(model);
            }
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            using (StudentContext db = new StudentContext())
            {
                var model = db.Students.Update(student);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}
