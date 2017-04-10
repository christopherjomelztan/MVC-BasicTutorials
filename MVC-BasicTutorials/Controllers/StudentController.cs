using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_BasicTutorials.Controllers
{
    public class StudentController : Controller
    {
        [ActionName("TestChangeName")]
        public ActionResult ActionNameSample(string action)
        {
            ViewBag.Message = action;
            return View();
        }

        public ActionResult Edit(string std)
        {
            return View();
        }

 
        public ActionResult Delete(int id)
        {
            return View();
        }

        // GET: Student
        public ActionResult Index()
        {
            Models.Student student = new Models.Student();
            return View(student.FillStudent());
        }

        public ActionResult RazorSyntax()
        {
            return View();
        }

        public ActionResult HTMLHelpers()
        {
            return View();
        }
    }
}